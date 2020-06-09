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

namespace Klubi_I_Futbollit.UserControls.VlersimetUserControls
{
    public partial class EditoVlersimetUserControl : UserControl
    {
        public EditoVlersimetUserControl()
        {
            InitializeComponent();
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Vlersimet vler = new Vlersimet();
            vler.StatusiID = int.Parse(txtKerko.Text.Trim());
            VlersimetBLL bll = new VlersimetBLL();
            bll.GjejVlersiminMeID(vler);
            cmbSelektoLojtarin.Text = vler.lojtariID.ToString();
            txtVlersimi.Text = vler.Vlersimi.ToString();
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                var lojtari = cmbSelektoLojtarin.SelectedValue.ToString();
                Vlersimet vlersimet = new Vlersimet();
                vlersimet.StatusiID = int.Parse(txtKerko.Text.Trim());
                vlersimet.lojtariID = int.Parse(lojtari);
                vlersimet.Vlersimi = decimal.Parse(txtVlersimi.Text.Trim());
                VlersimetBLL vlersimetBLL = new VlersimetBLL();
                vlersimetBLL.Edito(vlersimet);
                cmbSelektoLojtarin.Text = txtVlersimi.Text = "";
            }
        }
    }
}
