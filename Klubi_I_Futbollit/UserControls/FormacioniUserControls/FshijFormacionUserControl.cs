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

namespace Klubi_I_Futbollit.UserControls.FormacioniUserControls
{
    public partial class FshijFormacionUserControl : UserControl
    {
        public FshijFormacionUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
                statusiLojtarit.StatusiID = int.Parse(txtGjejMeIDFormacion.Text.Trim());
                StatusiLojtaritBLL statusiLojtaritDAL = new StatusiLojtaritBLL();
                statusiLojtaritDAL.Fshij(statusiLojtarit);

                txtGjejMeIDFormacion.Text = "";
            }
        }
    }
}
