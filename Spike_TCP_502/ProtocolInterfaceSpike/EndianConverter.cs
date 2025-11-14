using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolInterfaceSpike
{
    static public class EndianConverter
    {
        static uint FromHostToNetwork(uint val)
        {
            if(BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        }
        static int FromHostToNetwork(int val)
        {
            if (BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        }
        static ushort FromHostToNetwork(ushort val)
        {
            if (BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        }
        static short FromHostToNetwork(short val)
        {
            if (BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        
        }



        static uint FromNetworkToHost(uint val)
        {
            if (BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        }
        static int FromNetworkToHost(int val)
        {
            if (BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        }
        static ushort FromNetworkToHost(ushort val)
        {
            if (BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        }
        static short FromNetworkToHost(short val)
        {
            if (BitConverter.IsLittleEndian)
            {
                BinaryPrimitives.ReverseEndianness(val);
            }
            return val;
        }












    }
}
