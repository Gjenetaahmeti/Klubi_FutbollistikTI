using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_Futbollistik.BO;
using System.Threading;

namespace Klubi_I_Futbollit
{
    public partial class Mirsevini : Form
    {
        public Mirsevini()
        {
            InitializeComponent();
        }
        Thread th;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string emri = "Arnis";
            string mbiemri = "Hasani";
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value >35)
            {
                lblUsername.Text = emri;
                if (circularProgressBar1.Value>45)
                {
                    lblUsername.Text = " " + mbiemri;
                    if (circularProgressBar1.Value>55)
                    {
                        lblUsername.Text = "";
                        lblUsername.Text = emri + " " + mbiemri;
                        if (circularProgressBar1.Value==100)
                        {
                            timer1.Stop();
                            this.Close();
                            th = new Thread(HapeFormen);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }

                }

            }
        }

        private void HapeFormen()
        {
            Application.Run(new Administratori_Kryesor.Dashboard());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity==0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void Mirsevini_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start(); 
        }
    }
}
