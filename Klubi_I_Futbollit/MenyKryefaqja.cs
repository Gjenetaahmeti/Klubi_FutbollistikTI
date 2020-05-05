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

     
        private void MenaxhoLojtareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoPersonelin personelin = new Administratori_Kryesor.MenaxhoPersonelin())
            {

                personelin.ShowDialog();
            }
        }

        private void MenaxhoNdeshjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoLojtaret regjistrolojtar = new Administratori_Kryesor.MenaxhoLojtaret())
            {

                regjistrolojtar.ShowDialog();
            }
        }

        private void MenaxhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoTrajner trajner = new Administratori_Kryesor.MenaxhoTrajner())
            {

                trajner.ShowDialog();
            }
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoNdeshje regjistrondeshje = new Administratori_Kryesor.MenaxhoNdeshje())
            {

                regjistrondeshje.ShowDialog();
            }
        }

        private void MenaxhoKlubinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Formacionet regjistroFormacion = new Formacionet())
            {

                regjistroFormacion.ShowDialog();
            }
        }

        private void MeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoGolashenuesin golashenuesi = new Administratori_Kryesor.MenaxhoGolashenuesin())
            {

                golashenuesi.ShowDialog();
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoDelegat delegat = new Administratori_Kryesor.MenaxhoDelegat())
            {

                delegat.ShowDialog();
            }
        }

        private void MenaxhoKlubinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoKlub klub = new Administratori_Kryesor.MenaxhoKlub())
            {

                klub.ShowDialog();
            }
        }
    }
}
