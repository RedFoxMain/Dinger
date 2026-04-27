namespace Dinger
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
            this.server_label = new System.Windows.Forms.Label();
            this.server_ip = new System.Windows.Forms.TextBox();
            this.server_logs = new System.Windows.Forms.ListBox();
            this.start_server_btn = new System.Windows.Forms.Button();
            this.stop_server_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // server_label
            // 
            this.server_label.AutoSize = true;
            this.server_label.Location = new System.Drawing.Point(12, 16);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(38, 13);
            this.server_label.TabIndex = 0;
            this.server_label.Text = "Server";
            // 
            // server_ip
            // 
            this.server_ip.Location = new System.Drawing.Point(55, 13);
            this.server_ip.Name = "server_ip";
            this.server_ip.Size = new System.Drawing.Size(733, 20);
            this.server_ip.TabIndex = 1;
            this.server_ip.Text = "127.0.0.1";
            // 
            // server_logs
            // 
            this.server_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.server_logs.FormattingEnabled = true;
            this.server_logs.ItemHeight = 16;
            this.server_logs.Location = new System.Drawing.Point(15, 39);
            this.server_logs.Name = "server_logs";
            this.server_logs.Size = new System.Drawing.Size(773, 308);
            this.server_logs.TabIndex = 2;
            // 
            // start_server_btn
            // 
            this.start_server_btn.Location = new System.Drawing.Point(15, 356);
            this.start_server_btn.Name = "start_server_btn";
            this.start_server_btn.Size = new System.Drawing.Size(75, 23);
            this.start_server_btn.TabIndex = 3;
            this.start_server_btn.Text = "Start";
            this.start_server_btn.UseVisualStyleBackColor = true;
            this.start_server_btn.Click += new System.EventHandler(this.start_server_btn_Click);
            // 
            // stop_server_btn
            // 
            this.stop_server_btn.Location = new System.Drawing.Point(97, 356);
            this.stop_server_btn.Name = "stop_server_btn";
            this.stop_server_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_server_btn.TabIndex = 4;
            this.stop_server_btn.Text = "Stop";
            this.stop_server_btn.UseVisualStyleBackColor = true;
            this.stop_server_btn.Click += new System.EventHandler(this.stop_server_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.stop_server_btn);
            this.Controls.Add(this.start_server_btn);
            this.Controls.Add(this.server_logs);
            this.Controls.Add(this.server_ip);
            this.Controls.Add(this.server_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label server_label;
        private System.Windows.Forms.TextBox server_ip;
        private System.Windows.Forms.ListBox server_logs;
        private System.Windows.Forms.Button start_server_btn;
        private System.Windows.Forms.Button stop_server_btn;
    }
}

