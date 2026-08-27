namespace CodesarrolloApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvAlumnos = new DataGridView();
            lbDisponibles = new ListBox();
            cmbSeleccionados = new ComboBox();
            btnOrdenar = new Button();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnOrdenarInverso = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 171);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(625, 341);
            dgvAlumnos.TabIndex = 0;
            // 
            // lbDisponibles
            // 
            lbDisponibles.FormattingEnabled = true;
            lbDisponibles.Location = new Point(13, 567);
            lbDisponibles.Name = "lbDisponibles";
            lbDisponibles.Size = new Size(175, 104);
            lbDisponibles.TabIndex = 1;
            lbDisponibles.MouseDoubleClick += lbDisponibles_MouseDoubleClick;
            // 
            // cmbSeleccionados
            // 
            cmbSeleccionados.FormattingEnabled = true;
            cmbSeleccionados.Location = new Point(194, 567);
            cmbSeleccionados.Name = "cmbSeleccionados";
            cmbSeleccionados.Size = new Size(175, 28);
            cmbSeleccionados.TabIndex = 2;
            cmbSeleccionados.SelectedIndexChanged += cmbSeleccionados_SelectedIndexChanged;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(12, 123);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(56, 29);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "A - Z";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(375, 567);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(262, 104);
            txtDescripcion.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.Location = new Point(496, 120);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(141, 35);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar alumno";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 544);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 6;
            label1.Text = "Disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 544);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Seleccionados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 544);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Descripción";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Codesarrollo_logo;
            pictureBox1.Location = new Point(183, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 100);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 10;
            label4.Text = "Ordenar nombres:";
            // 
            // btnOrdenarInverso
            // 
            btnOrdenarInverso.Location = new Point(85, 123);
            btnOrdenarInverso.Name = "btnOrdenarInverso";
            btnOrdenarInverso.Size = new Size(56, 29);
            btnOrdenarInverso.TabIndex = 12;
            btnOrdenarInverso.Text = "Z - A";
            btnOrdenarInverso.UseVisualStyleBackColor = true;
            btnOrdenarInverso.Click += btnOrdenarInverso_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 683);
            Controls.Add(btnOrdenarInverso);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(btnOrdenar);
            Controls.Add(cmbSeleccionados);
            Controls.Add(lbDisponibles);
            Controls.Add(dgvAlumnos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Lista de alumnos";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private ListBox lbDisponibles;
        private ComboBox cmbSeleccionados;
        private Button btnOrdenar;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnOrdenarInverso;
    }
}
