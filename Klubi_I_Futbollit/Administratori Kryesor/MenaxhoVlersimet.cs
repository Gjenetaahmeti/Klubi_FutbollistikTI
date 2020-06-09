using Klubi_;
using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoVlersimet : Form
    {
        public MenaxhoVlersimet()
        {
            InitializeComponent();
            GjejLojtarin();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            if (txtVlersimi.Text == " " )
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                var lojtari = cmbSelektoLojtarin.SelectedValue.ToString();
                Vlersimet vlersimet = new Vlersimet();
                vlersimet.lojtariID = int.Parse(lojtari);
                vlersimet.Vlersimi = decimal.Parse(txtVlersimi.Text);
                VlersimetBLL bll = new VlersimetBLL();
                bll.Regjistro(vlersimet);
                cmbSelektoLojtarin.Text = txtVlersimi.Text = "";
                MessageBox.Show("u regjistrua me sukses");
            }
        }
       

        private void btnEdito_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                var lojtari = cmbSelektoLojtarin.SelectedValue.ToString();
                Vlersimet vlersimet = new Vlersimet();
                vlersimet.StatusiID = int.Parse(txtKerko.Text.Trim());
                vlersimet.lojtariID = int.Parse(lojtari);
                vlersimet.Vlersimi = decimal.Parse(txtVlersimi.Text.Trim());
                VlersimetBLL vlersimetBLL = new VlersimetBLL();
                vlersimetBLL.Edito(vlersimet);
                cmbSelektoLojtarin.Text = txtVlersimi.Text = "";
            }
        }
        public void GjejLojtarin()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");
            sqlcon.Open();
            SqlDataAdapter d = new SqlDataAdapter("usp_MerrLojtart", sqlcon);
            DataSet dt = new DataSet();
            d.Fill(dt);
            if (dt.Tables[0].Rows.Count > 0)
            {
                cmbSelektoLojtarin.DataSource = dt.Tables[0];
                cmbSelektoLojtarin.DisplayMember = "Emri";
                cmbSelektoLojtarin.ValueMember = "PersoneliId";
            }
            else
            {
                MessageBox.Show("Asnje lojtar nuk eshte gjetur");
            }
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Vlersimet vler = new Vlersimet();
                vler.StatusiID = int.Parse(txtKerko.Text.Trim());
                VlersimetBLL bll = new VlersimetBLL();
                bll.Fshij(vler);
                cmbSelektoLojtarin.Text = txtVlersimi.Text = "";
            }
        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            VlersimetBLL bll = new VlersimetBLL();
            dgdMbushVlersimet.DataSource = bll.ShfaqListenEVlersimeve();
            cmbSelektoLojtarin.Text = txtVlersimi.Text = "";
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Vlersimet vler = new Vlersimet();
            vler.StatusiID = int.Parse(txtKerko.Text.Trim());
            VlersimetBLL bll = new VlersimetBLL();
            bll.GjejVlersiminMeID(vler);
            cmbSelektoLojtarin.Text = vler.lojtariID.ToString();
            txtVlersimi.Text = vler.Vlersimi.ToString();
            btnEdito.Visible = true;
            btnFshij.Visible = true;
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja menyKryefaqja = new MenyKryefaqja();
            menyKryefaqja.ShowDialog();
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
            MenaxhoTrajner menaxhoTrajner = new MenaxhoTrajner();
            menaxhoTrajner.ShowDialog();
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
            MenaxhoGolashenuesin menaxhoGolashenuesin = new MenaxhoGolashenuesin();
            menaxhoGolashenuesin.ShowDialog();
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }

        private void MenaxhoKlubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoKlub menaxhoKlub = new MenaxhoKlub();
            menaxhoKlub.ShowDialog();
        }

        private void MenaxhoUshtrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSelektoLojtarin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenaxhoVlersimet_Load(object sender, EventArgs e)
        {

        }
    }
}
