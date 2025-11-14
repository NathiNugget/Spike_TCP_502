
using ModbusTest;
using SendCommandToModbus;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Runtime.InteropServices;


TcpClient client = new TcpClient("192.168.123.100", 502);

//ModbusHeader header = new ModbusHeader();
//header.transactionmodifier = 0;
//header.protocolidentifier = 0;
//header.length = 0; 
//header.unitidentifier = 0;

//ModbusMessage mbm = new ModbusMessage(header); 

//mbm.data = 











ModBusMessageSafe msg = new();

UInt16 j = 0;
UInt16 l = 0;
msg.data.functionCode = 0x5A;
msg.header.length = 4;
msg.header.unitID = 0x1;
msg.header.transactionIdentifier = 1;
msg.AddData(4);
//msg.AddData(0x100);
//msg.AddData(0x100);





byte[] buffer = msg.Serialize();

try
{
    var stream = client.GetStream();

    stream.Write(buffer, 0, buffer.Length);

    byte[] returnbytes = new byte[1024];
    int readbytes = 0;
    while (readbytes == 0)
    {
        readbytes = stream.Read(returnbytes, 0, 1);

    }

    Console.WriteLine();
}

catch
{

}



client.Close();
