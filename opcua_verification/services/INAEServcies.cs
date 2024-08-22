using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opcua_verification.services
{
    public interface ICamServcies
    {
        string Name { get; set; }
        int mode { get; set; }
        void StartCapture();
        void StopCapture();
        void SetExposure(double exposure);
    }

    public interface IPMTServcies
    {
        string Id { get; set; }
        void StartCapture();
        void StopCapture();
        List<int> GetPmtValue();
    }

    public interface IPCRServcies
    {
        string Id { get; set; }
        double SetTemp { get; set; }
        double CurTemp { get; set; }
        void Start();
        void Stop();
    }

    public interface INAEServcies:IPCRServcies ,IPMTServcies,ICamServcies
    {

    }
}
