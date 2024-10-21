using System.IO.Ports;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataCollection
{
    public partial class Form1 : Form
    {
        public static Queue<string> message = new Queue<string>();
        private delegate void SetLogDelegate(string value);
        bool startlog = true;
        string mySerialPort = "";
        int totalReceiveCount = 0;

        private void addLog(string msg)
        {
            try
            {
                totalReceiveCount++;
                message.Enqueue(msg);
            }
            catch (Exception ex)
            {
            }
        }


        private void Processlog()
        {
            using (StreamWriter sw = File.AppendText(Utility.getLogFile()))
            {
                while (startlog)
                {
                
                    if (message.Count > 0)
                    {
                        try
                        {
                            string m = message.Dequeue();
                            sw.WriteLine(m);
                            UpdateUI(m);
                        }
                        catch (Exception ex)
                        {
                            sw.WriteLine(ex.StackTrace);
                        }
                    }
                    else
                    {
                        Thread.Sleep(20);
                    }
                    sw.Flush();
                }
                sw.WriteLine("Processlog stop!");
            }

        }

        private void UpdateUI(string value)
        {
            if (value == null) return;

            if (this.InvokeRequired)
            {
                SetLogDelegate d = new SetLogDelegate(UpdateUI);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                if (listBox_RawData.Items.Count > 1024 * 128)
                    listBox_RawData.Items.Clear();

                listBox_RawData.Items.Add(value);
                //listBox_Log.Items.Count
                listBox_RawData.SelectedIndex = listBox_RawData.Items.Count - 1;
                Lbl_Count.Text = totalReceiveCount.ToString();
                Lbl_BufCount.Text = message.Count.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
            Task log = new Task(Processlog);
            log.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerialUtility rs232 = new SerialUtility();
            comboBox_SerialPort.DataSource = rs232.SerialPortList();

        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            mySerialPort = comboBox_SerialPort.Text;
            Task rs232 = new Task(ReadFromRs232);
            rs232.Start();
        }

        private void ReadFromRs232()
        {

            SerialUtility rs232 = new SerialUtility();

            rs232.OpenSerial(mySerialPort);
            SerialPort sp = rs232.getSerial();

            while (true)
            {
                Utility.Sleep(5);

                if (sp.ReadBufferSize < 11)
                {
                    continue;
                }

                byte[] buffer = new byte[11];
                sp.Read(buffer, 0, buffer.Length);

                addLog(Utility.ToHexStrByByte(buffer));
            }

        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            addLog("test");
        }
    }
}
