using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void CmbGjuha_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            if (cmbGjuha.Text == "English")
            {
                Assembly a = Assembly.Load("KlubiFutbollistik");
                ResourceManager rm = new ResourceManager("KlubiFutbollistik.Lang.langres", a);

                lblUsername.Text = rm.GetString("lblUsername", ci);
                lblPassword.Text = rm.GetString("lblPassword", ci);
                btnLogin.Text = rm.GetString("btnLogin", ci);
            }
            if (cmbGjuha.Text == "Shqip")
            {
                Assembly a = Assembly.Load("KlubiFutbollistik");
                ResourceManager rm = new ResourceManager("KlubiFutbollistik.Lang.langresShqip", a);

                lblUsername.Text = rm.GetString("lblUsername", ci);
                lblPassword.Text = rm.GetString("lblPassword", ci);
                btnLogin.Text = rm.GetString("btnLogin", ci);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            

            CultureInfo ci = new CultureInfo("en-US");
            if (cmbGjuha.Text == "English")
            {
                Assembly a = Assembly.Load("KlubiFutbollistik");
                ResourceManager rm = new ResourceManager("KlubiFutbollistik.Lang.langres", a);
                lblUsername.Text = rm.GetString("lblUsername", ci);
                lblPassword.Text = rm.GetString("lblPassword", ci);
                btnLogin.Text = rm.GetString("btnLogin", ci);

            }
            if (cmbGjuha.Text == "Shqip")
            {
                Assembly a = Assembly.Load("KlubiFutbollistik");
                ResourceManager rm = new ResourceManager("KlubiFutbollistik.Lang.langresShqip", a);

                lblUsername.Text = rm.GetString("lblUsername", ci);
                lblPassword.Text = rm.GetString("lblPassword", ci);
                btnLogin.Text = rm.GetString("btnLogin", ci);

            }

           
        }
    }
}
