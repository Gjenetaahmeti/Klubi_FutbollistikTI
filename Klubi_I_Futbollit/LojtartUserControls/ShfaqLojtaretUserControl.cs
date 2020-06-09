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

namespace Klubi_I_Futbollit.LojtartUserControls
{
    public partial class ShfaqLojtaretUserControl : UserControl
    {
        public ShfaqLojtaretUserControl()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MbushDataGrid();
        }
        private void MbushDataGrid()
        {
            LojtariBLL lojtariShfaqja = new LojtariBLL();
            datagridShfaqLojtart.DataSource = lojtariShfaqja.ShfaqLojtaret();
        }
    }
}
