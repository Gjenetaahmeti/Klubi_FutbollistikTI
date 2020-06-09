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

namespace Klubi_I_Futbollit.UserControls.KlubetUserControls
{
    public partial class RegjistroKlubUserControl : UserControl
    {
        public RegjistroKlubUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmertimi.Text == " " || txtVendi.Text == "" || txtKyetari.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                Klubi klubi = new Klubi();
                klubi.Emertimi = txtEmertimi.Text.Trim();
                klubi.Vendi = txtVendi.Text.Trim();
                klubi.Kryetari = txtKyetari.Text.Trim();
                klubi.IThemeluar = DateTime.Parse(dtpDataeThemelimit.Text.Trim());

                KlubiBLL klubiDAL = new KlubiBLL();
                klubiDAL.Regjistro(klubi);

                txtEmertimi.Text = txtVendi.Text = txtKyetari.Text = dtpDataeThemelimit.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
