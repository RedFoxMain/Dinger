using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Dinger {
    internal class DingerTcpClient {
        public string ID { get; private set; }
        public string Name { get; set; }
        public bool Connected { get; set; }
        public StreamReader Reader { get; set; }
        public StreamWriter Writer { get; set; }

        private TcpClient _client;
        private DingerTcpServer _server;
        
        public DingerTcpClient(TcpClient client, DingerTcpServer server) {
            Connected = client.Connected;
            ID = Guid.NewGuid().ToString();
            _server = server;
            _client = client;
            Reader = new StreamReader(_client.GetStream());
            Writer = new StreamWriter(_client.GetStream()) { AutoFlush = true };
        }

        public void Close() {
            Reader.Close();
            Writer.Close();
            Connected = false;
            ID = string.Empty;
            Name = string.Empty;
            _client.Close();
        }

        public override string ToString() {
            return $"ID: {ID} Name: {Name}\n";
        }
    }
}