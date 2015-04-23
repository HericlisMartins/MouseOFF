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
        // Variaveis utilizadas na contagem de tempo em que o mouse sera desativado.
        int segundosSolicitados;
        int contador;
        int auxiliar = 0;

        public void desabilitarDevcon() // Função para desabilitar o Mouse 
        {
            try
            {
                var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Windows Kits\8.1\Tools\x64\devcon.exe"); //A classe ProcessStartInfo especifica um conjunto de valores que são usados quando Devcon for iniciado. Ou seja ela é responsavel por buscar um arquivo externo.

                psi.UseShellExecute = false;


                psi.Arguments = @"disable"; // Arguments Obtém  o conjunto de argumentos do Devcon para ser usado quando a aplicação for iniciada. Neste caso o Argumento é o Disable, responsavel por desabilitar o mouse.
                Process pDisable = Process.Start(psi); // A Classe process fornece acesso ao local e remoto para INICIAR ou INTERROMPER processos do sistema local.
                
                Console.In.Read();
                Console.ReadKey();
            }

            catch (Exception e) // Se o Mouse não estiver conectado ao computador, o Try Catch se trata a exceção informando que o Mouse não esta Conectado. 
            {
                string message = e.Message; // Variavel associada ao Exception ( Exceção ).
                MetroMessageBox.Show(this, "O Mouse não esta conectado ao computador.", "Dispositivo não encontrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
        public void habilitarMouse() // Função para Habilitar o Mouse.
        {


            try
            {
                var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Windows Kits\8.1\Tools\x64\devcon.exe"); //A classe ProcessStartInfo Especifica um conjunto de valores que são usados quando iniciar o Devcon

                psi.UseShellExecute = false;


                psi.Arguments = @"findall *"; // Arguments Obtém  o conjunto de argumentos do Devcon para ser usado quando a aplicação for iniciada. Neste caso o Argumento é o Enable, responsavel por desabilitar o mouse.
                Process pEnable = Process.Start(psi); // A Classe process fornece acesso ao local e remoto para INICIAR ou INTERROMPER processos do sistema local.
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


        private void btnAtivar_Click(object sender, EventArgs e) // Ativa a contagem de tempo que o usuario determinou.
        {
           
            segundosSolicitados = Int32.Parse(txtReceptor.Text);

            if (tmpTimer.Enabled == false)
            {
                tmpTimer.Enabled = true;
            }

            else if (tmpTimer.Enabled == true)
            {
                tmpTimer.Enabled = false;
            }

            btnDesativar.Enabled = true; // Quando o Usuario clicar em Ativar, o botaão Desativar estará Habilitado.
            btnAtivar.Enabled = false; // Quando o Usuario Clicar em Ativar, o botão Ativar Estará Desabilitado
            
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            btnAtivar.Enabled = true;
            btnDesativar.Enabled = false;
            lblInterface.Text = auxiliar.ToString();
            tmpTimer.Enabled = false;
                
        }

        private void btnDesativarAgora_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Deseja desativar o Mouse.", "Dispositivo não encontrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            
        }
        private void txtReceptor_Click(object sender, EventArgs e)
        {
           
        }

        private void tmpTimer_Tick(object sender, EventArgs e)
        {
            contador = contador + 1; // Tempo é contato de 1 em 1
            lblInterface.Text = contador.ToString(); // Converte o contador em String.

            if (contador == segundosSolicitados)
            {
                MetroMessageBox.Show(this, "O Mouse foi desativado", "Mouse desativado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Se os segundos do contador for igual ao segundos no qual o usuario solicitou o mouse é desativado. Após essa condição as seguintes 
                lblInterface.Text = auxiliar.ToString();
                contador = 0; // Ao atingir os segundos solicitados pelo o usuario, o contador é "Zerado".
                tmpTimer.Enabled = false; // O tempo é desativado
                btnAtivar.Enabled = true; // O botão Ativar é Habilitado novamente.
                btnDesativar.Enabled = false; // O botão desativar é desabilitado.
                
            }
        }

        private void txtReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // Permite que o usuario digite apenas numeros na solicitação de segundos para desabilitar o mouse.
            {
	            e.Handled = true;

            }
        }
    }
}
