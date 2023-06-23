namespace ChatApplicaton2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectedLV = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendTxt = new System.Windows.Forms.Button();
            this.sendTb = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnectBtn);
            this.groupBox1.Controls.Add(this.acceptBtn);
            this.groupBox1.Controls.Add(this.connectBtn);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONNECTION";
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(201, 115);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(90, 30);
            this.disconnectBtn.TabIndex = 10;
            this.disconnectBtn.Text = "DISCONNECT";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(105, 116);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(90, 30);
            this.acceptBtn.TabIndex = 9;
            this.acceptBtn.Text = "ACCEPT";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(9, 116);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(90, 30);
            this.connectBtn.TabIndex = 8;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(9, 85);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(161, 23);
            this.tbPort.TabIndex = 7;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(9, 40);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(332, 23);
            this.tbIP.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Insert Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Insert IP Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.connectedLV);
            this.groupBox2.Location = new System.Drawing.Point(367, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accepted IP";
            // 
            // connectedLV
            // 
            this.connectedLV.FormattingEnabled = true;
            this.connectedLV.ItemHeight = 15;
            this.connectedLV.Location = new System.Drawing.Point(6, 52);
            this.connectedLV.MultiColumn = true;
            this.connectedLV.Name = "connectedLV";
            this.connectedLV.ScrollAlwaysVisible = true;
            this.connectedLV.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.connectedLV.Size = new System.Drawing.Size(408, 214);
            this.connectedLV.TabIndex = 1;
            this.connectedLV.SelectedIndexChanged += new System.EventHandler(this.connectedLV_SelectedIndexChanged);
            this.connectedLV.SelectedValueChanged += new System.EventHandler(this.connectedLV_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendTxt);
            this.groupBox3.Controls.Add(this.sendTb);
            this.groupBox3.Controls.Add(this.message);
            this.groupBox3.Location = new System.Drawing.Point(12, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 361);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MESSAGES";
            // 
            // sendTxt
            // 
            this.sendTxt.Location = new System.Drawing.Point(640, 22);
            this.sendTxt.Name = "sendTxt";
            this.sendTxt.Size = new System.Drawing.Size(129, 66);
            this.sendTxt.TabIndex = 11;
            this.sendTxt.Text = "SEND";
            this.sendTxt.UseVisualStyleBackColor = true;
            this.sendTxt.Click += new System.EventHandler(this.sendTxt_Click);
            // 
            // sendTb
            // 
            this.sendTb.Location = new System.Drawing.Point(9, 22);
            this.sendTb.Multiline = true;
            this.sendTb.Name = "sendTb";
            this.sendTb.Size = new System.Drawing.Size(625, 66);
            this.sendTb.TabIndex = 1;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(9, 94);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(760, 261);
            this.message.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 72);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 670);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox connectedLV;
        private GroupBox groupBox3;
        private Button disconnectBtn;
        private Button acceptBtn;
        private Button connectBtn;
        private TextBox tbPort;
        private TextBox tbIP;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox message;
        private Label label2;
        private Label label3;
        private Button sendTxt;
        private TextBox sendTb;
    }
}