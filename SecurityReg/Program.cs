using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecurityReg
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try//32位
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\MICROSOFT\.NETFramework\Security\TrustManager\PromptingLevel");
                key.SetValue("MyComputer", "Enabled");
                key.SetValue("LocalIntranet", "Enabled");
                key.SetValue("Internet", "Enabled");
                key.SetValue("TrustedSites", "Enabled");
                key.SetValue("UntrustedSites", "Enabled");
                key.Close();
            }
            catch (Exception ex)
            {
            }
            try//64位
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Wow6432Node\MICROSOFT\.NETFramework\Security\TrustManager\PromptingLevel");
                key.SetValue("MyComputer", "Enabled");
                key.SetValue("LocalIntranet", "Enabled");
                key.SetValue("Internet", "Enabled");
                key.SetValue("TrustedSites", "Enabled");
                key.SetValue("UntrustedSites", "Enabled");
                key.Close();
            }
            catch (Exception ex)
            {
            }
            Application.Exit();
            //Application.Run(new SecurityReg());
        }
    }
}
