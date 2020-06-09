﻿using System;
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
    public partial class EditoFormacionUserControl : UserControl
    {
        public EditoFormacionUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
            statusiLojtarit.StatusiID = int.Parse(txtGjejMeIDFormacion.Text.Trim());
            StatusiLojtaritBLL statusiLojtarit1 = new StatusiLojtaritBLL();
            statusiLojtarit1.GjejStatusinELojtaritMeID(statusiLojtarit);

            txtPergjegjes.Text = statusiLojtarit.Pergjegjes;
            txtRezerve.Text = statusiLojtarit.Rezerv;
            txtHuazim.Text = statusiLojtarit.Huazim;
            txtShoqerues.Text = statusiLojtarit.Shoqerues;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                var der2 = comboBox1.SelectedValue.ToString();
                StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
                statusiLojtarit.Pergjegjes = txtPergjegjes.Text.Trim();
                statusiLojtarit.Rezerv = txtRezerve.Text.Trim();
                statusiLojtarit.Huazim = txtHuazim.Text.Trim();
                statusiLojtarit.Shoqerues = txtShoqerues.Text.Trim();
                statusiLojtarit.StatusiID = int.Parse(txtGjejMeIDFormacion.Text.Trim());
                Lojtari lojtari = new Lojtari();
                lojtari.LojtariID = int.Parse(der2);
                StatusiLojtaritBLL statusiLojtaritDAL = new StatusiLojtaritBLL();
                statusiLojtaritDAL.Edito(statusiLojtarit);

                txtPergjegjes.Text = txtHuazim.Text = txtShoqerues.Text = comboBox1.Text = "";
            }
        }
    }
}
