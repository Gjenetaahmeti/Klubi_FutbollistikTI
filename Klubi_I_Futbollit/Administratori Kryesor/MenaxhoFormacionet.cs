using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Klubi_;
using Klubi_I_Futbollit.BO;
using Klubi_I_Futbollit.BLL;

namespace Klubi_I_Futbollit
{
    public partial class Formacionet : Form
    {
        public Formacionet()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=Gjeneta;Integrated Security=True");
            sqlcon.Open();
            SqlCommand command = new SqlCommand("usp_MerrLojtart", sqlcon);
            SqlDataAdapter d = new SqlDataAdapter("usp_MerrLojtart", sqlcon);
            DataSet dt = new DataSet();
            d.Fill(dt);
            if (dt.Tables[0].Rows.Count>0)
            {
                comboBox1.DataSource = dt.Tables[0];
                comboBox1.DisplayMember = "Emri"; 
                comboBox1.ValueMember = "PersoneliId";
            }
            else
            {
                MessageBox.Show("Asnje lojtar nuk eshte gjetur");
            }
        }

        private void BtnRegjistroFormacion_Click(object sender, EventArgs e)
        {
            if (txtPergjegjes.Text == " ")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                var der2 = comboBox1.SelectedValue.ToString();


                StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
                statusiLojtarit.Pergjegjes = txtPergjegjes.Text.Trim();
                statusiLojtarit.Rezerv = txtRezerve.Text.Trim();
                statusiLojtarit.Huazim = txtHuazim.Text.Trim();
                statusiLojtarit.Shoqerues = txtShoqerues.Text.Trim();
                Lojtari lojtari = new Lojtari();
                lojtari.LojtariID = int.Parse(der2);
                StatusiLojtaritBLL statusiLojtaritDAL = new StatusiLojtaritBLL();
                statusiLojtaritDAL.Regjistro(statusiLojtarit);

                txtPergjegjes.Text = txtHuazim.Text = txtShoqerues.Text = comboBox1.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }

        private void BtnKerkoMeId_Click(object sender, EventArgs e)
        {
            StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
            statusiLojtarit.StatusiID =int.Parse(txtGjejMeIDFormacion.Text.Trim());
            StatusiLojtaritBLL statusiLojtarit1 = new StatusiLojtaritBLL();
            statusiLojtarit1.GjejStatusinELojtaritMeID(statusiLojtarit);

            txtPergjegjes.Text = statusiLojtarit.Pergjegjes;
            txtRezerve.Text = statusiLojtarit.Rezerv;
            txtHuazim.Text = statusiLojtarit.Huazim;
            txtShoqerues.Text = statusiLojtarit.Shoqerues;
        }

        private void BtnEdito_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                var der2 = comboBox1.SelectedValue.ToString();


                StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
                statusiLojtarit.Pergjegjes = txtPergjegjes.Text.Trim();
                statusiLojtarit.Rezerv = txtRezerve.Text.Trim();
                statusiLojtarit.Huazim = txtHuazim.Text.Trim();
                statusiLojtarit.Shoqerues = txtShoqerues.Text.Trim();
                statusiLojtarit.StatusiID = int.Parse(txtGjejMeIDFormacion.Text.Trim());
                Lojtari lojtari = new Lojtari();
                lojtari.LojtariID = int.Parse(der2);
                StatusiLojtaritBLL statusiLojtaritDAL = new StatusiLojtaritBLL();
                statusiLojtaritDAL.Edito(statusiLojtarit);

                txtPergjegjes.Text = txtHuazim.Text = txtShoqerues.Text = comboBox1.Text = "";
            }
        }

        private void BtnShfaq_Click(object sender, EventArgs e)
        {
            StatusiLojtaritBLL statusiLojtarit = new StatusiLojtaritBLL();
            dgdmbushFormacion.DataSource = statusiLojtarit.ShfaqListenEStatuseveTeLojtarit();
            txtPergjegjes.Text = txtHuazim.Text = txtShoqerues.Text = comboBox1.Text = "";
        }

        private void BtnFshij_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
                statusiLojtarit.StatusiID = int.Parse(txtGjejMeIDFormacion.Text.Trim());
                StatusiLojtaritBLL statusiLojtaritDAL = new StatusiLojtaritBLL();
                statusiLojtaritDAL.Fshij(statusiLojtarit);

                txtPergjegjes.Text = txtHuazim.Text = txtShoqerues.Text = comboBox1.Text = "";
            }
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja menyKryefaqja = new MenyKryefaqja();
            menyKryefaqja.ShowDialog();
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(Administratori_Kryesor.MenaxhoPersonelin personelin = new Administratori_Kryesor.MenaxhoPersonelin())
            {
                personelin.ShowDialog();
            }
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoLojtaret lojtaret = new Administratori_Kryesor.MenaxhoLojtaret())
            {
                lojtaret.ShowDialog();
            }
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoTrajner trajner = new Administratori_Kryesor.MenaxhoTrajner())
            {
                trajner.ShowDialog();
            }
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoNdeshje ndeshje = new Administratori_Kryesor.MenaxhoNdeshje())
            {
                ndeshje.ShowDialog();
            }
        }

        private void MenaxhoFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenaxhoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoGolashenuesin golashenuesin = new Administratori_Kryesor.MenaxhoGolashenuesin())
            {
                golashenuesin.ShowDialog();
            }
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoDelegat delegat = new Administratori_Kryesor.MenaxhoDelegat())
            {
                delegat.ShowDialog();
            }
        }

        private void MenaxhoKluubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoKlub klub = new Administratori_Kryesor.MenaxhoKlub())
            {
                klub.ShowDialog();
            }
        }

        private void MenaxhoUshtrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoUshtrime ushtrime = new Administratori_Kryesor.MenaxhoUshtrime()) 
            {
                ushtrime.ShowDialog();
            }
           
        }

        private void MenaxhoVleresimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoVlersimet vlersimet = new Administratori_Kryesor.MenaxhoVlersimet())
            {
                vlersimet.ShowDialog();
            }
        }
    }
}
