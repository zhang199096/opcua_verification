using Opc.Ua;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opcua_verification
    {
    public static class Program
        {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Tsystem tsystem = Tsystem.getInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "VerificationServer";
            ThreadPool.QueueUserWorkItem(o =>
            {
                try
                {
                    Thread.Sleep(100);
                    // tsystem.start();//初始化后台, 注册dll, 启动接收线程,发送B0包, 发送B1包, 启动DSP
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
            try
            {

                // process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new VerificationServer());
                    return;
                }

                // load the application configuration.
                application.LoadApplicationConfiguration("D:/learn_ws/opcuaTools/opcua_verification/opcua_verification/opcua_verification/VerificationServer.Config.xml", false).Wait();

                // check the application certificate.
                application.CheckApplicationInstanceCertificate(false, 0).ConfigureAwait(false);

                // start the server.
                application.Start(new VerificationServer()).Wait();

                // run the application interactively.
                Application.Run(new Form1(application));
            }
            catch (Exception e)
            {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += e.InnerException.Message;
                }
                // MessageBox.Show(text, application.ApplicationName);
            }
        }
    }
}
