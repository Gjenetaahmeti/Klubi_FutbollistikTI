using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_;
using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoStadiume : Form
    {
        public MenaxhoStadiume()
        {
            InitializeComponent();
        }

        private void btnRegjistroStadium_Click(object sender, EventArgs e)
        {
            if (txtEmertimiStadiumit.Text == " " || txtVendiStadiumit.Text == "" )
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                Stadiumi stadiumi = new Stadiumi();
                stadiumi.Emertimi = txtEmertimiStadiumit.Text.Trim();
                stadiumi.Vendi = txtVendiStadiumit.Text.Trim();

                StadiumiBLL stadiumibll = new StadiumiBLL();
                stadiumibll.Regjistro(stadiumi);

                txtEmertimiStadiumit.Text = txtVendiStadiumit.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }

        private void btnEditoStadium_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Stadiumi stadiumi = new Stadiumi();
                stadiumi.Emertimi = txtEmertimiStadiumit.Text.Trim();
                stadiumi.Vendi = txtVendiStadiumit.Text.Trim();
                stadiumi.StadiumiID = int.Parse(txtKerkoMeID.Text.Trim());


                StadiumiBLL stadiumiBLL = new StadiumiBLL();
                stadiumiBLL.Edito(stadiumi);
                txtEmertimiStadiumit.Text = txtVendiStadiumit.Text = "";
            }
        }

        private void btnFshijStadium_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Stadiumi stadiumi = new Stadiumi();
                stadiumi.StadiumiID = int.Parse(txtKerkoMeID.Text.Trim());
         

                StadiumiBLL stadiumiBLL = new StadiumiBLL();
                stadiumiBLL.Fshij(stadiumi);
                txtEmertimiStadiumit.Text = txtVendiStadiumit.Text = "";
            }
        }

        private void btnShfaqStadiumet_Click(object sender, EventArgs e)
        {
            StadiumiBLL stadiumiBLL = new StadiumiBLL();


            dgvMbushStadiumet.DataSource = stadiumiBLL.ShfaqListenEStadiumeve();

            txtEmertimiStadiumit.Text = txtVendiStadiumit.Text = "";
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Stadiumi stadiumi = new Stadiumi();
            stadiumi.StadiumiID = int.Parse(txtKerkoMeID.Text.Trim());
            StadiumiBLL stadiumiBLL = new StadiumiBLL();
            stadiumiBLL.GjejStadiuminMeID(stadiumi);
            txtEmertimiStadiumit.Text = stadiumi.Emertimi;
            txtVendiStadiumit.Text = stadiumi.Vendi;
        }
    }
}
