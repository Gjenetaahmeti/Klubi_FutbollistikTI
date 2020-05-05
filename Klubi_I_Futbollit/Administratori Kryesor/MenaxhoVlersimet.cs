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
            var lojtari = cmbSelektoLojtarin.SelectedValue.ToString();

            Vlersimet vlersimet = new Vlersimet();
            vlersimet.lojtariID = int.Parse(lojtari);
            vlersimet.Vlersimi = decimal.Parse(txtVlersimi.Text);
            VlersimetBLL bll = new VlersimetBLL();
            bll.Regjistro(vlersimet);
        }
       

        private void btnEdito_Click(object sender, EventArgs e)
        {
            var lojtari = cmbSelektoLojtarin.SelectedValue.ToString();
            Vlersimet vlersimet = new Vlersimet();
            vlersimet.StatusiID = int.Parse(txtKerko.Text.Trim());
            vlersimet.lojtariID = int.Parse(lojtari);
            vlersimet.Vlersimi = decimal.Parse(txtVlersimi.Text.Trim());
            VlersimetBLL vlersimetBLL = new VlersimetBLL();
            vlersimetBLL.Edito(vlersimet);
        }
        public void GjejLojtarin()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=Gjeneta;Integrated Security=True");
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
            Vlersimet vler = new Vlersimet();
            vler.StatusiID = int.Parse(txtKerko.Text.Trim());
            VlersimetBLL bll = new VlersimetBLL();
            bll.Fshij(vler);
        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            VlersimetBLL bll = new VlersimetBLL();
            dgdMbushVlersimet.DataSource = bll.ShfaqListenEVlersimeve();
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
    }
}
