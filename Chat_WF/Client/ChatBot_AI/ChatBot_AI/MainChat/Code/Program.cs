using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot_AI.MainChat.Code
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalErrorHandler);
            Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(GlobalErrorHandler);
            Application.Run(new ChatBot_AI.Registration.Forms.Registration());
        }

        private static void GlobalErrorHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            MessageBox.Show(ex.Message, "Global error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
