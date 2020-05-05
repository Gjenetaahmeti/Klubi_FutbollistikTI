using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit
{
    public partial class MenyKryefaqja : Form
    {
        public MenyKryefaqja()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenaxhoLojtareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoLojtaret regjistroLojtar = new Administratori_Kryesor.MenaxhoLojtaret())
            {

                regjistroLojtar.ShowDialog();
            }

            

        }
    }
}
