﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_Futbollistik.BO;
using Klubi_;
using Klubi_I_Futbollit.BO;
using System.Data.SqlClient;
using Klubi_I_Futbollit.BLL;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoLojtaret : Form
    {

        public MenaxhoLojtaret()
        {
            InitializeComponent();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalekalimi.Text == "" || txtNumriIfanelles.Text == "" 
               || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" ||txtGrupigjakut.Text==""||
               txtShtetesia.Text == "" || txtVendbanimi.Text == "" || txtShtetesia.Text == ""
               || txtEmail.Text == ""||txtPesha.Text==""||txtGjatesia.Text=="")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");

            }
            else
            {
                Lojtari person = new Lojtari();
                person.Emri = txtEmri.Text.Trim();
                person.Mbiemri = txtMbiemri.Text.Trim();
                person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                person.Fjalkalimi = txtFjalekalimi.Text.Trim();
                person.NumriFanelles = int.Parse(txtNumriIfanelles.Text.Trim());
                person.Gjinia = txtGjinia.Text.Trim();
                person.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                person.Vendlindja = txtVendlindja.Text.Trim();
                person.GrupiGjakut = txtGrupigjakut.Text.Trim();
                person.Shteti = txtShtetesia.Text.Trim();
                person.Vendbanimi = txtVendbanimi.Text.Trim();
                person.Telefoni = txtNumriTelefonit.Text.Trim();
                person.Mail = txtEmail.Text.Trim();
                person.Pesha = decimal.Parse(txtPesha.Text.Trim());
                person.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
                LojtariBLL lojtariBLL = new LojtariBLL();
                lojtariBLL.Regjistro(person);

                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtNumriIfanelles.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text= txtShtetesia.Text =
                    txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text = txtPesha.Text = txtGjatesia.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
        private void btnEditoLojtar_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {

                Lojtari person = new Lojtari();
                person.Emri = txtEmri.Text.Trim();
                person.Mbiemri = txtMbiemri.Text.Trim();
                person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                person.Fjalkalimi = txtFjalekalimi.Text.Trim();
                person.NumriFanelles = int.Parse(txtNumriIfanelles.Text.Trim());
                person.Gjinia = txtGjinia.Text.Trim();
                person.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                person.Vendlindja = txtVendlindja.Text.Trim();
                person.GrupiGjakut = txtGrupigjakut.Text.Trim();
                person.Shteti = txtShtetesia.Text.Trim();
                person.Vendbanimi = txtVendbanimi.Text.Trim();
                person.Telefoni = txtNumriTelefonit.Text.Trim();
                person.Mail = txtEmail.Text.Trim();
                person.Pesha = decimal.Parse(txtPesha.Text.Trim());
                person.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
                person.LojtariID = int.Parse(txtShkruajID.Text.Trim());
                LojtariBLL lojtariEditoBll = new LojtariBLL();
                lojtariEditoBll.Edito(person);

                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtNumriIfanelles.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text = txtShtetesia.Text =
                    txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text = txtPesha.Text = txtGjatesia.Text = "";
            }
        }
        private void btnShfaq_Click(object sender, EventArgs e)
        {
            //LojtariDAL obj = new LojtariDAL();
            //dgdMbushLojtar.DataSource = obj.GetAll();

            LojtariBLL lojtariShfaqja = new LojtariBLL();
            dgdMbushLojtar.DataSource = lojtariShfaqja.ShfaqLojtaret();

            txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtNumriIfanelles.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text = txtShtetesia.Text =
                txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text = txtPesha.Text = txtGjatesia.Text = "";
        }
        private void BtnGjejLojtart_Click(object sender, EventArgs e)
        {
            Lojtari lojtar =  new Lojtari();
            lojtar.LojtariID= int.Parse(txtShkruajID.Text.Trim());
            LojtariBLL gjejLojtarin = new LojtariBLL();
            gjejLojtarin.GjejLojtarMeID(lojtar);
            txtEmri.Text = lojtar.Emri.ToString();
            txtMbiemri.Text = lojtar.Mbiemri.ToString();
            txtEmriPerdoruesit.Text = lojtar.EmriIPerdoruesit.ToString();
            txtFjalekalimi.Text = lojtar.Fjalkalimi.ToString();
            txtNumriIfanelles.Text = lojtar.NumriFanelles.ToString();
            txtGjinia.Text = lojtar.Gjinia.ToString();
            txtDitelindja.Text = lojtar.Ditelindja.ToString();
            txtVendlindja.Text = lojtar.Vendlindja.ToString();
            txtGrupigjakut.Text = lojtar.GrupiGjakut.ToString();
            txtShtetesia.Text = lojtar.Shteti.ToString();
            txtVendbanimi.Text = lojtar.Vendbanimi.ToString();
            txtNumriTelefonit.Text = lojtar.Telefoni.ToString();
            txtEmail.Text = lojtar.Mail.ToString();
            txtPesha.Text = lojtar.Pesha.ToString();
            txtGjatesia.Text = lojtar.Gjatesia.ToString();
            btnFshijLojtarin.Visible = true;
            btnEditoLojtar.Visible = true;
            btnRegjistro.Visible = true;
            btnShfaq.Visible = true;

        }
        private void BtnFshijLojtarin_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Lojtari lojtari = new Lojtari();
                lojtari.LojtariID = int.Parse(txtShkruajID.Text.Trim());
                LojtariBLL lojtariBLL = new LojtariBLL();
                lojtariBLL.Fshij(lojtari);

                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtNumriIfanelles.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text = txtShtetesia.Text =
                    txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text = txtPesha.Text = txtGjatesia.Text = "";
            }
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoPersonelin personelin = new Administratori_Kryesor.MenaxhoPersonelin())
            {

                personelin.ShowDialog();
            }
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoTrajner trajneri = new Administratori_Kryesor.MenaxhoTrajner())
            {

                trajneri.ShowDialog();
            }
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoNdeshje ndeshje = new Administratori_Kryesor.MenaxhoNdeshje())
            {

                ndeshje.ShowDialog();
            }
        }

        private void MenaxhoFormacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Formacionet formacionet = new Formacionet())
            {

                formacionet.ShowDialog();
            }
        }

        private void MenaxhoGolashenuesinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoGolashenuesin golashenuesi = new Administratori_Kryesor.MenaxhoGolashenuesin())
            {

                golashenuesi.ShowDialog();
            }
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoDelegat delegat = new Administratori_Kryesor.MenaxhoDelegat())
            {

                delegat.ShowDialog();
            }
        }

        private void MenaxhoKluibnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoKlub klub = new Administratori_Kryesor.MenaxhoKlub())
            {

                klub.ShowDialog();
            }
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(MenyKryefaqja mk =new MenyKryefaqja())
            {
                mk.ShowDialog();
            }
        }

        private void MenaxhoUshtrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoUshtrime menaxhoUshtrime = new MenaxhoUshtrime();
            menaxhoUshtrime.ShowDialog();
        }

        private void MenaxhoVleresimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoVlersimet menaxhoVlersimet = new MenaxhoVlersimet();
            menaxhoVlersimet.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtNumriIfanelles_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGjatesia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDitelindja_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFjalekalimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtEmriPerdoruesit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emriperdoruesit_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNumriTelefonit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtShtetesia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupigjakut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVendlindja_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVendbanimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGjinia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMbiemri_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmri_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
