using System;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Client {
    public partial class Form1 : Form {
        private TcpClient _client = new TcpClient();
        private CancellationTokenSource _clt = new CancellationTokenSource();
        private StreamReader Reader { get; set; }
        private StreamWriter Writer { get; set; }

        public Form1() {
            InitializeComponent();
        }

        private void send_btn_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(msg_text.Text)) return;
            string user = string.IsNullOrEmpty(nickname.Text) ? "New User" : nickname.Text;
            Writer.WriteLineAsync($"{nickname.Text}: {msg_text.Text}");
            msg_view.Items.Add($"[{DateTime.Now}] {msg_text.Text}");
            msg_text.Clear();
        }

        private void connect_btn_Click(object sender, EventArgs e) {
            CancellationToken token = _clt.Token;
            _client.Connect(server_ip.Text, 5555);
            NetworkStream stream = _client.GetStream();
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream) { AutoFlush = true };
            connect_btn.Enabled = false;
            disconnect_btn.Enabled = true;
            nickname.Enabled = false;
            msg_text.Enabled = true;
            send_btn.Enabled = true;
            server_ip.Enabled = false;
            msg_view.Items.Clear();
            msg_view.Items.Add($"You are now connected to the server!");
            Task.Run(() => Process(token), token);
        }

        private async Task Process(CancellationToken token) { 
            try {
                await Writer.WriteLineAsync(nickname.Text);
                while (!token.IsCancellationRequested) {
                    string message = await Reader.ReadLineAsync();
                    msg_view?.Invoke((Action)delegate {
                        msg_view.Items.Add($"[{DateTime.Now}] {message}");
                    });
                }
            } catch (Exception) {
                _clt.Cancel();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            _clt.Cancel();
            _client.Close();
        }

        private void disconnect_btn_Click(object sender, EventArgs e) {
            _clt.Cancel();
            nickname.Enabled = true;
            connect_btn.Enabled = true;
            disconnect_btn.Enabled = false;
            msg_text.Enabled = false;
            send_btn.Enabled = false;
            server_ip.Enabled = true;
        }
    }
}