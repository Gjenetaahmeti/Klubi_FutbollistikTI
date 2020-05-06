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
using Klubi_I_Futbollit.BO;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoUshtrime : Form
    {
        public MenaxhoUshtrime()
        {
            InitializeComponent();
        }

        private void BtnRuaj_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.Dita = txtDita.Text.Trim();
            ushtrimet.Ora = txtOra.Text.Trim();

            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.Shto(ushtrimet);
        }

        private void BtnKerkoMeID_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();

            ushtrimetDAL.GjejUshtrimMeID(ushtrimet);
            txtDita.Text = ushtrimet.Dita;
            txtOra.Text = ushtrimet.Ora;

        }

        private void BtnEdito_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.Dita = txtDita.Text.Trim();
            ushtrimet.Ora = txtOra.Text.Trim();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.Update(ushtrimet);
        }

        private void BtnFshij_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.FshijMeID(ushtrimet);
        }

        private void BtnShfaqTeGjitha_Click(object sender, EventArgs e)
        {
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            dgdMbushUshtrime.DataSource = ushtrimetDAL.GetAll();
        }
    }
}
