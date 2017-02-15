using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;

class PS3
{
    static PS3API BIS = new PS3API();

    /// <summary>
    /// Mine 24/11/2014 - 
    /// </summary>
    public class Connections
    {
        public enum API
        {
            DEX = 0,
            CEX = 1
        }
        public static bool Reconnect()
        {
            bool connect = false;
            if (BIS.GetCurrentAPI() == SelectAPI.TargetManager)
                connect = Connect();
            return connect;
        }
        public static bool ConnectAPI(API Api = 0)
        {
            if ((int)Api == 1)
            {
                BIS.ChangeAPI(SelectAPI.ControlConsole);
                return BIS.ConnectTarget();
            }
            return BIS.ConnectTarget();
        }
        public static bool Connect()
        {
            return BIS.ConnectTarget();
        }
        public static bool Attach()
        {
            return BIS.AttachProcess();
        }
        public static void CCAPI()
        {
            BIS.ChangeAPI(SelectAPI.ControlConsole);
        }
        public static void TMAPI()
        {
            BIS.ChangeAPI(SelectAPI.TargetManager);
        }
    }
    public class Command
    {
        public static void SetConsoleID(string NewCID)
        {
            BIS.CCAPI.SetConsoleID(NewCID);
        }
        public static void SetBootConsoleID(string NewCID)
        {
            BIS.CCAPI.SetBootConsoleID(NewCID);
        }
        public static void SetPSID(string NewPSID)
        {
            BIS.CCAPI.SetPSID(NewPSID);
        }
        public static void ShutDown()
        {
            BIS.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.ShutDown);
            BIS.TMAPI.PowerOff(true);
        }
        public static void HardReboot()
        {
            BIS.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.HardReboot);
            BIS.TMAPI.ResetToXMB(PS3Lib.TMAPI.ResetTarget.Hard);
        }
        public static void SoftReboot()
        {
            BIS.CCAPI.ShutDown(PS3Lib.CCAPI.RebootFlags.SoftReboot);
            BIS.TMAPI.ResetToXMB(PS3Lib.TMAPI.ResetTarget.Soft);
        }
        public static void CELL()
        {
            BIS.CCAPI.GetTemperatureCELL();
        }
        public static void RSX()
        {
            BIS.CCAPI.GetTemperatureRSX();
        }
        public static void Version()
        {
            BIS.CCAPI.GetFirmwareVersion();
        }
    }

    public static void SetMemory(uint Offset, byte[] Byte)
    {
        BIS.SetMemory(Offset, Byte);
    }
    public static void GetMemory(uint Offset, byte[] Length)
    {
        BIS.GetMemory(Offset, Length);
    }
    public static byte[] GetMemory(uint Offset, int Length)
    {
        byte[] Buffer = new byte[Length];
        BIS.GetMemory(Offset, Buffer);
        return Buffer;
    }
    public static void GetMemory(uint Offset, ref byte[] Length)
    {
        BIS.GetMemory(Offset, Length);
    }
    public static byte[] GetBytes(uint offset, int length)
    {
        byte[] bytes = new byte[length];
        bytes = BIS.GetBytes(offset, length);
        return bytes;
    }
    public static byte[] ReverseArray(float float_0)
    {
        byte[] bytes = BitConverter.GetBytes(float_0);
        Array.Reverse(bytes);
        return bytes;
    }

    public static byte[] ReverseBytes(byte[] inArray)
    {
        Array.Reverse(inArray);
        return inArray;
    }
    public static byte[] ToHexFloat(float Axis)
    {
        byte[] bytes = BitConverter.GetBytes(Axis);
        Array.Reverse(bytes);
        return bytes;
    }
    public static byte[] uintBytes(uint input)
    {
        byte[] bytes = BitConverter.GetBytes(input);
        Array.Reverse(bytes);
        return bytes;
    }
    public class Extension
    {
        public static string ReadString(uint offset)
        {
            int length = 40;
            int num2 = 0;
            string source = "";
            do
            {
                byte[] bytes = GetMemory(offset + ((uint)num2), length);
                source = source + Encoding.UTF8.GetString(bytes);
                num2 += length;
            }
            while (!source.Contains<char>('\0'));
            int index = source.IndexOf('\0');
            string str2 = source.Substring(0, index);
            source = string.Empty;
            return str2;
        }
        public static bool ReadBool(uint offset)
        {
            byte[] buffer = new byte[1];
            GetMemory(offset, buffer);
            return (buffer[0] != 0);
        }
        public static byte ReadByte(uint offset)
        {
            return GetBytes(offset, 1)[0];
        }
        public static byte[] ReadBytes(uint offset, int length)
        {
            return GetBytes(offset, length);
        }
        public static float ReadFloat(uint offset)
        {
            byte[] array = GetBytes(offset, 4);
            Array.Reverse(array, 0, 4);
            return BitConverter.ToSingle(array, 0);
        }
        public static float[] ReadFloat(uint address, int length)
        {
            byte[] memory = GetMemory(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length - 1 + 1];
            for (int i = 0; i <= length - 1; i++)
            {
                numArray[i] = System.Convert.ToSingle(BitConverter.ToSingle(memory, ((length - 1) - i) * 4));
            }
            return numArray;
        }
        public static short ReadInt16(uint offset)
        {
            byte[] array = GetBytes(offset, 2);
            Array.Reverse(array, 0, 2);
            return BitConverter.ToInt16(array, 0);
        }
        public static int ReadInt32(uint offset)
        {
            byte[] array = GetBytes(offset, 4);
            Array.Reverse(array, 0, 4);
            return BitConverter.ToInt32(array, 0);
        }
        public static long ReadInt64(uint offset)
        {
            byte[] array = GetBytes(offset, 8);
            Array.Reverse(array, 0, 8);
            return BitConverter.ToInt64(array, 0);
        }
        static byte[] Bytes = new byte[30];
        public static int Read2Bytes(uint Offset, bool Reverse)
        {
            Bytes = PS3.GetBytes(Offset, 2);
            if (Reverse)
            {
                Array.Reverse(Bytes);
            }
            return BitConverter.ToInt16(Bytes, 0);
        }
        public static int Read4Bytes(uint Offset, bool Reverse)
        {
            Bytes = PS3.GetBytes(Offset, 4);
            if (Reverse)
            {
                Array.Reverse(Bytes);
            }
            return BitConverter.ToInt32(Bytes, 0);
        }
        public static Int64 Read8Bytes(uint Offset, bool Reverse)
        {
            Bytes = PS3.GetBytes(Offset, 8);
            if (Reverse)
            {
                Array.Reverse(Bytes);
            }
            return BitConverter.ToInt64(Bytes, 0);
        }
        public static sbyte ReadSByte(uint offset)
        {
            byte[] buffer = new byte[1];
            GetMemory(offset, buffer);
            return (sbyte)buffer[0];
        }
        public static ushort ReadUInt16(uint offset, bool Reverse)
        {
            byte[] array = GetBytes(offset, 2);
            if (Reverse)
            {
                Array.Reverse(array, 0, 2);
            }
            
            return BitConverter.ToUInt16(array, 0);
        }
        public static uint ReadUInt32(uint offset, bool Reverse)
        {
            byte[] array = GetBytes(offset, 4);
            if (Reverse)
            {
                Array.Reverse(array, 0, 4);
            }
            return BitConverter.ToUInt32(array, 0);
        }
        public static ulong ReadUInt64(uint offset, bool Reverse)
        {
            byte[] array = GetBytes(offset, 8);
            if (Reverse)
            {
                Array.Reverse(array, 0, 8);
            }
            return BitConverter.ToUInt64(array, 0);
        }

        public static float ReadSingle(uint address)
        {
            byte[] memory = GetMemory(address, 4);
            Array.Reverse(memory, 0, 4);
            return BitConverter.ToSingle(memory, 0);
        }
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = GetMemory(address, length * 4);
            ReverseBytes(memory);
            float[] numArray = new float[length - 1 + 1];
            for (int i = 0; i <= length - 1; i++)
            {
                numArray[i] = System.Convert.ToSingle(BitConverter.ToSingle(memory, ((length - 1) - i) * 4));
            }
            return numArray;
        }

        public static void WriteString(uint offset, string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            SetMemory(offset, bytes);
        }
        public static void WriteBool(uint offset, bool input)
        {
            byte[] buffer = new byte[] { input ? ((byte)1) : ((byte)0) };
            SetMemory(offset, buffer);
        }
        public static void WriteByte(uint offset, byte input)
        {
            byte[] buffer = new byte[] { input };
            SetMemory(offset, buffer);
        }
        public static void WriteFloat(uint offset, float input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            SetMemory(offset, array);
        }
        public static void WriteFloat(uint address, float[] input)
        {
            int length = input.Length;
            byte[] array = new byte[length * 4];
            for (int i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (int)(i * 4));
            }
            SetMemory(address, array);
        }
        public static void WriteInt16(uint offset, short input)
        {
            byte[] array = new byte[2];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 2);
            SetMemory(offset, array);
        }
        public static void WriteInt32(uint offset, int input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            SetMemory(offset, array);
        }
        public static void WriteInt64(uint offset, long input)
        {
            byte[] array = new byte[8];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 8);
            SetMemory(offset, array);
        }

        public static void WriteSByte(uint offset, sbyte input)
        {
            byte[] buffer = new byte[] { (byte)input };
            SetMemory(offset, buffer);
        }
        public static void WriteSingle(uint address, float input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            SetMemory(address, array);
        }

        public static void WriteSingle(uint address, float[] input)
        {
            int length = input.Length;
            byte[] array = new byte[length * 4];
            for (int i = 0; i < length; i++)
            {
                ReverseBytes(BitConverter.GetBytes(input[i])).CopyTo(array, (int)(i * 4));
            }
            SetMemory(address, array);
        }
        public static void WriteBytes(uint offset, byte[] input)
        {
            byte[] buffer = input;
            SetMemory(offset, buffer);
        }
        public static void WriteUInt16(uint offset, ushort input)
        {
            byte[] array = new byte[2];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 2);
            SetMemory(offset, array);
        }

        public static void WriteUInt32(uint offset, uint input)
        {
            byte[] array = new byte[4];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 4);
            SetMemory(offset, array);
        }

        public static void WriteUInt64(uint offset, ulong input)
        {
            byte[] array = new byte[8];
            BitConverter.GetBytes(input).CopyTo(array, 0);
            Array.Reverse(array, 0, 8);
            SetMemory(offset, array);
        }
        public void Write2Bytes(uint Offset, short Input)
        {
            PS3.Extension.WriteBytes(Offset, (BitConverter.GetBytes(Convert.ToInt16(Input))));
        }
        public void Write4Bytes(uint Offset, short Input)
        {
            PS3.Extension.WriteBytes(Offset, (BitConverter.GetBytes(Convert.ToInt32(Input))));
        }
    }
    
}
