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

namespace Klubi_I_Futbollit.UserControls.KategoritKluboreUserControls
{
    public partial class FshijKategoritKluboreUserControl : UserControl
    {
        public FshijKategoritKluboreUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                KategoriteKlubore kl = new KategoriteKlubore();
                kl.KategoriaID = int.Parse(txtGjejmeid.Text.Trim());
                KategoriteKluboreBLL klubiDAL = new KategoriteKluboreBLL();
                klubiDAL.Fshij(kl);
                txtGjejmeid.Text = "";
            }
        }
    }
}
