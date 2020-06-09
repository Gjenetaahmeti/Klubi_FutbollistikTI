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
    public partial class RegjistroStadiumUserControl : UserControl
    {
        public RegjistroStadiumUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmriStadiumit.Text == " " || txtVendiStadiumit.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                Stadiumi stadiumi = new Stadiumi();
                stadiumi.Emertimi = txtEmriStadiumit.Text.Trim();
                stadiumi.Vendi = txtVendiStadiumit.Text.Trim();

                StadiumiBLL stadiumiBLL = new StadiumiBLL();
                stadiumiBLL.Regjistro(stadiumi);

                txtEmriStadiumit.Text = txtVendiStadiumit.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
