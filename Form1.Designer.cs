namespace TCPChat2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnStart = new Button();
            txtBox_ServerIP = new TextBox();
            txtBox_ClientIP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnConnect = new Button();
            btnSend = new Button();
            txtBox_ClientPort = new TextBox();
            txtBox_ServerPort = new TextBox();
            txtBox_ChatScreen = new TextBox();
            txtBox_Message = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            btnStop = new Button();
            btnDisconnect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(530, 59);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(87, 25);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtBox_ServerIP
            // 
            txtBox_ServerIP.Location = new Point(105, 54);
            txtBox_ServerIP.Multiline = true;
            txtBox_ServerIP.Name = "txtBox_ServerIP";
            txtBox_ServerIP.Size = new Size(163, 23);
            txtBox_ServerIP.TabIndex = 2;
            // 
            // txtBox_ClientIP
            // 
            txtBox_ClientIP.Location = new Point(105, 151);
            txtBox_ClientIP.Multiline = true;
            txtBox_ClientIP.Name = "txtBox_ClientIP";
            txtBox_ClientIP.Size = new Size(163, 23);
            txtBox_ClientIP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 125);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Client";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 62);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 57);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 6;
            label4.Text = "IP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(316, 235);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 154);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 9;
            label7.Text = "IP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 151);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 10;
            label8.Text = "Port";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(576, 146);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(87, 23);
            btnConnect.TabIndex = 11;
            btnConnect.Text = "CONNECT";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(576, 215);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(87, 23);
            btnSend.TabIndex = 12;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtBox_ClientPort
            // 
            txtBox_ClientPort.Location = new Point(359, 148);
            txtBox_ClientPort.Multiline = true;
            txtBox_ClientPort.Name = "txtBox_ClientPort";
            txtBox_ClientPort.Size = new Size(140, 23);
            txtBox_ClientPort.TabIndex = 13;
            // 
            // txtBox_ServerPort
            // 
            txtBox_ServerPort.Location = new Point(359, 59);
            txtBox_ServerPort.Multiline = true;
            txtBox_ServerPort.Name = "txtBox_ServerPort";
            txtBox_ServerPort.Size = new Size(140, 23);
            txtBox_ServerPort.TabIndex = 14;
            // 
            // txtBox_ChatScreen
            // 
            txtBox_ChatScreen.Location = new Point(96, 283);
            txtBox_ChatScreen.Multiline = true;
            txtBox_ChatScreen.Name = "txtBox_ChatScreen";
            txtBox_ChatScreen.Size = new Size(442, 141);
            txtBox_ChatScreen.TabIndex = 15;
            // 
            // txtBox_Message
            // 
            txtBox_Message.Location = new Point(96, 206);
            txtBox_Message.Multiline = true;
            txtBox_Message.Name = "txtBox_Message";
            txtBox_Message.Size = new Size(442, 55);
            txtBox_Message.TabIndex = 16;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(623, 59);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(77, 26);
            btnStop.TabIndex = 17;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(678, 146);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(91, 23);
            btnDisconnect.TabIndex = 18;
            btnDisconnect.Text = "DISCONNECT";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisconnect);
            Controls.Add(btnStop);
            Controls.Add(txtBox_Message);
            Controls.Add(txtBox_ChatScreen);
            Controls.Add(txtBox_ServerPort);
            Controls.Add(txtBox_ClientPort);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBox_ClientIP);
            Controls.Add(txtBox_ServerIP);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private TextBox txtBox_ServerIP;
        private TextBox txtBox_ClientIP;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Button btnConnect;
        private Button btnSend;
        private TextBox txtBox_ClientPort;
        private TextBox txtBox_ServerPort;
        private TextBox txtBox_ChatScreen;
        private TextBox txtBox_Message;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button btnStop;
        private Button btnDisconnect;
    }
}
