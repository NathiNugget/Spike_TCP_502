using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 7, CharSet = CharSet.Ansi)]
struct ModbusHeader {
    [FieldOffset(0)] UInt16 transactionmodifier;
    [FieldOffset(2)] UInt16 protocolidentifier;
    [FieldOffset(4)] UInt16 length;
    [FieldOffset(6)] byte unitidentifier; 
}

class ModbusMessage
{
    ModbusHeader header;
    List<byte> data; 



}
