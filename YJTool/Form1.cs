using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace YJTool
{
    public partial class Form1 : Form
    {
        //串口类
        private SerialPort comm = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            
            comboBox_Port.Items.AddRange(ports);
            comboBox_Port.SelectedIndex = comboBox_Port.Items.Count > 0 ? 0 : -1;
            
            string[] baudrates = { "9600","115200"};
            comboBox_Baudrate.Items.AddRange(baudrates);
            comboBox_Baudrate.SelectedIndex = comboBox_Baudrate.Items.IndexOf("115200");

            this.label_connectStatus.BackColor = Color.Red;
            
            comm.NewLine = "\r\n";
            //comm.RtsEnable = true;

            //注册对串口接收数据的响应方法
            comm.DataReceived += new SerialDataReceivedEventHandler(comm_DataReceived);
        }

        // 显示接收到的数据
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = comm.ReadLine();
                this.Invoke((EventHandler)(delegate
                {
                    TrimVt100(ref line);
                    textBox_RevArea.AppendText(line + "\n");
                    this.textBox_RevArea.ScrollToCaret();
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Regex imeiReg = new Regex(@"^(SerialNo.  of this device is )(?<imei>.{16})");

        Regex macReg = new Regex(@".*---hwmac:(?<mac>.{12})---.*");

        private void TrimVt100(ref string s)
        {
            // 把vt100的字符去掉
            Regex regex = new Regex(@"(.*)\u001b\[\d*;\d*m(.*)\u001b\[0m(.*)", RegexOptions.IgnoreCase);
            while (regex.IsMatch(s))
            {
                string[] arr =  regex.Split(s);
                s = string.Join(" ", arr);
            }

            // 屏幕更新固定读imei和mac地址，读到就更新绿勾
            Match imeiMatch = imeiReg.Match(s);
            if (imeiMatch.Success)
            {
                string imei = imeiMatch.Groups["imei"].Value;
                if (string.Equals(imei, textBox_imei.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    pictureBox_imei_write_success.Visible = true;
                }
            }
            Match macMatch = macReg.Match(s);
            if (macMatch.Success)
            {
                string mac = macMatch.Groups["mac"].Value;
                if (string.Equals(mac, textBox_mac.Text.Replace(":", ""), StringComparison.CurrentCultureIgnoreCase))
                {
                    pictureBox_mac_write_success.Visible = true;
                }
            }

        }
        
        // 连接串口
        private void button_ConnectSerialPort_Click(object sender, EventArgs e)
        {
            //如果串口已经是打开状态，则此按钮关闭串口
            if (this.comm.IsOpen)
            {
                this.comm.Close();
            }
            //串口关闭状态，打开之
            else
            {
                //设置好端口名和波特率
                if (this.comboBox_Port.Text == null || this.comboBox_Port.Text.Trim().Equals(""))
                {
                    MessageBox.Show("请选择一个串口");
                    return;
                }
                comm.PortName = this.comboBox_Port.Text;

                if (this.comboBox_Baudrate.Text==null || this.comboBox_Baudrate.Text.Trim().Equals(""))
                {
                    MessageBox.Show("请设置波特率");
                    return;
                }
                comm.BaudRate = int.Parse(this.comboBox_Baudrate.Text);

                try
                {
                    comm.Open();
                }
                //打开失败，抛出异常
                catch (Exception ex)
                {
                    //comm = new SerialPort();
                    MessageBox.Show(ex.Message);
                }

                comm.StopBits= StopBits.One;
                comm.Parity = Parity.None;

            }

            //按钮显示文字转变
            this.button_ConnectSerialPort.Text = comm.IsOpen ? "关闭串口" : "打开串口";
            this.label_connectStatus.BackColor = comm.IsOpen ? Color.Green:Color.Red;
            
            //发送按钮功能使能
            this.button_send.Enabled = comm.IsOpen;
            this.button_ctrl_c.Enabled = comm.IsOpen;

            // 禁用一些按钮
            this.button_refresh.Enabled = !comm.IsOpen;
            this.comboBox_Port.Enabled = !comm.IsOpen;
            this.comboBox_Baudrate.Enabled = !comm.IsOpen;
            
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            sendAction();
        }
        
        private void textBox_Send_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                sendAction();
            }
        }

        // 发送
        private void sendAction()
        {
            if (comm.IsOpen)
            {
                comm.Write( this.textBox_Send.Text + "\r\n" );
                textBox_Send.Focus();
                textBox_Send.Clear();
            }
        }

        private void button_ctrl_c_Click(object sender, EventArgs e)
        {
            sendCtrlC();
        }

        // 发送Ctrl + C
        private void sendCtrlC()
        {
            if (comm.IsOpen)
            {
                byte[] buf = new byte[1];
                buf[0] = 0x03;
                comm.Write(Encoding.ASCII.GetString(buf));
            }
        }

        // 刷新端口
        private void button_Click_Refresh(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboBox_Port.Items.Clear();
            comboBox_Port.Items.AddRange(ports);
            comboBox_Port.SelectedIndex = comboBox_Port.Items.Count > 0 ? 0 : -1;
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            if (comm.IsOpen)
            {
                string imei = this.textBox_imei.Text.Trim();
                if (imei == null || imei.Equals(""))
                {
                    MessageBox.Show("请输入序列号");
                    return;
                }
                if (!imei.EndsWith("H") || imei.Length!=16 || imei.Contains(" "))
                {
                    MessageBox.Show("请输入正确的序列号");
                    return;
                }
                string mac = this.textBox_mac.Text.Trim();
                if (mac == null || mac.Equals(""))
                {
                    MessageBox.Show("请输入MAC地址");
                    return;
                }
                Regex regex = new Regex(@"(([0-9]|[A-F]|[a-f])[02468ACEace]:)(([0-9]|[A-F]|[a-f]){2}:){4}([0-9]|[A-F]|[a-f]){2}");
                if (!regex.IsMatch(mac))
                {
                    MessageBox.Show("请输入正确的MAC地址");
                    return;
                }
                if (mac.Length != 17 || mac.Contains(" "))
                {
                    MessageBox.Show("请输入正确的MAC地址");
                    return;
                }
                pictureBox_mac_write_success.Visible = false;
                pictureBox_imei_write_success.Visible = false;
                comm.Write("/opt/bin/xfwu_imei_uevent.sh " + this.textBox_imei.Text + " " + this.textBox_mac.Text +"\r\n");
            }
            else
            {
                MessageBox.Show("串口未连接");
            }
        }

        private void textBox_imei_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_imei.TextLength == 16)
            {
                textBox_mac.Focus();
            }
            else if (this.textBox_imei.TextLength == 0)
            {
                pictureBox_imei_write_success.Visible = false;
            }
        }

        private void button_clear_rev_Click(object sender, EventArgs e)
        {
            textBox_RevArea.Clear();
        }

        private void button_clear_imei_Click(object sender, EventArgs e)
        {
            textBox_imei.Clear();
            pictureBox_imei_write_success.Visible = false;
        }

        private void button_clear_mac_Click(object sender, EventArgs e)
        {
            textBox_mac.Clear();
            pictureBox_mac_write_success.Visible = false;
        }

        private void textBox_mac_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox_mac.TextLength == 0)
            {
                pictureBox_mac_write_success.Visible = false;
            }
        }
    }
}
