using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opcua_verification.services
{
    internal class PCRImpl : IPCRServcies
    {
        public string Id { get; set; }
        public double SetTemp { get; set; }
        public double CurTemp { get; set; }

        public void Start()
        {
            Console.WriteLine("PCR is start");
        }

        public void Stop()
        {
            Console.WriteLine("PCR is Stop");
        }
    }
}
