using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();

            if (logIn.ShowDialog()==DialogResult.OK)
            {
           
                //meu konektu me databaze
                logIn.Close();
            }
            else
            {
                this.Close();
                //Application.Exit();
            }
            RegjistrimiPersonelit r1 = new RegjistrimiPersonelit();
            r1.ShowDialog();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
