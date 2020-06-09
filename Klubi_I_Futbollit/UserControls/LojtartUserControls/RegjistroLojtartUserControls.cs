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

namespace Klubi_I_Futbollit.UserControls.LojtartUserControls
{
    public partial class RegjistroLojtartUserControls : UserControl
    {
        public RegjistroLojtartUserControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalekalimi.Text == "" || txtNumriIfanelles.Text == ""
             || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" || txtGrupigjakut.Text == "" ||
             txtShtetesia.Text == "" || txtVendbanimi.Text == "" || txtShtetesia.Text == ""
             || txtEmail.Text == "" || txtPesha.Text == "" || txtGjatesia.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");

            }
            else
            {
                Lojtari person = new Lojtari();
                person.Emri = txtEmri.Text.Trim();
                person.Mbiemri = txtMbiemri.Text.Trim();
                person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                person.Fjalkalimi = txtFjalekalimi.Text.Trim();
                person.NumriFanelles = int.Parse(txtNumriIfanelles.Text.Trim());
                person.Gjinia = txtGjinia.Text.Trim();
                person.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                person.Vendlindja = txtVendlindja.Text.Trim();
                person.GrupiGjakut = txtGrupigjakut.Text.Trim();
                person.Shteti = txtShtetesia.Text.Trim();
                person.Vendbanimi = txtVendbanimi.Text.Trim();
                person.Telefoni = txtNumriTelefonit.Text.Trim();
                person.Mail = txtEmail.Text.Trim();
                person.Pesha = decimal.Parse(txtPesha.Text.Trim());
                person.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
                LojtariBLL lojtariBLL = new LojtariBLL();
                lojtariBLL.Regjistro(person);

                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtNumriIfanelles.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text = txtShtetesia.Text =
                    txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text = txtPesha.Text = txtGjatesia.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
