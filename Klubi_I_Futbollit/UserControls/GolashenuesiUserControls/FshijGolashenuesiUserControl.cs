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

namespace Klubi_I_Futbollit.UserControls.GolashenuesiUserControls
{
    public partial class FshijGolashenuesiUserControl : UserControl
    {
        public FshijGolashenuesiUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Golashenuesit golaShenuesi = new Golashenuesit();
                golaShenuesi.GolashenuesiID = int.Parse(txtKerkoMeID.Text.Trim());
                GolashenuesiBLL golaShenuesiBLLL = new GolashenuesiBLL();
                golaShenuesiBLLL.Fshij(golaShenuesi);
               txtKerkoMeID.Text = "";
            }
        }
    }
}
