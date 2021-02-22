using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        //PROGRAMA DESENVOLVIDO POR ALESSANDRO SAITO E THIAGO ALCARÁS


        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin formLogin = new FrmLogin();
            if(formLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMenu());
            }            
        }
    }
}
