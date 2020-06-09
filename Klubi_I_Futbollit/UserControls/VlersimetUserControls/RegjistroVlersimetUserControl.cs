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

namespace Klubi_I_Futbollit.UserControls.VlersimetUserControls
{
    public partial class RegjistroVlersimetUserControl : UserControl
    {
        public RegjistroVlersimetUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVlersimi.Text == " ")
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

        private void RegjistroVlersimetUserControl_Load(object sender, EventArgs e)
        {
            
                SqlConnection sqlcon = new SqlConnection(@"Data Source=ARNIS;Initial Catalog=Gjeneta;Integrated Security=True");
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
    }
}
