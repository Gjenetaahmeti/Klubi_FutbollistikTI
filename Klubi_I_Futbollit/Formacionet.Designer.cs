namespace Klubi_I_Futbollit
{
    partial class Formacionet
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFormacioni = new System.Windows.Forms.TextBox();
            this.btnRegjistroFormacion = new System.Windows.Forms.Button();
            this.dgdmbushFormacion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoli = new System.Windows.Forms.TextBox();
            this.txtNrFanelles = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdmbushFormacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lojtari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formacioni";
            // 
            // txtFormacioni
            // 
            this.txtFormacioni.Location = new System.Drawing.Point(103, 64);
            this.txtFormacioni.Name = "txtFormacioni";
            this.txtFormacioni.Size = new System.Drawing.Size(100, 20);
            this.txtFormacioni.TabIndex = 3;
            // 
            // btnRegjistroFormacion
            // 
            this.btnRegjistroFormacion.Location = new System.Drawing.Point(236, 64);
            this.btnRegjistroFormacion.Name = "btnRegjistroFormacion";
            this.btnRegjistroFormacion.Size = new System.Drawing.Size(115, 23);
            this.btnRegjistroFormacion.TabIndex = 4;
            this.btnRegjistroFormacion.Text = "Regjistro Formacion";
            this.btnRegjistroFormacion.UseVisualStyleBackColor = true;
            // 
            // dgdmbushFormacion
            // 
            this.dgdmbushFormacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdmbushFormacion.Location = new System.Drawing.Point(36, 193);
            this.dgdmbushFormacion.Name = "dgdmbushFormacion";
            this.dgdmbushFormacion.Size = new System.Drawing.Size(707, 245);
            this.dgdmbushFormacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Roli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nr Fanelles";
            // 
            // txtRoli
            // 
            this.txtRoli.Location = new System.Drawing.Point(103, 98);
            this.txtRoli.Name = "txtRoli";
            this.txtRoli.Size = new System.Drawing.Size(100, 20);
            this.txtRoli.TabIndex = 8;
            // 
            // txtNrFanelles
            // 
            this.txtNrFanelles.Location = new System.Drawing.Point(103, 137);
            this.txtNrFanelles.Name = "txtNrFanelles";
            this.txtNrFanelles.Size = new System.Drawing.Size(100, 20);
            this.txtNrFanelles.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Formacionet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNrFanelles);
            this.Controls.Add(this.txtRoli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgdmbushFormacion);
            this.Controls.Add(this.btnRegjistroFormacion);
            this.Controls.Add(this.txtFormacioni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formacionet";
            this.Text = "Formacionet";
            ((System.ComponentModel.ISupportInitialize)(this.dgdmbushFormacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFormacioni;
        private System.Windows.Forms.Button btnRegjistroFormacion;
        private System.Windows.Forms.DataGridView dgdmbushFormacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoli;
        private System.Windows.Forms.TextBox txtNrFanelles;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}