using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusTest
{
    public interface IProtocolHeaderSafe
    {
        public byte[] Serialize();
        public void Deserialize(byte[] inputBuffer);
    }
}
