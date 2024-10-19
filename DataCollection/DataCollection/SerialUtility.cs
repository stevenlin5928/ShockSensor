
using System.IO.Ports;

namespace DataCollection
{
    class SerialUtility
    {

        SerialPort _serial;
        
        public string[] SerialPortList()
        {
            string[] myPorts = SerialPort.GetPortNames(); //取得所有port的名字的方法

            return myPorts;
        }

        public SerialUtility()
        {
            _serial = new SerialPort();

            _serial.BaudRate = 115200;
            _serial.Parity = Parity.None;
            _serial.StopBits = StopBits.One;
            _serial.DataBits = 8;
        }

        public void setBaudRate(int _BaudRate)
        {
            _serial.BaudRate = _BaudRate;
        }
        public SerialPort getSerial()
        {
            return _serial;
        }

        public void OpenSerial(string COM)
        {
            _serial.PortName = COM;
            _serial.Open();
        }

        public void CloseSerial()
        {
            _serial.Close();
        }
    }
}
