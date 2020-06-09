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
using System.Threading;
using Klubi_I_Futbollit.Administratori_Kryesor;

namespace Klubi_I_Futbollit
{
    public partial class LogIn : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=ARNIS;Initial Catalog=Gjeneta;Integrated Security=True");
        Thread th;
        public LogIn()
        {
            InitializeComponent();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //sqlcon.Open();
            //SqlCommand command = new SqlCommand("[dbo].[usp_MerrUsernamedhePass2]", sqlcon);
            //command.CommandType = CommandType.StoredProcedure;
            //SqlDataReader dr = command.ExecuteReader();
            //if (dr.Read())
            //{
            //    if (txtUsername.Text.Equals(dr["EmriIPerdoruesit"].ToString()) && txtPassword.Text.Equals(dr["Fjalekalimi"].ToString()))
            //    {
            //        MessageBox.Show("U loguat me sukses", "Urime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //MenyKryefaqja meny = new MenyKryefaqja();
            //        //meny.ShowDialog();
            //        this.Close();
            //        th = new Thread(HapeFormen);
            //        th.SetApartmentState(ApartmentState.STA);
            //        th.Start();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Deshtoi log-in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //sqlcon.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select RoliID from Personeli where EmriIPerdoruesit='" + txtUsername.Text + " ' and Fjalekalimi='" + txtPassword.Text + "'  ", sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Close();
                        th = new Thread(HapeFormen);
                     th.SetApartmentState(ApartmentState.STA);
                       th.Start();
            }
            else
            {
                  MessageBox.Show("Deshtoi log-in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //(dt.Rows[0][0].ToString()== "1")
        }

        private void HapeFormen()
        {
            Application.Run(new Mirsevini());
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
