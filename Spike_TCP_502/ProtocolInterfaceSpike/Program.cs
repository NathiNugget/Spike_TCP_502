using ModbusTest;
using System.Runtime.InteropServices;


ModBusMessage msg = new();

testData data = new testData();
data.t3 = 1356;
data.t2 = 5.5457f;
data.t1 = 20405069;

msg.AddData(data);


var buffer = msg.Serialize();






ModBusMessageSafe msg2 = new();

UInt16 j = 24541;
UInt16 l = 34345;

msg2.AddData(j);
msg2.AddData(l);


byte[] buffer2 = msg2.Serialize();

ModBusMessageSafe msg3 = new();

byte[] headerData = new byte[Marshal.SizeOf<ModBusHeaderSafe>()];
Array.Copy(buffer2, 0,headerData,0, headerData.Length);


byte[] payloadData = new byte[msg2.DataSize];
Array.Copy(buffer2, Marshal.SizeOf<ModBusHeaderSafe>(), payloadData, 0, payloadData.Length);

msg3.DeserializeHeader(headerData);
msg3.DeserializeData(payloadData);

int i = 5;

