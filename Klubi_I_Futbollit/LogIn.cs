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
using System.Data.SqlClient;

namespace Klubi_I_Futbollit
{
    public partial class LogIn : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");

        public LogIn()
        {
            InitializeComponent();
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            sqlcon.Open();
            SqlCommand command = new SqlCommand("usp_MerrUsernamedhePass", sqlcon);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {


                if (txtUsername.Text.Equals(dr["EmriIPerdoruesit"].ToString()) && txtPassword.Text.Equals(dr["Fjalekalimi"].ToString()))
                {
                    MessageBox.Show("U loguat me sukses", "Urime", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenyKryefaqja meny = new MenyKryefaqja();
                    meny.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Deshtoi log-in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            sqlcon.Close();

        }

  

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }

        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
