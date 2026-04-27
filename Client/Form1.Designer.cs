namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msg_view = new System.Windows.Forms.ListBox();
            this.server_ip = new System.Windows.Forms.TextBox();
            this.server_label = new System.Windows.Forms.Label();
            this.msg_text = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.nickname = new System.Windows.Forms.TextBox();
            this.nickname_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msg_view
            // 
            this.msg_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msg_view.FormattingEnabled = true;
            this.msg_view.ItemHeight = 16;
            this.msg_view.Location = new System.Drawing.Point(15, 38);
            this.msg_view.Name = "msg_view";
            this.msg_view.Size = new System.Drawing.Size(773, 308);
            this.msg_view.TabIndex = 7;
            // 
            // server_ip
            // 
            this.server_ip.Location = new System.Drawing.Point(55, 12);
            this.server_ip.Name = "server_ip";
            this.server_ip.Size = new System.Drawing.Size(104, 20);
            this.server_ip.TabIndex = 6;
            this.server_ip.Text = "127.0.0.1";
            // 
            // server_label
            // 
            this.server_label.AutoSize = true;
            this.server_label.Location = new System.Drawing.Point(12, 15);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(38, 13);
            this.server_label.TabIndex = 5;
            this.server_label.Text = "Server";
            // 
            // msg_text
            // 
            this.msg_text.Enabled = false;
            this.msg_text.Location = new System.Drawing.Point(15, 353);
            this.msg_text.Name = "msg_text";
            this.msg_text.Size = new System.Drawing.Size(692, 20);
            this.msg_text.TabIndex = 8;
            // 
            // send_btn
            // 
            this.send_btn.Enabled = false;
            this.send_btn.Location = new System.Drawing.Point(713, 353);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 20);
            this.send_btn.TabIndex = 9;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(632, 12);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 20);
            this.connect_btn.TabIndex = 10;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Enabled = false;
            this.disconnect_btn.Location = new System.Drawing.Point(713, 12);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(75, 20);
            this.disconnect_btn.TabIndex = 11;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(228, 12);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(398, 20);
            this.nickname.TabIndex = 13;
            this.nickname.Text = "New User";
            // 
            // nickname_label
            // 
            this.nickname_label.AutoSize = true;
            this.nickname_label.Location = new System.Drawing.Point(167, 15);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(55, 13);
            this.nickname_label.TabIndex = 12;
            this.nickname_label.Text = "Nickname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.nickname_label);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.msg_text);
            this.Controls.Add(this.msg_view);
            this.Controls.Add(this.server_ip);
            this.Controls.Add(this.server_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox msg_view;
        private System.Windows.Forms.TextBox server_ip;
        private System.Windows.Forms.Label server_label;
        private System.Windows.Forms.TextBox msg_text;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label nickname_label;
    }
}

