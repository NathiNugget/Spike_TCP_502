
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






int identifier = 0;

ushort address = 0; 


while (address < 64)
{
    ModBusMessageSafe msg = new();
    msg.data.functionCode = 0x2B;
    msg.header.length = 5;
    msg.header.unitID = 0xFF;
    msg.header.transactionIdentifier = (ushort)identifier;
    msg.AddData((byte)0xE);
    msg.AddData((byte)0x3);
    msg.AddData((byte)0x0); 



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

        Console.WriteLine(returnbytes);
    }

    catch
    {

    }
    address += 64;
    identifier++;
    Thread.Sleep(100);
}








client.Close();
