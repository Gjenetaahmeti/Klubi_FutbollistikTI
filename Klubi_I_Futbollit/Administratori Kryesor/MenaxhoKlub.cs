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
    public partial class MenaxhoKlub : Form
    {
        public MenaxhoKlub()
        {
            InitializeComponent();
        }

        private void BtnRegjistro_Click(object sender, EventArgs e)
        {
            Klubi klubi = new Klubi();
            klubi.Emertimi = txtEmertimi.Text.Trim();
            klubi.Vendi = txtEmertimi.Text.Trim();
            klubi.Kryetari = txtKyetari.Text.Trim();
            klubi.IThemeluar =DateTime.Parse(dtpDataeThemelimit.Text.Trim());

            KlubiDAL klubiDAL = new KlubiDAL();
            klubiDAL.Shto(klubi);
        }

        private void BtnKerkoKlubMeID_Click(object sender, EventArgs e)
        {
            Klubi kl = new Klubi();
            kl.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());
            KlubiDAL klubiDAL = new KlubiDAL();
            klubiDAL.GjejKlubMeID(kl);
            txtEmertimi.Text = kl.Emertimi;
            txtVendi.Text = kl.Vendi;
            txtKyetari.Text = kl.Kryetari;
            dtpDataeThemelimit.Text = kl.IThemeluar.ToString();



        }

        private void BtnEdito_Click(object sender, EventArgs e)
        {
            Klubi klubi = new Klubi();
            klubi.Emertimi = txtEmertimi.Text.Trim();
            klubi.Vendi = txtEmertimi.Text.Trim();
            klubi.Kryetari = txtKyetari.Text.Trim();
            klubi.IThemeluar = DateTime.Parse(dtpDataeThemelimit.Text.Trim());
            klubi.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());


            KlubiDAL klubiDAL = new KlubiDAL();
            klubiDAL.Update(klubi);
        }

        private void BtnFshijKlub_Click(object sender, EventArgs e)
        {
            Klubi kl = new Klubi();
            kl.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());
            KlubiDAL klubiDAL = new KlubiDAL();
            klubiDAL.FshijMeID(kl);
        }

        private void BtnShfaq_Click(object sender, EventArgs e)
        {
            KlubiDAL klubi = new KlubiDAL();
         

            dgdMbushKlub.DataSource = klubi.GetAll();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja menyKryefaqja = new MenyKryefaqja();
            menyKryefaqja.ShowDialog();
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoPersonelin menaxhoPersonelin = new MenaxhoPersonelin();
            menaxhoPersonelin.ShowDialog();
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret menaxhoLojtaret = new MenaxhoLojtaret();
            menaxhoLojtaret.ShowDialog();
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoTrajner menaxhoTrajner = new MenaxhoTrajner();
            menaxhoTrajner.ShowDialog();
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoNdeshje menaxhoNdeshje = new MenaxhoNdeshje();
            menaxhoNdeshje.ShowDialog();

        }

        private void MenaxhoFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formacionet formacionet = new Formacionet();
            formacionet.ShowDialog();
        }

        private void MenaxhoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoGolashenuesin menaxhoGolashenuesin = new MenaxhoGolashenuesin();
            menaxhoGolashenuesin.ShowDialog();
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }
    }
}
