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
    public partial class EditoUshtrimeUserControl : UserControl
    {
        public EditoUshtrimeUserControl()
        {
            InitializeComponent();
        }

        private void EditoUshtrimeUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.GjejUshtrimMeID(ushtrimet);
            txtDita.Text = ushtrimet.Dita;
            txtOra.Text = ushtrimet.Ora;
            panel1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Ushtrimet ushtrimet = new Ushtrimet();
                ushtrimet.Dita = txtDita.Text.Trim();
                ushtrimet.Ora = txtOra.Text.Trim();
                ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
                UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
                ushtrimetDAL.Update(ushtrimet);
                txtDita.Text = txtOra.Text = "";
            }
        }
    }
}
