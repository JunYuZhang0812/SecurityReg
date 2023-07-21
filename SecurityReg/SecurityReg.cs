using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecurityReg
{
    public partial class SecurityReg : Form
    {
        public SecurityReg()
        {
            InitializeComponent();
            
        }
        private void m_btnReg32_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("注册成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_btnReg64_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("注册成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SecurityReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var result = MessageBox.Show("EXE运行地址:" + Application.StartupPath, "地址信息", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(Application.StartupPath);
                }
            }
        }
    }
}
