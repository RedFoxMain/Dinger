using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinger {
    public class ClientEventArgs : EventArgs {
        public string ID;
        public string Name;

        public ClientEventArgs(string id, string name){
            ID = id;
            Name = name;
        }
    }

    public class DingerTcpServer {
        private TcpListener _listener;
        private List<DingerTcpClient> _clients;
        private ListBox _server_logs;

        public DingerTcpServer(string ip_address, int port, ListBox logs) {
            _listener = new TcpListener(IPAddress.Parse(ip_address), port);
            _clients = new List<DingerTcpClient>();
            _server_logs = logs;
        }
        
        public async Task Start(CancellationTokenSource clt_token) {
            CancellationToken token = clt_token.Token;
            _listener.Start();
            while (!clt_token.IsCancellationRequested) {
                TcpClient tcp_client;
                DingerTcpClient client = null;
                try {
                    tcp_client = await _listener.AcceptTcpClientAsync();
                    client = new DingerTcpClient(tcp_client, this);
                    client.Name = await client.Reader.ReadLineAsync();
                    if (_clients.All(c => c.ID != client.ID)) {
                        _clients.Add(client);
                        await BroadcastAsync($"{client.Name} connected to the server!", client.ID);
                        _server_logs?.Invoke((Action)delegate {
                            _server_logs.Items.Add($"[{DateTime.Now}] {client.Name} connected to the server!");
                        });
                    }
                    _ = Task.Run(async() => await Listen(client, token));
                } catch (Exception ex) { 
                    RemoveClient(client.ID);
                    clt_token.Cancel();
                    Console.WriteLine(ex.Message); 
                }
            }
        }

        private async Task Listen(DingerTcpClient client, CancellationToken token) {
            try {
                while (!token.IsCancellationRequested) {
                    string? message = await client.Reader.ReadLineAsync();
                    if (string.IsNullOrEmpty(message)) continue;
                    await BroadcastAsync(message, client.ID);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                client.Close();
            }
        }

        private void RemoveClient(string id) {
            if (string.IsNullOrEmpty(id)) return;
            DingerTcpClient? client = _clients.FirstOrDefault(el => el.ID == id);
            if (client != null) _clients.Remove(client);
        }

        public async Task BroadcastAsync(string message, string id) {
            List<Task> tasks = new List<Task>();
            foreach (DingerTcpClient client in _clients) {
                if (!client.ID.Equals(id)) {
                    tasks.Add(Task.Run(async () => {
                        await client.Writer.WriteLineAsync(message);
                    }));
                }
            }
            await Task.WhenAll(tasks);
        }

        public void Stop() {
            _clients.ForEach(_client => _client.Close());
            _clients.Clear();
            _listener.Stop();
        }
    }
}