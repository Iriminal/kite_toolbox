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
            retry:
            try {
                var client = new WebClient();
                String s = client.DownloadString("http://api-acecyber.rhcloud.com/hasUpdate?currentVersion=" + productVersion);
                s = s.Replace("<html>", "");
                s = s.Replace("</html>", "");

                int i = s.IndexOf(',');
                String ver = s.Substring(0, i);
                if (ver == "0") goto a;
                String info = s.Substring(i + 1, s.Length - i - 1);
                new NewVersion(ver, info).ShowDialog();
                return;
            }
            catch{
                DialogResult a =
                    MessageBox.Show("无法检查更新! 请检查您的网络设置 (或者更新服务器爆炸了) \n 点击重试可再次尝试检测更新。",
                    "无法检查更新",MessageBoxButtons.RetryCancel);
                if(a == DialogResult.Retry) goto retry;
                else goto a;
                
            }

            a:
            Application.Run(new MainForm());
        }
        

    }
}
