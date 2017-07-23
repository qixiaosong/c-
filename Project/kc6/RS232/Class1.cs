using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RS232
{
    public struct TIME
    {
        public uint timecounterh;
        public uint timecounterl;
    };
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct USARTDATA
    {
        public ushort datahand;
        public byte datalen;
        public byte id;
        public uint timecounterh;
        public uint timecounterl;
        public byte reserved;
        public byte check;
    };
    public class Converter
    {
        public Byte[] StructToBytes(Object structure)
        {
            Int32 size = Marshal.SizeOf(structure);
            Console.WriteLine(size);
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(structure, buffer, false);
                Byte[] bytes = new Byte[size];
                Marshal.Copy(buffer, bytes, 0, size);
                return bytes;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
        public Object BytesToStruct(Byte[] bytes, Type strcutType)
        {
            Int32 size = Marshal.SizeOf(strcutType);
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(bytes, 0, buffer, size);
                return Marshal.PtrToStructure(buffer, strcutType);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
    }
}
