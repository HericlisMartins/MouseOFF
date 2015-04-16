using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Diagnostics;

namespace Grulles_MouseOFF
{
    public partial class frmPrincipal : MetroForm 
    {
        public void desabilitarDevcon()
        {
            try
            {
                var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Windows Kits\8.1\Tools\x64\devcon.exe");

                psi.UseShellExecute = false;


                psi.Arguments = @"disable * PID&1001&Col01\9&215c55b7&0&0000";
                Process pDisable = Process.Start(psi);
                
                Console.In.Read();
                Console.ReadKey();
            }

            catch (Exception e)
            {
                string message = e.Message;

            }
        }
        public void habilitarMouse()
        {


            try
            {
                var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Windows Kits\8.1\Tools\x64\devcon.exe");

                psi.UseShellExecute = false;


                psi.Arguments = @"enable * PID&1001&Col01\9&215c55b7&0&0000";
                Process pEnable = Process.Start(psi);

                Console.In.Read();
                Console.ReadKey();
            }

            catch (Exception e)
            {
                string message = e.Message;

            }
            

        }
    

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            btnDesativar.Enabled = true;
            btnAtivar.Enabled = false;
            habilitarMouse();
            
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {


            MetroMessageBox.Show(this, "Deseja desativar o Mouse?", "Desativar Mouse", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                
                if (MessageBoxButtons.OK ==  MessageBoxButtons.OK)
                {
                    btnDesativar.Enabled = false;
                    btnAtivar.Enabled = true;
                    
                }

                desabilitarDevcon();
        }
    }
}
