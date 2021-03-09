namespace Botmeis
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbChannel = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbOAuth = new System.Windows.Forms.TextBox();
            this.tbStartMessage = new System.Windows.Forms.TextBox();
            this.lbChannel = new System.Windows.Forms.Label();
            this.lbOAuth = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbStartMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(309, 171);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbChannel
            // 
            this.tbChannel.Location = new System.Drawing.Point(85, 119);
            this.tbChannel.Name = "tbChannel";
            this.tbChannel.Size = new System.Drawing.Size(100, 20);
            this.tbChannel.TabIndex = 1;
            this.tbChannel.TextChanged += new System.EventHandler(this.tbChannel_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(85, 93);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // tbOAuth
            // 
            this.tbOAuth.Location = new System.Drawing.Point(85, 145);
            this.tbOAuth.Name = "tbOAuth";
            this.tbOAuth.PasswordChar = '*';
            this.tbOAuth.Size = new System.Drawing.Size(100, 20);
            this.tbOAuth.TabIndex = 3;
            this.tbOAuth.TextChanged += new System.EventHandler(this.tbOAuth_TextChanged);
            // 
            // tbStartMessage
            // 
            this.tbStartMessage.Location = new System.Drawing.Point(85, 171);
            this.tbStartMessage.Name = "tbStartMessage";
            this.tbStartMessage.Size = new System.Drawing.Size(195, 20);
            this.tbStartMessage.TabIndex = 4;
            this.tbStartMessage.TextChanged += new System.EventHandler(this.tbStartMessage_TextChanged);
            // 
            // lbChannel
            // 
            this.lbChannel.AutoSize = true;
            this.lbChannel.BackColor = System.Drawing.SystemColors.Window;
            this.lbChannel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbChannel.Location = new System.Drawing.Point(135, 122);
            this.lbChannel.Name = "lbChannel";
            this.lbChannel.Size = new System.Drawing.Size(46, 13);
            this.lbChannel.TabIndex = 7;
            this.lbChannel.Text = "Channel";
            this.lbChannel.Click += new System.EventHandler(this.lbChannel_Click);
            // 
            // lbOAuth
            // 
            this.lbOAuth.AutoSize = true;
            this.lbOAuth.BackColor = System.Drawing.SystemColors.Window;
            this.lbOAuth.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbOAuth.Location = new System.Drawing.Point(144, 148);
            this.lbOAuth.Name = "lbOAuth";
            this.lbOAuth.Size = new System.Drawing.Size(37, 13);
            this.lbOAuth.TabIndex = 8;
            this.lbOAuth.Text = "OAuth";
            this.lbOAuth.Click += new System.EventHandler(this.lbOAuth_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.SystemColors.Window;
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbUsername.Location = new System.Drawing.Point(127, 96);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 13);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Username";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // lbStartMessage
            // 
            this.lbStartMessage.AutoSize = true;
            this.lbStartMessage.BackColor = System.Drawing.SystemColors.Window;
            this.lbStartMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbStartMessage.Location = new System.Drawing.Point(205, 174);
            this.lbStartMessage.Name = "lbStartMessage";
            this.lbStartMessage.Size = new System.Drawing.Size(71, 13);
            this.lbStartMessage.TabIndex = 15;
            this.lbStartMessage.Text = "Startmessage";
            this.lbStartMessage.Click += new System.EventHandler(this.lbStartMessage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStartMessage);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbOAuth);
            this.Controls.Add(this.lbChannel);
            this.Controls.Add(this.tbStartMessage);
            this.Controls.Add(this.tbOAuth);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbChannel);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Botmeis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbChannel;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbOAuth;
        private System.Windows.Forms.TextBox tbStartMessage;
        private System.Windows.Forms.Label lbChannel;
        private System.Windows.Forms.Label lbOAuth;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbStartMessage;
    }
}

