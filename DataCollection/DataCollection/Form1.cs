using System.IO.Ports;

namespace DataCollection
{
    public partial class Form1 : Form
    {
        public static Queue<string> message = new Queue<string>();
        private delegate void SetLogDelegate(string value);
        bool startlog = true;


        //private void Processlog()
        //{
        //    using (StreamWriter sw = File.AppendText(Utility.getLogFile()))
        //    {
        //        while (startlog)
        //        {
        //            Utility.Sleep(50);
        //            if (Utility.message.Count > 0)
        //            {
        //                try
        //                {
        //                    string m = Utility.message.Dequeue();
        //                    sw.WriteLine(m);
        //                    UpdateUI(m);
        //                }
        //                catch (Exception ex)
        //                {
        //                    sw.WriteLine(ex.StackTrace);
        //                }
        //            }
        //            sw.Flush();
        //        }
        //        sw.WriteLine("Processlog stop!");
        //    }

        //}

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
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerialUtility rs232 = new SerialUtility();
            comboBox_SerialPort.DataSource = rs232.SerialPortList();

        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            

        }

        private void ReadFromRs232()
        {

            SerialUtility rs232 = new SerialUtility();

            rs232.OpenSerial(comboBox_SerialPort.Text);
            SerialPort sp = rs232.getSerial();

            while (true)
            {
                if(sp.ReadBufferSize < 11)
                {
                    continue;
                }


            }
            
        }
    }
}
