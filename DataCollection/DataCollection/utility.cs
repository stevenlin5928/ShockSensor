using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataCollection
{
    public class Utility
    {
        public static Queue<string> message = new Queue<string>();
        public static int logLevel = 0;


        public static void Sleep(int ms)
        {
            Thread.Sleep(ms);
        }

        //public static void Log(string msg, [CallerMemberName] string fun = "", [CallerFilePath] string filePath = "",[CallerLineNumber] int lineNumber = 0)
        //{
        //    int my_loglevel = (int)GlobolSetting.LogLevel.critical;

        //    try
        //    {
        //        string[] s = filePath.Split('\\');
        //        int index = s.Length - 1;

        //        message.Enqueue(getDatetime() + "\t" + msg + " \t-- " + lineNumber + "/" + fun + "/" + s[index]);
        //    }
        //    catch(Exception ex)
        //    {
        //        message.Enqueue(getDatetime() + "\t" + msg);
        //    }
            
        //}
        //public static void Log(LogLevel _loglevel, string msg, [CallerMemberName] string fun = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        //{
        //    int my_loglevel = (int)_loglevel;
            
        //    if (logLevel > my_loglevel)
        //        return;

        //    try
        //    {
        //        string[] s = filePath.Split('\\');
        //        int index = s.Length - 1;

        //        message.Enqueue(getDatetime() + "\t" + msg + " \t-- " + lineNumber + "/" + fun + "/" + s[index]);
        //    }
        //    catch (Exception ex)
        //    {
        //        message.Enqueue(getDatetime() + "\t" + msg);
        //    }

        //}

        public static string getDatetime()
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        public static string getDatetime2()
        {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }
        public static string getDatetime3()
        {
            return DateTime.Now.ToString("MMdd.HHmmss");
        }

        public static string getLogFile()
        {
            return "2DReader_" + DateTime.Now.ToString("yyyyMMdd") + ".log";
        }

        public static string FormatHexSpace(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i = i + 2)
            {
                sb.Append(str.Substring(i, 2));
                sb.Append(" ");
            }
            return sb.ToString();
        }
        /*******************************************************************
        * * 函数名称：ToHexString
        * * 功    能：获取字节数组的16进制
        * * 参    数：bytes 字节数组
        * * 返 回 值：
        * 
        * *******************************************************************/
        public static string ToHexStrByByte(byte[] bytes)
        {
            if (bytes != null)
            {
                char[] chars = new char[bytes.Length * 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    int b = bytes[i];
                    chars[i * 2] = hexDigits[b >> 4];
                    chars[i * 2 + 1] = hexDigits[b & 0xF];
                }
                return new string(chars);
            }
            else
                return null;
        }
        public static string ToHexStrByByte2(byte[] bytes, int length)
        {
            if (bytes != null)
            {
                char[] chars = new char[length * 2];
                for (int i = 0; i < length; i++)
                {
                    int b = bytes[i];
                    chars[i * 2] = hexDigits[b >> 4];
                    chars[i * 2 + 1] = hexDigits[b & 0xF];
                }
                return new string(chars);
            }
            else
                return null;
        }

        static char[] hexDigits = {
        '0', '1', '2', '3', '4', '5', '6', '7',
        '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        /*******************************************************************
       * * 函数名称：ToHexByte
       * * 功    能：获取16进制字符串的字节数组
       * * 参    数：hexString 16进制字符串
       * * 返 回 值：
       * 
       * *******************************************************************/
        public static byte[] ToByteByHexStr(string hexString)
        {
            if (hexString == null)
                return null;

            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        /// <summary>
        /// 将16进制的Byte数组转换为UShort数组
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static ushort[] ToUShortFromByte(byte[] source)
        {
            int length = source.Length;

            ushort[] output = new ushort[length / 2];
            for (int i = 0; i < output.Length; ++i)
            {
                output[i] = (ushort)(source[i * 2 + 1] | source[i * 2] << 8);
            }
            return output;
        }

        public static string BytesToAscii(byte[] b)
        {
            string s = ToHexStrByByte(b);
            return HexStr2ASCII(s);
        }

        //輸入2 Bytes Hex型式的字串，回傳ASCII字串
        public static string HexStr2ASCII(string hex_str)
        {
            string result = "";
            string tmp;

            for (int i = 0; i < hex_str.Length; i += 2)
            {
                tmp = hex_str.Substring(i, 2);
                result += Convert.ToChar(Convert.ToUInt32(tmp, 16));
            }
            return result;
        }

        //輸入ASCII字串 回傳2 Bytes Hex型式的字串
        public static string ASCII2HexStr(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += Convert.ToInt32(str[i]).ToString("X");
            }
            return result;
        }

    }
}
