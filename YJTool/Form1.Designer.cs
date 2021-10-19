using System.Windows.Forms;

namespace YJTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_RevArea = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_ConnectSerialPort = new System.Windows.Forms.Button();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.label_PortNo = new System.Windows.Forms.Label();
            this.label_Baudrate = new System.Windows.Forms.Label();
            this.comboBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.label_connectStatus = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ctrl_c = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_clear_mac = new System.Windows.Forms.Button();
            this.button_clear_imei = new System.Windows.Forms.Button();
            this.pictureBox_mac_write_success = new System.Windows.Forms.PictureBox();
            this.pictureBox_imei_write_success = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.textBox_read_imei = new System.Windows.Forms.TextBox();
            this.textBox_read_mac = new System.Windows.Forms.TextBox();
            this.textBox_imei = new System.Windows.Forms.TextBox();
            this.textBox_mac = new System.Windows.Forms.TextBox();
            this.button_write = new System.Windows.Forms.Button();
            this.button_clear_rev = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mac_write_success)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imei_write_success)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_RevArea
            // 
            this.textBox_RevArea.BackColor = System.Drawing.Color.White;
            this.textBox_RevArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_RevArea.Font = new System.Drawing.Font("新宋体", 10F);
            this.textBox_RevArea.ForeColor = System.Drawing.Color.Black;
            this.textBox_RevArea.Location = new System.Drawing.Point(12, 24);
            this.textBox_RevArea.Name = "textBox_RevArea";
            this.textBox_RevArea.ReadOnly = true;
            this.textBox_RevArea.Size = new System.Drawing.Size(776, 346);
            this.textBox_RevArea.TabIndex = 1;
            this.textBox_RevArea.Text = "";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(588, 66);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(67, 23);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_ConnectSerialPort
            // 
            this.button_ConnectSerialPort.Location = new System.Drawing.Point(479, 22);
            this.button_ConnectSerialPort.Name = "button_ConnectSerialPort";
            this.button_ConnectSerialPort.Size = new System.Drawing.Size(75, 23);
            this.button_ConnectSerialPort.TabIndex = 4;
            this.button_ConnectSerialPort.Text = "连接串口";
            this.button_ConnectSerialPort.UseVisualStyleBackColor = true;
            this.button_ConnectSerialPort.Click += new System.EventHandler(this.button_ConnectSerialPort_Click);
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.ItemHeight = 12;
            this.comboBox_Port.Location = new System.Drawing.Point(75, 22);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port.TabIndex = 5;
            // 
            // label_PortNo
            // 
            this.label_PortNo.AutoSize = true;
            this.label_PortNo.Location = new System.Drawing.Point(28, 26);
            this.label_PortNo.Name = "label_PortNo";
            this.label_PortNo.Size = new System.Drawing.Size(41, 12);
            this.label_PortNo.TabIndex = 6;
            this.label_PortNo.Text = "端口号";
            // 
            // label_Baudrate
            // 
            this.label_Baudrate.AutoSize = true;
            this.label_Baudrate.Location = new System.Drawing.Point(265, 26);
            this.label_Baudrate.Name = "label_Baudrate";
            this.label_Baudrate.Size = new System.Drawing.Size(41, 12);
            this.label_Baudrate.TabIndex = 7;
            this.label_Baudrate.Text = "波特率";
            // 
            // comboBox_Baudrate
            // 
            this.comboBox_Baudrate.FormattingEnabled = true;
            this.comboBox_Baudrate.Location = new System.Drawing.Point(312, 22);
            this.comboBox_Baudrate.Name = "comboBox_Baudrate";
            this.comboBox_Baudrate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Baudrate.TabIndex = 8;
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(30, 67);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(552, 21);
            this.textBox_Send.TabIndex = 9;
            this.textBox_Send.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Send_KeyPress);
            // 
            // label_connectStatus
            // 
            this.label_connectStatus.AutoSize = true;
            this.label_connectStatus.BackColor = System.Drawing.Color.Red;
            this.label_connectStatus.Location = new System.Drawing.Point(462, 27);
            this.label_connectStatus.Name = "label_connectStatus";
            this.label_connectStatus.Size = new System.Drawing.Size(11, 12);
            this.label_connectStatus.TabIndex = 10;
            this.label_connectStatus.Text = " ";
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_refresh.Location = new System.Drawing.Point(202, 21);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(36, 23);
            this.button_refresh.TabIndex = 11;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_Click_Refresh);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button_ctrl_c
            // 
            this.button_ctrl_c.Location = new System.Drawing.Point(661, 66);
            this.button_ctrl_c.Name = "button_ctrl_c";
            this.button_ctrl_c.Size = new System.Drawing.Size(83, 23);
            this.button_ctrl_c.TabIndex = 13;
            this.button_ctrl_c.Text = "发送Ctrl+C";
            this.button_ctrl_c.UseVisualStyleBackColor = true;
            this.button_ctrl_c.Click += new System.EventHandler(this.button_ctrl_c_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "指令";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(595, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "默认 1停止位 0奇偶校验位";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Baudrate);
            this.groupBox1.Controls.Add(this.label_connectStatus);
            this.groupBox1.Controls.Add(this.button_ConnectSerialPort);
            this.groupBox1.Controls.Add(this.button_refresh);
            this.groupBox1.Controls.Add(this.comboBox_Port);
            this.groupBox1.Controls.Add(this.button_ctrl_c);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_PortNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_Baudrate);
            this.groupBox1.Controls.Add(this.textBox_Send);
            this.groupBox1.Location = new System.Drawing.Point(12, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_clear_mac);
            this.groupBox2.Controls.Add(this.button_clear_imei);
            this.groupBox2.Controls.Add(this.pictureBox_mac_write_success);
            this.groupBox2.Controls.Add(this.pictureBox_imei_write_success);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button_check);
            this.groupBox2.Controls.Add(this.textBox_read_imei);
            this.groupBox2.Controls.Add(this.textBox_read_mac);
            this.groupBox2.Controls.Add(this.textBox_imei);
            this.groupBox2.Controls.Add(this.textBox_mac);
            this.groupBox2.Controls.Add(this.button_write);
            this.groupBox2.Location = new System.Drawing.Point(12, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // button_clear_mac
            // 
            this.button_clear_mac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clear_mac.BackgroundImage")));
            this.button_clear_mac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_clear_mac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear_mac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_mac.Location = new System.Drawing.Point(441, 59);
            this.button_clear_mac.Name = "button_clear_mac";
            this.button_clear_mac.Size = new System.Drawing.Size(17, 21);
            this.button_clear_mac.TabIndex = 33;
            this.button_clear_mac.UseVisualStyleBackColor = true;
            this.button_clear_mac.Click += new System.EventHandler(this.button_clear_mac_Click);
            // 
            // button_clear_imei
            // 
            this.button_clear_imei.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clear_imei.BackgroundImage")));
            this.button_clear_imei.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_clear_imei.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear_imei.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear_imei.Location = new System.Drawing.Point(441, 17);
            this.button_clear_imei.Name = "button_clear_imei";
            this.button_clear_imei.Size = new System.Drawing.Size(17, 21);
            this.button_clear_imei.TabIndex = 32;
            this.button_clear_imei.UseVisualStyleBackColor = false;
            this.button_clear_imei.Click += new System.EventHandler(this.button_clear_imei_Click);
            // 
            // pictureBox_mac_write_success
            // 
            this.pictureBox_mac_write_success.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_mac_write_success.BackgroundImage")));
            this.pictureBox_mac_write_success.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_mac_write_success.ErrorImage = null;
            this.pictureBox_mac_write_success.InitialImage = null;
            this.pictureBox_mac_write_success.Location = new System.Drawing.Point(461, 62);
            this.pictureBox_mac_write_success.Name = "pictureBox_mac_write_success";
            this.pictureBox_mac_write_success.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_mac_write_success.TabIndex = 31;
            this.pictureBox_mac_write_success.TabStop = false;
            this.pictureBox_mac_write_success.Visible = false;
            // 
            // pictureBox_imei_write_success
            // 
            this.pictureBox_imei_write_success.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_imei_write_success.BackgroundImage")));
            this.pictureBox_imei_write_success.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_imei_write_success.ErrorImage = null;
            this.pictureBox_imei_write_success.InitialImage = null;
            this.pictureBox_imei_write_success.Location = new System.Drawing.Point(461, 20);
            this.pictureBox_imei_write_success.Name = "pictureBox_imei_write_success";
            this.pictureBox_imei_write_success.Size = new System.Drawing.Size(16, 16);
            this.pictureBox_imei_write_success.TabIndex = 30;
            this.pictureBox_imei_write_success.TabStop = false;
            this.pictureBox_imei_write_success.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 7F);
            this.label9.Location = new System.Drawing.Point(176, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 10);
            this.label9.TabIndex = 29;
            this.label9.Text = "(如：42:2d:5a:55:6b:9f)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 7F);
            this.label8.Location = new System.Drawing.Point(178, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 10);
            this.label8.TabIndex = 28;
            this.label8.Text = "(16位，以 H 结尾的序列号)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "MAC地址";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "序列号";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "MAC地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "序列号";
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(695, 68);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 23;
            this.button_check.Text = "读取";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Visible = false;
            // 
            // textBox_read_imei
            // 
            this.textBox_read_imei.Enabled = false;
            this.textBox_read_imei.Location = new System.Drawing.Point(732, 17);
            this.textBox_read_imei.Name = "textBox_read_imei";
            this.textBox_read_imei.ReadOnly = true;
            this.textBox_read_imei.Size = new System.Drawing.Size(38, 21);
            this.textBox_read_imei.TabIndex = 21;
            this.textBox_read_imei.Visible = false;
            // 
            // textBox_read_mac
            // 
            this.textBox_read_mac.Enabled = false;
            this.textBox_read_mac.Location = new System.Drawing.Point(732, 45);
            this.textBox_read_mac.Name = "textBox_read_mac";
            this.textBox_read_mac.ReadOnly = true;
            this.textBox_read_mac.Size = new System.Drawing.Size(38, 21);
            this.textBox_read_mac.TabIndex = 22;
            this.textBox_read_mac.Visible = false;
            // 
            // textBox_imei
            // 
            this.textBox_imei.Location = new System.Drawing.Point(178, 17);
            this.textBox_imei.MaxLength = 16;
            this.textBox_imei.Name = "textBox_imei";
            this.textBox_imei.Size = new System.Drawing.Size(280, 21);
            this.textBox_imei.TabIndex = 18;
            this.textBox_imei.TextChanged += new System.EventHandler(this.textBox_imei_TextChanged);
            // 
            // textBox_mac
            // 
            this.textBox_mac.Location = new System.Drawing.Point(178, 59);
            this.textBox_mac.MaxLength = 17;
            this.textBox_mac.Name = "textBox_mac";
            this.textBox_mac.Size = new System.Drawing.Size(280, 21);
            this.textBox_mac.TabIndex = 19;
            this.textBox_mac.TextChanged += new System.EventHandler(this.textBox_mac_TextChanged);
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(504, 17);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(118, 63);
            this.button_write.TabIndex = 20;
            this.button_write.Text = "烧录";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // button_clear_rev
            // 
            this.button_clear_rev.BackColor = System.Drawing.SystemColors.Window;
            this.button_clear_rev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clear_rev.BackgroundImage")));
            this.button_clear_rev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_clear_rev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear_rev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_clear_rev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear_rev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_clear_rev.Location = new System.Drawing.Point(751, 345);
            this.button_clear_rev.Name = "button_clear_rev";
            this.button_clear_rev.Size = new System.Drawing.Size(16, 22);
            this.button_clear_rev.TabIndex = 24;
            this.button_clear_rev.UseVisualStyleBackColor = false;
            this.button_clear_rev.Click += new System.EventHandler(this.button_clear_rev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.button_clear_rev);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_RevArea);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YJTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mac_write_success)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imei_write_success)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox_RevArea;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_ConnectSerialPort;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Label label_PortNo;
        private System.Windows.Forms.Label label_Baudrate;
        private System.Windows.Forms.ComboBox comboBox_Baudrate;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Label label_connectStatus;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label1;
        private Button button_ctrl_c;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button_check;
        private TextBox textBox_read_imei;
        private TextBox textBox_read_mac;
        private TextBox textBox_imei;
        private TextBox textBox_mac;
        private Button button_write;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button_clear_rev;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox_imei_write_success;
        private PictureBox pictureBox_mac_write_success;
        private Button button_clear_mac;
        private Button button_clear_imei;
    }
}

