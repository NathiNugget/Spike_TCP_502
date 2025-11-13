using System;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace SendCommandToModbus
{


    [StructLayout(LayoutKind.Explicit, Size = 7, CharSet = CharSet.Ansi)]
    public struct ModbusHeader
    {
        [FieldOffset(0)] public UInt16 transactionmodifier;
        [FieldOffset(2)] public UInt16 protocolidentifier;
        [FieldOffset(4)] public UInt16 length;
        [FieldOffset(6)] public byte unitidentifier;

        public ModbusHeader(UInt16 transmf, UInt16 protomf, UInt16 length, byte unitidentifier)
        {
            transactionmodifier = transmf;
            protocolidentifier = protomf;
            this.length = length;
            this.unitidentifier = unitidentifier;
        }
    }

    public class ModbusMessage
    {
        ModbusHeader header;
        public List<byte> data = new List<byte>();

        public ModbusMessage(ModbusHeader header)
        {
            this.header = header;
        }

        public static byte[] Serialize(ModbusMessage message)
        {
            byte[] bytes = new byte[Marshal.SizeOf(typeof(ModbusHeader)) + message.data.Count + 1];
            unsafe
            {
                ModbusMessage* ptr = &message;
                long bytesize = ptr->data.Count;
                Buffer.MemoryCopy(ptr, &bytes, bytes.Length, bytesize);

            }

            return bytes;




        }


    }




}