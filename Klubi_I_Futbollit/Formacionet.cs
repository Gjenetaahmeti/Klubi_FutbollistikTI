using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Klubi_I_Futbollit
{
    public partial class Formacionet : Form
    {
        public Formacionet()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=Gjeneta;Integrated Security=True");
            sqlcon.Open();
            SqlCommand command = new SqlCommand("usp_MerrLojtart", sqlcon);
            SqlDataAdapter d = new SqlDataAdapter("usp_MerrLojtart", sqlcon);
            DataSet dt = new DataSet();
            d.Fill(dt);
            if (dt.Tables[0].Rows.Count>0)
            {
                comboBox1.DataSource = dt.Tables[0];
                comboBox1.DisplayMember = "Emri";
            }
            else
            {
                MessageBox.Show("Asnje lojtar nuk eshte gjetur");
            }
        }
    }
}
