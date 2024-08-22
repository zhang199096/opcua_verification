using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opcua_verification.services
{
    internal class NAEBot : INAEServcies
    {


        private PCRImpl pcr;

        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double SetTemp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CurTemp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int mode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<int> GetPmtValue()
        {
            throw new NotImplementedException();
        }

        public void SetExposure(double exposure)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        void IPMTServcies.StartCapture()
        {
            throw new NotImplementedException();
        }
        void ICamServcies.StartCapture()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void StopCapture()
        {
            throw new NotImplementedException();
        }
    }
}
