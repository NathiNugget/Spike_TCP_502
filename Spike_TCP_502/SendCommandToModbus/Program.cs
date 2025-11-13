
using SendCommandToModbus;
using System.Net.Sockets;

TcpClient client = new TcpClient("192.168.130.100", 502);

ModbusHeader header = new ModbusHeader();
header.transactionmodifier = 0;
header.protocolidentifier = 0;
header.length = 0; 
header.unitidentifier = 0;

ModbusMessage mbm = new ModbusMessage(header); 

mbm.data = 