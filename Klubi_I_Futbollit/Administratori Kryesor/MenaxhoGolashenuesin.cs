using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_I_Futbollit.BO;
using Klubi_I_Futbollit.BLL;
using System.Data.SqlClient;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoGolashenuesin : Form
    {
        public MenaxhoGolashenuesin()
        {
            InitializeComponent();
            GjejLojtarinDheNdeshjen();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            var lojtari = cmbLojtari.SelectedValue.ToString() ;
            var ndeshja = cmbNdeshja.SelectedValue.ToString() ;
            Golashenuesit golaShenuesit = new Golashenuesit();
            golaShenuesit.lojtariID = int.Parse(lojtari);
            golaShenuesit.NumriGolave=int.Parse(txtNumriGolave.Text.Trim());
            golaShenuesit.ndeshjaID = int.Parse(ndeshja);
            GolashenuesiBLL golashenuesiBLL = new GolashenuesiBLL();
            golashenuesiBLL.Regjistro(golaShenuesit);
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            var lojtari = cmbLojtari.SelectedValue.ToString();
            var ndeshja = cmbNdeshja.SelectedValue.ToString();
            Golashenuesit golaShenuesit = new Golashenuesit();
            golaShenuesit.GolashenuesiID = int.Parse(txtKerkoMeID.Text);
            golaShenuesit.lojtariID = int.Parse(lojtari);
            golaShenuesit.NumriGolave = int.Parse(txtNumriGolave.Text.Trim());
            golaShenuesit.ndeshjaID = int.Parse(ndeshja);
            GolashenuesiBLL golashenuesiBLL = new GolashenuesiBLL();
            golashenuesiBLL.Edito(golaShenuesit);
        }

        private void btnFshije_Click(object sender, EventArgs e)
        {
            Golashenuesit golaShenuesi = new Golashenuesit();
            golaShenuesi.GolashenuesiID = int.Parse(txtKerkoMeID.Text.Trim());
            GolashenuesiBLL golaShenuesiBLLL = new GolashenuesiBLL();
            golaShenuesiBLLL.Fshij(golaShenuesi);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Golashenuesit golashenuesit = new Golashenuesit();
            golashenuesit.GolashenuesiID = int.Parse(txtKerkoMeID.Text.Trim());
            GolashenuesiBLL gjejGolaShenuesin = new GolashenuesiBLL();
            gjejGolaShenuesin.GjejGolashenuesinmeID(golashenuesit);
            cmbLojtari.Text = golashenuesit.lojtariID.ToString();
            txtNumriGolave.Text = golashenuesit.NumriGolave.ToString();
            cmbNdeshja.Text = golashenuesit.ndeshjaID.ToString();
            btnEdito.Visible = true;
            btnFshije.Visible = true;
            btnRegjistro.Visible = false;
        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            GolashenuesiBLL golashenuesi = new GolashenuesiBLL();
            dgdShfaqGolaShenuesit.DataSource = golashenuesi.ShfaqListenEGolaShenuesve();
        }

        public void GjejLojtarinDheNdeshjen()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");
            sqlcon.Open();
        //    SqlCommand command = new SqlCommand("usp_MerrLojtart", sqlcon);
            SqlDataAdapter d = new SqlDataAdapter("usp_MerrLojtart", sqlcon);
            DataSet dt = new DataSet();
            d.Fill(dt);
            if (dt.Tables[0].Rows.Count > 0)
            {
                cmbLojtari.DataSource = dt.Tables[0];
                cmbLojtari.DisplayMember = "Emri";
                cmbLojtari.ValueMember = "PersoneliId";
            }
            else
            {
                MessageBox.Show("Asnje lojtar nuk eshte gjetur");
            }

            SqlDataAdapter ndeshja = new SqlDataAdapter("usp_MerrNdeshjet_PerComboBox", sqlcon);
            DataSet dtNdeshja = new DataSet();
            ndeshja.Fill(dtNdeshja);
            if (dtNdeshja.Tables[0].Rows.Count > 0)
            {
                cmbNdeshja.DataSource = dtNdeshja.Tables[0];
                cmbNdeshja.ValueMember = "NdeshjaID";
            }
            else
            {
                MessageBox.Show("Asnje lojtar nuk eshte gjetur");
            }

        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja mk = new MenyKryefaqja();
            mk.ShowDialog();
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoPersonelin menaxhoPersonelin = new MenaxhoPersonelin();
            menaxhoPersonelin.ShowDialog();
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret menaxhoLojtaret = new MenaxhoLojtaret();
            menaxhoLojtaret.ShowDialog();
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoTrajner menaxho = new MenaxhoTrajner();
            menaxho.ShowDialog();
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoNdeshje menaxhoNdeshje = new MenaxhoNdeshje();
            menaxhoNdeshje.ShowDialog();
        }

        private void MenaxhoFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formacionet formacionet = new Formacionet();
            formacionet.ShowDialog();
        }

        private void MenaxhoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }

        private void MenaxhoKlubinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoKlub menaxhoKlub = new MenaxhoKlub();
            menaxhoKlub.ShowDialog();
        }
    }
}
