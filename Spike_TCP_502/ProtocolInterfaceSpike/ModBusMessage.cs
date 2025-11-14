using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ModbusTest
{
    public class ModBusMessage : IProtocolMessage
    {
        ModBusHeader header = new();
        ModBusData data = new();


        public unsafe void AddData<T>(T inputData) where T : unmanaged
        {
            var newSize = data.payload.Length + Marshal.SizeOf<T>();
            var oldSize = data.payload.Length;
            Array.Resize(ref data.payload, newSize);
            fixed(byte* payloadData = data.payload)
            {
                Buffer.MemoryCopy(&inputData, payloadData + oldSize, newSize - oldSize, Marshal.SizeOf<T>());
            }
        }

        public unsafe byte[] Serialize()
        {
            var headerSize = Marshal.SizeOf<ModBusHeader>();
            var dataSize = 1 + data.payload.Length;
            byte[] buffer = new byte[headerSize + dataSize];
            fixed(byte* bufferPtr = buffer)
            fixed(ModBusHeader* headerPtr = &header)
            fixed (byte* payloadData = data.payload)
            {
                // copy header
                Buffer.MemoryCopy(headerPtr, bufferPtr, buffer.Length, Marshal.SizeOf<ModBusHeader>());

                var currentIndex = headerSize;

                bufferPtr[headerSize] = data.functionCode;

                currentIndex++;



                Buffer.MemoryCopy(payloadData, bufferPtr + currentIndex, buffer.Length - currentIndex, data.payload.Length);

            }
            return buffer;
        }
    }


    public struct testData
    {
        public int t1;
        public float t2;
        public UInt16 t3;
    }

}


