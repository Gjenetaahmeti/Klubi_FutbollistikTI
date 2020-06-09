using Klubi_;
using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;
using Klubi_I_Futbollit.DelegatUserControls;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class AdministratoriDashboard : Form
    {
        public AdministratoriDashboard()
        {
            InitializeComponent();
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0}({1:P})", chartpoint.Y, chartpoint.Participation);
      

        private void AdministratoriDashboard_Load(object sender, EventArgs e)
        {
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GolashenuesiDAL obj = new GolashenuesiDAL();
            obj.GetAllByList();
            SeriesCollection series = new SeriesCollection();
            foreach (var item in Golashenuesit.obj)
            {
                series.Add(new PieSeries() { Title = item.lojtariID.ToString(), Values = new ChartValues<int> { item.NumriGolave }, DataLabels = true, LabelPoint = labelPoint });
            }
            pieChart1.Series = series;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            pieChart1.Visible = true;
            button1.Visible = true;
        }

        private void menaxhoNdeshjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void regjistroLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition1.ShowSync(regjistroLojtarUserControl2);
        }

        private void editoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition1.ShowSync(editoLojtarUserControl2);
        }

        private void fshijLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition1.ShowSync(fshijLojtartUserControl2);
        }

        private void shikoLojtartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition1.ShowSync(shfaqLojtaretUserControl2);
        }

        private void regjistroDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition1.ShowSync(regjistroDelegatUserControl2);
        }

        private void editoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition1.ShowSync(editoDelegatUserControl2);
        }

        private void fshijDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition1.ShowSync(fshijDelegatUserControl2);
        }

        private void shikoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
        }

        private void regjistroFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition1.ShowSync(regjistroFormacionUserControl2);
        }

        private void editoFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
            bunifuTransition1.ShowSync(editoFormacionUserControl2);
        }

        private void fshijFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition1.ShowSync(fshijFormacionUserControl2);
        }

        private void shikoFormacionetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
        }

        private void regjistroGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
        }

        private void editoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
        }

        private void fshijGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
        }

        private void shikoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(regjistroLojtarUserControl2);
            bunifuTransition2.HideSync(editoLojtarUserControl2);
            bunifuTransition2.HideSync(fshijLojtartUserControl2);
            bunifuTransition2.HideSync(regjistroDelegatUserControl2);
            bunifuTransition2.HideSync(editoDelegatUserControl2);
            bunifuTransition2.HideSync(fshijDelegatUserControl2);
            bunifuTransition2.HideSync(regjistroFormacionUserControl2);
            bunifuTransition2.HideSync(editoFormacionUserControl2);
            bunifuTransition2.HideSync(fshijFormacionUserControl2);
        }

        private void regjistroTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
