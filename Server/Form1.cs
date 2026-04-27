using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinger {
    public partial class Form1 : Form {
        private DingerTcpServer _server;
        private CancellationTokenSource _clt = new CancellationTokenSource();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            stop_server_btn.Enabled = false;
            _server = new DingerTcpServer(server_ip.Text, 5555, server_logs);
        }

        private void start_server_btn_Click(object sender, EventArgs e) {
            server_logs.Items.Add($"[{DateTime.Now}] Server started!");
            stop_server_btn.Enabled = true;
            start_server_btn.Enabled = false;
            server_ip.Enabled = false;
            Task.Run(() => _server.Start(_clt), _clt.Token);
        }

        private void stop_server_btn_Click(object sender, EventArgs e) {
            server_logs.Items.Add($"[{DateTime.Now}] Server stoped");
            stop_server_btn.Enabled = false;
            start_server_btn.Enabled = true;
            server_ip.Enabled = true;
            _clt.Cancel();
            _server.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            _clt.Dispose();
        }
    }
}