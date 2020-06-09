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

namespace Klubi_I_Futbollit.UserControls.StadiumUserControls
{
    public partial class EditoStadiumUserControl : UserControl
    {
        public EditoStadiumUserControl()
        {
            InitializeComponent();
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Stadiumi stadiumi = new Stadiumi();

            stadiumi.StadiumiID = int.Parse(txtGjejStadiumMeID.Text.Trim());
            StadiumiBLL stadiumiBLL = new StadiumiBLL();
            stadiumiBLL.GjejStadiuminMeID(stadiumi);
            txtEmriStadiumit.Text = stadiumi.Emertimi;
            txtVendiStadiumit.Text = stadiumi.Vendi;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Stadiumi stadiumi = new Stadiumi();

                stadiumi.Emertimi = txtEmriStadiumit.Text.Trim();
                stadiumi.Vendi = txtVendiStadiumit.Text.Trim();
                stadiumi.StadiumiID = int.Parse(txtGjejStadiumMeID.Text.Trim());


                StadiumiBLL stadiumiBLL = new StadiumiBLL();
                stadiumiBLL.Edito(stadiumi);
                txtEmriStadiumit.Text = txtVendiStadiumit.Text = "";
            }
        }
    }
}
