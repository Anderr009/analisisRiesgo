
using WinFormsApp1.Controller;

namespace WinFormsApp1
{
    partial class Fase1
    {
        private RiesgoCtrl riesgoCtrl = new RiesgoCtrl();
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        //metodos 
        public void setFecha()
        {
            DateTime hoy = DateTime.Now;
            txtFecha.Text = hoy + "";
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fase1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            txtActivo = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            txtRiesgo = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            txtDamage = new TextBox();
            label8 = new Label();
            panel4 = new Panel();
            txtAnalista = new TextBox();
            label9 = new Label();
            panel5 = new Panel();
            txtFecha = new TextBox();
            label10 = new Label();
            panel6 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(288, 26);
            label1.Name = "label1";
            label1.Size = new Size(164, 54);
            label1.TabIndex = 1;
            label1.Text = "Home ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(288, 78);
            label2.Name = "label2";
            label2.Size = new Size(203, 43);
            label2.TabIndex = 2;
            label2.Text = "Furnishings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(10, 173);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(350, 32);
            label3.TabIndex = 0;
            label3.Text = "DEPARTAMENTO DE RIESGOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(386, 169);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 4;
            label4.Text = "Ficha Tecnica ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(386, 187);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 5;
            label5.Text = "Analisis de Riesgos";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtActivo);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(10, 272);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 111);
            panel1.TabIndex = 6;
            // 
            // txtActivo
            // 
            txtActivo.AcceptsTab = true;
            txtActivo.BorderStyle = BorderStyle.None;
            txtActivo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtActivo.Location = new Point(3, 23);
            txtActivo.Margin = new Padding(3, 2, 3, 2);
            txtActivo.Multiline = true;
            txtActivo.Name = "txtActivo";
            txtActivo.Size = new Size(195, 83);
            txtActivo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(111, 19);
            label6.TabIndex = 7;
            label6.Text = "ACTIVO/BIEN:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtRiesgo);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(228, 272);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 111);
            panel2.TabIndex = 7;
            // 
            // txtRiesgo
            // 
            txtRiesgo.AcceptsTab = true;
            txtRiesgo.BorderStyle = BorderStyle.None;
            txtRiesgo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRiesgo.Location = new Point(3, 23);
            txtRiesgo.Margin = new Padding(3, 2, 3, 2);
            txtRiesgo.Multiline = true;
            txtRiesgo.Name = "txtRiesgo";
            txtRiesgo.Size = new Size(195, 83);
            txtRiesgo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 7;
            label7.Text = "RIESGO:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txtDamage);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(447, 272);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(201, 111);
            panel3.TabIndex = 8;
            // 
            // txtDamage
            // 
            txtDamage.AcceptsTab = true;
            txtDamage.BorderStyle = BorderStyle.None;
            txtDamage.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDamage.Location = new Point(3, 23);
            txtDamage.Margin = new Padding(3, 2, 3, 2);
            txtDamage.Multiline = true;
            txtDamage.Name = "txtDamage";
            txtDamage.Size = new Size(195, 83);
            txtDamage.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(3, 4);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 7;
            label8.Text = "DAÑO:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txtAnalista);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(10, 221);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(418, 37);
            panel4.TabIndex = 9;
            // 
            // txtAnalista
            // 
            txtAnalista.AcceptsTab = true;
            txtAnalista.BorderStyle = BorderStyle.None;
            txtAnalista.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnalista.Location = new Point(113, 11);
            txtAnalista.Margin = new Padding(3, 2, 3, 2);
            txtAnalista.Name = "txtAnalista";
            txtAnalista.Size = new Size(298, 19);
            txtAnalista.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(3, 11);
            label9.Name = "label9";
            label9.Size = new Size(88, 19);
            label9.TabIndex = 7;
            label9.Text = "ANALISTA:";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(txtFecha);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(447, 221);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(201, 37);
            panel5.TabIndex = 10;
            // 
            // txtFecha
            // 
            txtFecha.AcceptsTab = true;
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFecha.Location = new Point(81, 11);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(115, 19);
            txtFecha.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(3, 11);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 7;
            label10.Text = "FECHA:";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Location = new Point(539, 169);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(108, 35);
            panel6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(539, 41);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(83, 22);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(539, 67);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(83, 22);
            button2.TabIndex = 13;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(539, 94);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(83, 22);
            button3.TabIndex = 14;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Fase1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 403);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Fase1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private TextBox txtActivo;
        private Label label6;
        private Panel panel2;
        private TextBox txtRiesgo;
        private Label label7;
        private Panel panel3;
        private TextBox txtDamage;
        private Label label8;
        private Panel panel4;
        private TextBox txtAnalista;
        private Label label9;
        private Panel panel5;
        private TextBox txtFecha;
        private Label label10;
        private Panel panel6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}