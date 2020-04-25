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
using Klubi_Futbollistik.BO;
using Klubi_I_Futbollit.BLL;


namespace Klubi_I_Futbollit
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Regjistrimi r1 = new Regjistrimi();
            r1.ShowDialog();
        }

  

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
