using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Diagnostics;



namespace BoF2Editor
{
    public enum ByteOrder : int
    {
        HighByteFirst = 0,
        LowByteFirst = 1
    }

    class Rom
    {


        public static string endOfNameByte = "F7";
        public static int maxMonsters = 200;
        public static int maxMonsterSpells = 8;
        private RomDataParser parser;

        public string[] monsterName = new string[maxMonsters];
        public string[] monsterNameOffset = new string[maxMonsters];
        public string[] monsterUnknown1 = new string[maxMonsters];
        public int[] monsterMaxHP = new int[maxMonsters];
        public int[] monsterMaxMP = new int[maxMonsters];
        public int[] monsterAtk = new int[maxMonsters];
        public int[] monsterDef = new int[maxMonsters];
        public int[] monsterAgi = new int[maxMonsters];
        public int[] monsterLuk = new int[maxMonsters];
        public int[] monsterExp = new int[maxMonsters];
        public int[] monsterZenny = new int[maxMonsters];
        public int[] monsterDropRate = new int[maxMonsters];
        public int[] monsterItemSet = new int[maxMonsters];

        private Dictionary<string, string> characterMap = new Dictionary<string, string>();
        private byte[] Data;
        private bool _header;

        public bool Header
        {
            get
            {
                return _header;
            }
        }

        public Rom(string path)
        {


            this.Data = File.ReadAllBytes(path);

            parser = new RomDataParser(this.Data);

            int remainder = this.Data.Length & 0x7FFF;
            this._header = remainder == 0x200;
            loadMonsterData();
        }


        /*****************************************************
         * 
         * SubData
         * 
        *****************************************************/

        public byte[] SubData(string offset, int length)
        {

            int index = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
            //index -= 1024;
            //index += 512;

            byte[] result = new byte[length];
            Array.Copy(Data, index, result, 0, length);
            return result;
        }


        /*****************************************************
         * 
         * readDataInt
         * 
        *****************************************************/

        public int readDataInt(string offset, int length, bool lEndian)
        {
            byte[] buffer = new byte[length];

            buffer = SubData(offset, length);
            System.Text.StringBuilder hexString = new System.Text.StringBuilder(length * 2);

            for (int index = 0; index < length; index++)
            {
                byte byteValue = buffer[index];
                string hexValue = byteValue.ToString("X");
                if (hexValue.Length < 2) { hexValue = "0" + hexValue; }
                if (!lEndian)
                {
                    hexString.Append(hexValue);
                }
                else
                {
                    hexString.Insert(0, hexValue);
                }
            }
            return (int.Parse(hexString.ToString(), System.Globalization.NumberStyles.HexNumber));
        }


        /*****************************************************
         * 
         * readDataByte
         * 
        *****************************************************/
        public string readDataByte(string offset, int length, bool lEndian)
        {
            byte[] buffer = new byte[length];

            buffer = SubData(offset, length);
            System.Text.StringBuilder hexString = new System.Text.StringBuilder(length * 2);

            for (int index = 0; index < length; index++)
            {
                byte byteValue = buffer[index];
                string hexValue = byteValue.ToString("X");
                if (hexValue.Length < 2) { hexValue = "0" + hexValue; }
                if (!lEndian)
                {
                    hexString.Append(hexValue);
                }
                else
                {
                    hexString.Insert(0, hexValue);
                }
            }
            return (hexString.ToString());
        }


        /*****************************************************
         * 
         * writeDataByte
         * 
        *****************************************************/
        public void writeDataByte(string value, string offset, int length, bool lEndian)
        {
            length *= 2;

            String hexString = value;

            int index = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
            //index -= 1024;
            //index += 512;

            if (!lEndian)
            {
                for (int i = 0; i < length; i += 2)
                {
                    String substring = hexString.Substring(i, 2);
                    byte b = Convert.ToByte(substring, 16);
                    Data[index + (i / 2)] = b;
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder("0000");
                for (int i = 0; i < length; i += 2)
                {
                    String substring = hexString.Substring(i, 2);
                    byte b = Convert.ToByte(substring, 16);
                    Data[index + ((length - i - 2) / 2)] = b;
                    sb[((length - i - 2) / 2)] = substring[0];
                    sb[((length - i - 2) / 2) + 1] = substring[1];

                }
            }
        }


        /*****************************************************
         * 
         * writeDataInt
         * 
        *****************************************************/
        public void writeDataInt(int value, string offset, int length, bool lEndian)
        {
            length *= 2;

            String hexString = value.ToString("X" + (length).ToString());

            int index = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
            //index -= 1024;
            //index += 512;

            if (!lEndian)
            {
                for (int i = 0; i < length; i += 2)
                {
                    String substring = hexString.Substring(i, 2);
                    byte b = Convert.ToByte(substring, 16);
                    Data[index + (i / 2)] = b;
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder("0000");
                for (int i = 0; i < length; i += 2)
                {
                    String substring = hexString.Substring(i, 2);
                    byte b = Convert.ToByte(substring, 16);
                    Data[index + ((length - i - 2) / 2)] = b;
                    sb[((length - i - 2) / 2)] = substring[0];
                    sb[((length - i - 2) / 2) + 1] = substring[1];

                }
            }
        }



        /*****************************************************
         * 
         * SaveData
         * 
        *****************************************************/

        public void SaveData(string ROMname)
        {
            saveMonsterData();
            File.WriteAllBytes(ROMname, Data);
        }



        /*****************************************************
         * 
         * hexAdd
         * 
        *****************************************************/
        public string hexAdd(string value1, string value2)
        {

            string r;
            int v1 = int.Parse(value1, System.Globalization.NumberStyles.HexNumber);
            int v2 = int.Parse(value2, System.Globalization.NumberStyles.HexNumber);
            r = (v1 + v2).ToString("X");
            return r;
        }



        /*****************************************************
         * 
         * hexSub
         * 
        *****************************************************/

        public string hexSub(string value1, string value2)
        {
            string r;
            int v1 = int.Parse(value1, System.Globalization.NumberStyles.HexNumber);
            int v2 = int.Parse(value2, System.Globalization.NumberStyles.HexNumber);
            r = (v1 - v2).ToString("X");
            return r;
        }



        /*****************************************************
         * 
         * hexMult
         * 
        *****************************************************/

        public string hexMult(string value, int num)
        {
            string r;
            int i, total = 0;
            for (i = 0; i < num; i++)
            {
                total += int.Parse(value, System.Globalization.NumberStyles.HexNumber);
            }
            r = total.ToString("X");
            return r;
        }



        /*****************************************************
         * 
         * readDataHex
         * 
        *****************************************************/

        public string readDataHex(string offset)
        {
            byte[] buffer = new byte[1];

            buffer = SubData(offset, 1);

            byte byteValue = buffer[0];
            return (byteValue.ToString("X2"));
        }



        /*****************************************************
         * 
         * readDataString
         * 
        *****************************************************/

        public string readDataString(string offset, int length)
        {
            return parser.readDataString(offset, length);
        }



        /*****************************************************
         * 
         * writeDataString
         * 
        *****************************************************/


        public void writeDataString(string value, string offset, int length)
        {
            //length *= 2;
            //System.Diagnostics.Debug.WriteLine("value: " + value + "  offset: " + offset + "  length: " + length.ToString());

            int index = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
            //index -= 1024;
            //index += 512;

            char[] chars = value.ToCharArray();
            int length2 = chars.Length;
            //byte[] bytes = new byte[length];
            int i = 0;
            for (; i < length2; i++)
            {
                Data[index + i] = (byte)chars[i];
            }
            char space = ' ';
            for (; i < length; i++)
            {
                Data[index + i] = (byte)space;
            }
        }


        /*****************************************************
         * 
         * loadMonsterData
         * 
        *****************************************************/

        private void loadMonsterData()
        {
            string startOffset = "059000";
            string offset;
            int dataSize;
            int ___DUMMYVAR__;
            for (var i = 0; i < maxMonsters; i += 1)
            {

                offset = hexAdd(startOffset, this.hexMult("20", i));    // 20 is 32 in hex

                dataSize = 8;
                monsterName[i] = readDataString(offset, dataSize);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 2;
                monsterMaxHP[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 2;
                monsterMaxMP[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 1;
                monsterLuk[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                
                dataSize = 2;
                monsterAtk[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                monsterDef[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                monsterAgi[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 1;
                // drop rate?
                monsterDropRate[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 2;
                monsterExp[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                monsterZenny[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());


                // itemset
                dataSize = 1;
                monsterItemSet[i] = readDataInt(offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                // unknown bytes
                dataSize = 7;
                offset = hexAdd(offset, dataSize.ToString());

                



            }
        }


        /*****************************************************
         * 
         * saveMonsterData
         * 
        *****************************************************/

        private void saveMonsterData()
        {
            string startOffset = "059000";
            string offset;
            int dataSize;
            for (var i = 0; i < maxMonsters; i += 1)
            {
                /*
                offset = hexAdd(startOffset, this.hexMult("2A", i));    // 2A is 42 in hex

                dataSize = 1;
                writeDataByte(monsterUnknown1[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                dataSize = 2;
                writeDataInt(monsterMaxHP[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterMaxMP[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterPower[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterGuard[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                dataSize = 1;
                writeDataInt(monsterMagic[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterSpeed[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                */


                offset = hexAdd(startOffset, this.hexMult("20", i));    // 20 is 32 in hex

                dataSize = 8;
                // not saving monster names
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 2;
                writeDataInt(monsterMaxHP[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterMaxMP[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 1;
                writeDataInt(monsterLuk[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 2;
                writeDataInt(monsterAtk[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterDef[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterAgi[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 1;
                writeDataInt(monsterDropRate[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 2;
                writeDataInt(monsterExp[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());
                writeDataInt(monsterZenny[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());


                dataSize = 1;
                // not saving item set data
                writeDataInt(monsterItemSet[i], offset, dataSize, true);
                offset = hexAdd(offset, dataSize.ToString());

                dataSize = 7;
                // not saving unknown bytes
                offset = hexAdd(offset, dataSize.ToString());


            }
        }


        public string getByteStr(int monsterIndex)
        {
            string startOffset = "059000";
            int dataSize = 8;
            string offset, bytes;

            offset = hexAdd(startOffset, this.hexMult("20", monsterIndex));    // 20 is 32 in hex
            offset = hexAdd(offset, dataSize.ToString());
            bytes = readDataByte(offset, 24, false);

            return bytes;
        }

        public void doubleExp()
        {
            for (var i = 0; i < maxMonsters; i += 1)
            {
                monsterExp[i] = monsterExp[i] * 2;
                if (monsterExp[i] > 65535)
                {
                    monsterExp[i] = 65535;
                }
                if (monsterExp[i] < 0)
                {
                    monsterExp[i] = 0;
                }
            }
        }

        public void doubleZenny()
        {
            for (var i = 0; i < maxMonsters; i += 1)
            {
                monsterZenny[i] = monsterZenny[i] * 2;
                if (monsterZenny[i] > 65535)
                {
                    monsterZenny[i] = 65535;
                }
                if (monsterZenny[i] < 0)
                {
                    monsterZenny[i] = 0;
                }
            }
        }

        

        

        /*****************************************************
         * 
         * getRealOffset
         * 
        *****************************************************/

        private string getRealOffset(string offset)
        {
            int v1 = int.Parse(offset, System.Globalization.NumberStyles.HexNumber);
            v1 = v1 & 0x0FFFFF;
            offset = v1.ToString("X");

            return offset;

        }



        /*****************************************************
         * 
         * littleEndian
         * 
        *****************************************************/
        static string littleEndian(string num)
        {
            string newnum = "";
            if (num.Length % 2 == 1) 
            {
                num = "0" + num;
            }
            for (var i = 0; i < num.Length; i += 2)
            {
                newnum = num.Substring(i, 2) + newnum;
            }
            return newnum;
        }



        /*****************************************************
         * 
         * hex2bin
         * 
        *****************************************************/

        static string hex2bin(string hexstring)
        {
            string res = "";
            res = Convert.ToString(Convert.ToInt32(hexstring, 16), 2);
            int dif = 8 - res.Length;

            for (var i = 0; i < dif; i++)
            {
                res = "0" + res;
            }
            return res;
        }

        static string hex2bin(string hexstring, int bytes)
        {
            string res = "";
            res = Convert.ToString(Convert.ToInt32(hexstring, 16), 2);
            int dif = (8 * bytes) - res.Length;

            for (var i = 0; i < dif; i++)
            {
                res = "0" + res;
            }
            return res;
        }



        /*****************************************************
         * 
         * bin2hex
         * 
        *****************************************************/

        static string bin2hex(string binstring)
        {
            string res = Convert.ToInt32(binstring, 2).ToString("X");

            if (res.Length % 2 == 1)
            {
                res = "0" + res;
            }
            return res;
        }
    }
}
