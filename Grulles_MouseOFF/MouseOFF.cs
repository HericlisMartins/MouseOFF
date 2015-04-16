using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grulles_MouseOFF
{
    class MouseOFF
    {

        public void iniciar()
        {
        try
        {
            var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Windows Kits\8.1\Tools\x64\devcon.exe");
            
                psi.UseShellExecute = false;
            

            psi.Arguments = @"disable *mou";
            Process pDisable = Process.Start(psi);

            psi.Arguments = @"enable *mou";
            Process pEnable = Process.Start(psi);
        }

        catch(Exception e)
        {
            string message = e.Message;
            MessageBox.Show("Dispositivo não encontrado", e.Message);
            
            
        }
       
        }
    }
}

