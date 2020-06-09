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

namespace Klubi_I_Futbollit.UserControls.ReferatUserControls
{
    public partial class EditoReferatUserControl : UserControl
    {
        public EditoReferatUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Referi referi = new Referi();
            referi.ReferiID = int.Parse(txtKerko.Text.Trim());
            ReferiBLL gjejRefer = new ReferiBLL();
            gjejRefer.GjejReferMeID(referi);
            txtEmri.Text = referi.Emri;
            txtMbiemri.Text = referi.Mbiemri;
            txtEmriPerdoruesit.Text = referi.EmriIPerdoruesit;
            txtFjalkalimi.Text = referi.Fjalkalimi;
            txtSpecializimi.Text = referi.Specializimi;
            txtTitulli.Text = referi.Titulli;
            txtGjinia.Text = referi.Gjinia;
            txtDitelindja.Text = referi.Ditelindja.ToString();
            txtVendlindja.Text = referi.Vendlindja.ToString();
            txtShteti.Text = referi.Shteti;
            txtVendbanimi.Text = referi.Vendbanimi;
            txtTelefoni.Text = referi.Telefoni.ToString();
            txtEmail.Text = referi.Mail;
            txtPozita.Text = referi.Pozita;
            panel1.Visible = false;
        }
    }
}
