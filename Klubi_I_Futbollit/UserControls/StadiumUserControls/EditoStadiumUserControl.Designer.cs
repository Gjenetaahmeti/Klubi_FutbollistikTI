namespace Klubi_I_Futbollit.UserControls.StadiumUserControls
{
    partial class EditoStadiumUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditoStadiumUserControl));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVendiStadiumit = new System.Windows.Forms.TextBox();
            this.txtEmriStadiumit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGjejStadiumMeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKerko = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 123);
            this.panel2.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(245, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 37);
            this.label3.TabIndex = 58;
            this.label3.Text = "FC PRISHTINA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 95;
            this.button1.Text = "Edito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVendiStadiumit
            // 
            this.txtVendiStadiumit.Location = new System.Drawing.Point(121, 63);
            this.txtVendiStadiumit.Name = "txtVendiStadiumit";
            this.txtVendiStadiumit.Size = new System.Drawing.Size(100, 20);
            this.txtVendiStadiumit.TabIndex = 94;
            // 
            // txtEmriStadiumit
            // 
            this.txtEmriStadiumit.Location = new System.Drawing.Point(121, 21);
            this.txtEmriStadiumit.Name = "txtEmriStadiumit";
            this.txtEmriStadiumit.Size = new System.Drawing.Size(100, 20);
            this.txtEmriStadiumit.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Vendi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Emertimi ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEmriStadiumit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtVendiStadiumit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(273, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 100);
            this.panel1.TabIndex = 96;
            this.panel1.Visible = false;
            // 
            // txtGjejStadiumMeID
            // 
            this.txtGjejStadiumMeID.Location = new System.Drawing.Point(544, 62);
            this.txtGjejStadiumMeID.Name = "txtGjejStadiumMeID";
            this.txtGjejStadiumMeID.Size = new System.Drawing.Size(100, 20);
            this.txtGjejStadiumMeID.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(294, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Kerko me ID per te Edituar";
            // 
            // btnKerko
            // 
            this.btnKerko.Location = new System.Drawing.Point(544, 88);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(100, 34);
            this.btnKerko.TabIndex = 96;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // EditoStadiumUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.txtGjejStadiumMeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditoStadiumUserControl";
            this.Size = new System.Drawing.Size(1000, 470);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVendiStadiumit;
        private System.Windows.Forms.TextBox txtEmriStadiumit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGjejStadiumMeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKerko;
    }
}
