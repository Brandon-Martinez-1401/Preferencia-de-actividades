namespace Preferencia_de_actividades
{
    partial class Form1
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNombre = new TextBox();
            panel1 = new Panel();
            chkLectura = new CheckBox();
            chkProgra = new CheckBox();
            chkArte = new CheckBox();
            chkMusica = new CheckBox();
            chkDeportes = new CheckBox();
            panel2 = new Panel();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 23);
            txtNombre.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(chkLectura);
            panel1.Controls.Add(chkProgra);
            panel1.Controls.Add(chkArte);
            panel1.Controls.Add(chkMusica);
            panel1.Controls.Add(chkDeportes);
            panel1.Location = new Point(12, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 190);
            panel1.TabIndex = 2;
            // 
            // chkLectura
            // 
            chkLectura.AutoSize = true;
            chkLectura.Location = new Point(27, 120);
            chkLectura.Name = "chkLectura";
            chkLectura.Size = new Size(65, 19);
            chkLectura.TabIndex = 4;
            chkLectura.Text = "Lectura";
            chkLectura.UseVisualStyleBackColor = true;
            chkLectura.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // chkProgra
            // 
            chkProgra.AutoSize = true;
            chkProgra.Location = new Point(27, 95);
            chkProgra.Name = "chkProgra";
            chkProgra.Size = new Size(95, 19);
            chkProgra.TabIndex = 3;
            chkProgra.Text = "Progrmacion";
            chkProgra.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Location = new Point(27, 70);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(48, 19);
            chkArte.TabIndex = 2;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(27, 45);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(64, 19);
            chkMusica.TabIndex = 1;
            chkMusica.Text = "Musica";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(27, 20);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(73, 19);
            chkDeportes.TabIndex = 0;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Location = new Point(403, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 179);
            panel2.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Precencial";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 129);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(66, 19);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "En linea";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 83);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hibrida";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 50);
            label2.Name = "label2";
            label2.Size = new Size(199, 15);
            label2.TabIndex = 5;
            label2.Text = "Actidades favoritas(opcion multiple)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(420, 59);
            label3.Name = "label3";
            label3.Size = new Size(207, 15);
            label3.TabIndex = 6;
            label3.Text = "Modalidad preferida(solo una opcion)";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(403, 313);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 7;
            button1.Text = "Mostrar resumen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(586, 313);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 345);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Resumen :";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 374);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(631, 167);
            textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 566);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Preferncia de actividades";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Panel panel1;
        private CheckBox chkLectura;
        private CheckBox chkProgra;
        private CheckBox chkArte;
        private CheckBox chkMusica;
        private CheckBox chkDeportes;
        private Panel panel2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
    }
}
