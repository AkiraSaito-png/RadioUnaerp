using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmMenu : MetroFramework.Forms.MetroForm
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tileProgramas_Click(object sender, EventArgs e)
        {
            FrmProgramas frmprograma = new FrmProgramas();
            frmprograma.Show();
        }
    }
}
