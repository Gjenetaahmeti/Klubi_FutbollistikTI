using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoStadium : Form
    {
        public MenaxhoStadium()
        {
            InitializeComponent();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            if (txtEmriStadiumit.Text == " " || txtVendiStadiumit.Text == "" )
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

                txtEmriStadiumit.Text = txtVendiStadiumit.Text =  "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }

        private void btnEdito_Click(object sender, EventArgs e)
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
                txtEmriStadiumit.Text = txtVendiStadiumit.Text  = "";
            }
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Stadiumi stadiumi = new Stadiumi();

                stadiumi.StadiumiID = int.Parse(txtGjejStadiumMeID.Text.Trim());
                StadiumiBLL stadiumiBLL = new StadiumiBLL();
                stadiumiBLL.Fshij(stadiumi);
                txtEmriStadiumit.Text = txtVendiStadiumit.Text = "";

          
            }
        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            StadiumiBLL stadiumiBLL = new StadiumiBLL();
            dgvMbushStadiumet.DataSource = stadiumiBLL.ShfaqListenEStadiumeve();
            txtEmriStadiumit.Text = txtVendiStadiumit.Text = "";

        }

        private void btnKerko_Click(object sender, EventArgs e)
        {

            Stadiumi stadiumi = new Stadiumi();

            stadiumi.StadiumiID = int.Parse(txtGjejStadiumMeID.Text.Trim());
            StadiumiBLL stadiumiBLL = new StadiumiBLL();
            stadiumiBLL.GjejStadiuminMeID(stadiumi);
            txtEmriStadiumit.Text = stadiumi.Emertimi;
            txtVendiStadiumit.Text = stadiumi.Vendi;
        }
    }
}
