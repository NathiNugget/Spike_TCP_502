using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ModbusTest
{
    [StructLayout(LayoutKind.Explicit, Size = 7, CharSet = CharSet.Ansi)]
    public struct ModBusHeader
    {
        [FieldOffset(0)] public UInt16 transactionIdentifier;
        [FieldOffset(2)] public UInt16 protocolIdentifier;
        [FieldOffset(4)] public UInt16 length;
        [FieldOffset(6)] public byte unitID;

    }
}
