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
        public void desabilitarDevcon() // Metodo para desabilitar o Mouse 
        {
            try
            {
                var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Windows Kits\8.1\Tools\x64\devcon.exe");//Inicializa uma nova instância da classe ProcessStartInfo especifica um nome de arquivo, ou seja, em nosso caso estamos buscando referências no Devcon. Toda vez que o programa iniciar a função é responsavel por "Startar" o Devcon.

                psi.UseShellExecute = false;


                psi.Arguments = @"enabllee";
                Process pDisable = Process.Start(psi);
                
                Console.In.Read();
                Console.ReadKey();
            }

            catch (Exception e)
            {
                string message = e.Message;
                MetroMessageBox.Show(this, "O Mouse não esta conectado ao computador.", "Dispositivo não encontrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
        public void habilitarMouse()
        {


            try
            {
                var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Windows Kits\8.1\Tools\x64\devcon.exe");

                psi.UseShellExecute = false;


                psi.Arguments = @"findall *";
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

            if (MessageBoxButtons.OK == MessageBoxButtons.OK)
            {
                btnDesativar.Enabled = false;
                btnAtivar.Enabled = true;

            }

                
        }

        private void btnDesativarAgora_Click(object sender, EventArgs e)
        {
            desabilitarDevcon();
        }
    }
}
