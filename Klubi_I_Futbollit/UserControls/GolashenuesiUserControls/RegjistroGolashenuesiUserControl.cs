using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_I_Futbollit.BO;
using Klubi_I_Futbollit.BLL;
using System.Data.SqlClient;

namespace Klubi_I_Futbollit.UserControls.GolashenuesiUserControls
{
    public partial class RegjistroGolashenuesiUserControl : UserControl
    {
        public RegjistroGolashenuesiUserControl()
        {
            InitializeComponent();
            GjejLojtarinDheNdeshjen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumriGolave.Text == " ")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                var lojtari = cmbLojtari.SelectedValue.ToString();
                var ndeshja = cmbNdeshja.SelectedValue.ToString();
                Golashenuesit golaShenuesit = new Golashenuesit();
                golaShenuesit.lojtariID = int.Parse(lojtari);
                golaShenuesit.NumriGolave = int.Parse(txtNumriGolave.Text.Trim());
                golaShenuesit.ndeshjaID = int.Parse(ndeshja);
                GolashenuesiBLL golashenuesiBLL = new GolashenuesiBLL();
                golashenuesiBLL.Regjistro(golaShenuesit);
                cmbLojtari.Text = cmbNdeshja.Text = txtNumriGolave.Text = "";
                MessageBox.Show("U regjistrua me sukses");
            }
        }
        public void GjejLojtarinDheNdeshjen()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ARNIS;Initial Catalog=Gjeneta;Integrated Security=True");
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
    }
}
