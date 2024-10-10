using Microsoft.VisualStudio.TestTools.UnitTesting;
using opcua_verification.services;
using System;
using Xunit;

namespace AddTest
{

    public class UnitCR3
    {
        [Theory]
        [InlineData("demo.json",1,0)]
        public void TestStartPath(string path,int _count,int cart)
        {
            IRobot robot = new CR3Driver();
            if(robot.connnect("192.168.5.1", 29999, 30003, 30004))
                robot.StartPath(path,_count,cart);
           // robot.connnect();
        }
    }
}
