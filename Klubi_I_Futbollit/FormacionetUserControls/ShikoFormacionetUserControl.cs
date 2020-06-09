using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_I_Futbollit.BLL;

namespace Klubi_I_Futbollit.FormacionetUserControls
{
    public partial class ShikoFormacionetUserControl : UserControl
    {
        public ShikoFormacionetUserControl()
        {
            InitializeComponent();
            StatusiLojtaritBLL statusiLojtarit = new StatusiLojtaritBLL();
            radGridView1.DataSource = statusiLojtarit.ShfaqListenEStatuseveTeLojtarit();
        }
    }
}
