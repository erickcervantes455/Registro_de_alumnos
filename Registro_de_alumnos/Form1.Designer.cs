namespace Registro_de_alumnos
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
            txtmatricula = new Label();
            textBoxmatricula = new TextBox();
            txtnombre = new Label();
            txtgrupo = new Label();
            lbespecialidad = new Label();
            textBoxnombre = new TextBox();
            textBoxgrupo = new TextBox();
            txtespecialidad = new TextBox();
            btnguardar = new Button();
            btnmostrar = new Button();
            btnlimpiar = new Button();
            dgvalumnos = new DataGridView();
            numericUpDown1 = new NumericUpDown();
            txtsemestre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvalumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtmatricula
            // 
            txtmatricula.AutoSize = true;
            txtmatricula.Location = new Point(48, 48);
            txtmatricula.Name = "txtmatricula";
            txtmatricula.Size = new Size(60, 15);
            txtmatricula.TabIndex = 0;
            txtmatricula.Text = "Matricula:";
            // 
            // textBoxmatricula
            // 
            textBoxmatricula.Location = new Point(133, 48);
            textBoxmatricula.Name = "textBoxmatricula";
            textBoxmatricula.Size = new Size(100, 23);
            textBoxmatricula.TabIndex = 1;
            // 
            // txtnombre
            // 
            txtnombre.AutoSize = true;
            txtnombre.Location = new Point(48, 123);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(54, 15);
            txtnombre.TabIndex = 2;
            txtnombre.Text = "Nombre:";
            // 
            // txtgrupo
            // 
            txtgrupo.AutoSize = true;
            txtgrupo.Location = new Point(371, 97);
            txtgrupo.Name = "txtgrupo";
            txtgrupo.Size = new Size(43, 15);
            txtgrupo.TabIndex = 3;
            txtgrupo.Text = "Grupo:";
            // 
            // lbespecialidad
            // 
            lbespecialidad.AutoSize = true;
            lbespecialidad.Location = new Point(371, 157);
            lbespecialidad.Name = "lbespecialidad";
            lbespecialidad.Size = new Size(75, 15);
            lbespecialidad.TabIndex = 4;
            lbespecialidad.Text = "Especialidad:";
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(133, 120);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(100, 23);
            textBoxnombre.TabIndex = 5;
            // 
            // textBoxgrupo
            // 
            textBoxgrupo.Location = new Point(481, 97);
            textBoxgrupo.Name = "textBoxgrupo";
            textBoxgrupo.Size = new Size(100, 23);
            textBoxgrupo.TabIndex = 6;
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(481, 154);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.Size = new Size(100, 23);
            txtespecialidad.TabIndex = 7;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(701, 47);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 8;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(701, 115);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(75, 23);
            btnmostrar.TabIndex = 9;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(701, 180);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 10;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvalumnos
            // 
            dgvalumnos.AllowUserToAddRows = false;
            dgvalumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvalumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvalumnos.Location = new Point(12, 261);
            dgvalumnos.Name = "dgvalumnos";
            dgvalumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvalumnos.Size = new Size(776, 177);
            dgvalumnos.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(461, 30);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtsemestre
            // 
            txtsemestre.AutoSize = true;
            txtsemestre.Location = new Point(371, 38);
            txtsemestre.Name = "txtsemestre";
            txtsemestre.Size = new Size(58, 15);
            txtsemestre.TabIndex = 13;
            txtsemestre.Text = "Semestre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsemestre);
            Controls.Add(numericUpDown1);
            Controls.Add(dgvalumnos);
            Controls.Add(btnlimpiar);
            Controls.Add(btnmostrar);
            Controls.Add(btnguardar);
            Controls.Add(txtespecialidad);
            Controls.Add(textBoxgrupo);
            Controls.Add(textBoxnombre);
            Controls.Add(lbespecialidad);
            Controls.Add(txtgrupo);
            Controls.Add(txtnombre);
            Controls.Add(textBoxmatricula);
            Controls.Add(txtmatricula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvalumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtmatricula;
        private TextBox textBoxmatricula;
        private Label txtnombre;
        private Label txtgrupo;
        private Label lbespecialidad;
        private TextBox textBoxnombre;
        private TextBox textBoxgrupo;
        private TextBox txtespecialidad;
        private Button btnguardar;
        private Button btnmostrar;
        private Button btnlimpiar;
        private DataGridView dgvalumnos;
        private NumericUpDown numericUpDown1;
        private Label txtsemestre;
    }
}
