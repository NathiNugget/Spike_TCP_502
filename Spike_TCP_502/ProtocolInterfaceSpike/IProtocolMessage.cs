using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ModbusTest
{
    public interface IProtocolMessage
    {
        public unsafe void AddData<T>(T inputData) where T : unmanaged;

        public unsafe byte[] Serialize();
    }
}
