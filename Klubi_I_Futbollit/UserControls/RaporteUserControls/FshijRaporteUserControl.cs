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

namespace Klubi_I_Futbollit.UserControls.RaporteUserControls
{
    public partial class FshijRaporteUserControl : UserControl
    {
        public FshijRaporteUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Raporti raporti = new Raporti();
                raporti.NdeshjaID = int.Parse(txtGjejMeid.Text.Trim());
                RaportiBLL raportibll = new RaportiBLL();
                raportibll.Fshij(raporti);
                txtGjejMeid.Text = "";
            }
        }
    }
}
