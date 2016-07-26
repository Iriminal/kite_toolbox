using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace kiteToolBox
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            String productVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Request update
            var client = new WebClient();
            String s = client.DownloadString("http://api-acecyber.rhcloud.com/hasUpdate?currentVersion=" + productVersion);

            s = s.Replace("<html>", "");
            s = s.Replace("</html>", "");
  
            int i = s.IndexOf(',');
            String ver = s.Substring(0,i);
            if (ver == "0") goto a;
            String info = s.Substring(i + 1, s.Length - i - 1);
            Application.Run(new NewVersion(ver, info));
            return;

            a:
            Application.Run(new MainForm());
        }
        

    }
}
