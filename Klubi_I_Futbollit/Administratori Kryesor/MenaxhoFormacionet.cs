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

namespace Klubi_I_Futbollit
{
    public partial class Formacionet : Form
    {
        public Formacionet()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");
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

            var der2 = comboBox1.SelectedValue.ToString();
            txtFormacioni.Text = der2;

            StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
            statusiLojtarit.Pergjegjes = txtPergjegjes.Text.Trim();
            statusiLojtarit.Rezerv = txtRezerve.Text.Trim();
            statusiLojtarit.Huazim = txtHuazim.Text.Trim();
            statusiLojtarit.Shoqerues = txtShoqerues.Text.Trim();
            Lojtari lojtari = new Lojtari();
            lojtari.LojtariID =int.Parse(der2);
            StatusiLojtaritDAL statusiLojtaritDAL = new StatusiLojtaritDAL();
            statusiLojtaritDAL.Shto(statusiLojtarit, lojtari);


        }

        private void BtnKerkoMeId_Click(object sender, EventArgs e)
        {
            StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
            statusiLojtarit.StatusiID =int.Parse(txtGjejMeIDFormacion.Text.Trim());
            StatusiLojtaritDAL statusiLojtarit1 = new StatusiLojtaritDAL();
            statusiLojtarit1.MerriMeIdFormacion(statusiLojtarit);

            txtPergjegjes.Text = statusiLojtarit.Pergjegjes;
            txtRezerve.Text = statusiLojtarit.Rezerv;
            txtHuazim.Text = statusiLojtarit.Huazim;
            txtShoqerues.Text = statusiLojtarit.Shoqerues;
        }

        private void BtnEdito_Click(object sender, EventArgs e)
        {
            var der2 = comboBox1.SelectedValue.ToString();
            txtFormacioni.Text = der2;

            StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
            statusiLojtarit.Pergjegjes = txtPergjegjes.Text.Trim();
            statusiLojtarit.Rezerv = txtRezerve.Text.Trim();
            statusiLojtarit.Huazim = txtHuazim.Text.Trim();
            statusiLojtarit.Shoqerues = txtShoqerues.Text.Trim();
            statusiLojtarit.StatusiID=int.Parse(txtGjejMeIDFormacion.Text.Trim());
            Lojtari lojtari = new Lojtari();
            lojtari.LojtariID = int.Parse(der2);
            StatusiLojtaritDAL statusiLojtaritDAL = new StatusiLojtaritDAL();
            statusiLojtaritDAL.Update(statusiLojtarit, lojtari);
        }

        private void BtnShfaq_Click(object sender, EventArgs e)
        {
            StatusiLojtaritDAL statusiLojtarit = new StatusiLojtaritDAL();
            dgdmbushFormacion.DataSource = statusiLojtarit.GetAll();
        }

        private void BtnFshij_Click(object sender, EventArgs e)
        {
            StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
            statusiLojtarit.StatusiID=int.Parse(txtGjejMeIDFormacion.Text.Trim());
            StatusiLojtaritDAL statusiLojtaritDAL = new StatusiLojtaritDAL();
            statusiLojtaritDAL.Fshij(statusiLojtarit);
        }
    }
}
