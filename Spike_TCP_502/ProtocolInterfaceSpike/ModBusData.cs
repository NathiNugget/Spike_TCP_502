using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusTest
{
    public struct ModBusData
    {
        public byte functionCode;
        public byte[] payload = [];

        public ModBusData()
        {
        }
    }
}
