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
    public partial class FshijLojtarUserControl : UserControl
    {
        public FshijLojtarUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Lojtari lojtari = new Lojtari();
                lojtari.LojtariID = int.Parse(txtShkruajID.Text.Trim());
                LojtariBLL lojtariBLL = new LojtariBLL();
                lojtariBLL.Fshij(lojtari);

                txtShkruajID.Text = "";
            }
        }
    }
}
