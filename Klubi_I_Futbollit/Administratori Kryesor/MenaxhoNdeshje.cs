﻿using System;
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
    public partial class MenaxhoNdeshje : Form
    {
        public MenaxhoNdeshje()
        {
            InitializeComponent();
        }

        private void btnRegjistroNdeshje_Click(object sender, EventArgs e)
        {
            Ndeshja ndeshja = new Ndeshja();
            ndeshja.dataNdeshjes = DateTime.Parse(dtData.Text.Trim());
            ndeshja.Sezoni = txtSezoni.Text.Trim();
            ndeshja.RaportiAmbulances = txtRaportiAmbulances.Text.Trim();
            ndeshja.RaportiPolicor = txtRaportiPolicis.Text.Trim();
            NdeshjaDAL ndeshjaDAL = new NdeshjaDAL();
            ndeshjaDAL.Shto(ndeshja);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Ndeshja ndeshja = new Ndeshja();
            ndeshja.NdeshjaID = int.Parse(txtShkruajID.Text.Trim());
            NdeshjaDAL dali = new NdeshjaDAL();
            dali.MerrNdeshjeMeID(ndeshja);
            dtData.Text = ndeshja.dataNdeshjes.ToString();
            txtSezoni.Text = ndeshja.Sezoni;
            txtRaportiAmbulances.Text = ndeshja.RaportiAmbulances;
            txtRaportiPolicis.Text = ndeshja.RaportiPolicor;
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            Ndeshja ndeshja = new Ndeshja();
            ndeshja.dataNdeshjes = DateTime.Parse(dtData.Text.Trim());
            ndeshja.Sezoni = txtSezoni.Text.Trim();
            ndeshja.RaportiAmbulances = txtRaportiAmbulances.Text.Trim();
            ndeshja.RaportiPolicor = txtRaportiPolicis.Text.Trim();
            ndeshja.NdeshjaID = int.Parse(txtShkruajID.Text);
            NdeshjaDAL ndeshjaDAL = new NdeshjaDAL();
            ndeshjaDAL.Update(ndeshja);
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            Ndeshja ndeshja = new Ndeshja();
            ndeshja.NdeshjaID = int.Parse(txtShkruajID.Text.Trim());
            NdeshjaDAL dali = new NdeshjaDAL();
            dali.Fshij(ndeshja);
        }

        private void btnShfaqi_Click(object sender, EventArgs e)
        {
            NdeshjaDAL dali = new NdeshjaDAL();
            dgdMbushNdeshje.DataSource = dali.GetAll();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja mk = new MenyKryefaqja();
            mk.ShowDialog();
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoPersonelin personelin = new MenaxhoPersonelin();
            personelin.ShowDialog();
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret lojtaret = new MenaxhoLojtaret();
            lojtaret.ShowDialog();
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoTrajner mt = new MenaxhoTrajner();
            mt.ShowDialog();
        }

        private void MenaxhoFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formacionet f = new Formacionet();
            f.ShowDialog();
        }

        private void MneaxhoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoGolashenuesin menaxhoGolashenuesin = new MenaxhoGolashenuesin();
            menaxhoGolashenuesin.ShowDialog();
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }

        private void MenaxhoKlubinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoKlub menaxhoKlub = new MenaxhoKlub();
            menaxhoKlub.ShowDialog();
        }
    }
}
