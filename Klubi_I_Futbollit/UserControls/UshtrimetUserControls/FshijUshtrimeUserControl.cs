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
using Klubi_;

namespace Klubi_I_Futbollit.UserControls.UshtrimetUserControls
{
    public partial class FshijUshtrimeUserControl : UserControl
    {
        public FshijUshtrimeUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Ushtrimet ushtrimet = new Ushtrimet();
                ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
                UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
                ushtrimetDAL.FshijMeID(ushtrimet);

                txtGjejMeID.Text =  "";
            }
        }
    }
}
