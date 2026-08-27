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
            dgvAlumnos = new DataGridView();
            lbDisponibles = new ListBox();
            cmbSeleccionados = new ComboBox();
            btnOrdenar = new Button();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 59);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.Size = new Size(625, 341);
            dgvAlumnos.TabIndex = 0;
            // 
            // lbDisponibles
            // 
            lbDisponibles.FormattingEnabled = true;
            lbDisponibles.Location = new Point(643, 81);
            lbDisponibles.Name = "lbDisponibles";
            lbDisponibles.Size = new Size(150, 104);
            lbDisponibles.TabIndex = 1;
            lbDisponibles.MouseDoubleClick += lbDisponibles_MouseDoubleClick;
            // 
            // cmbSeleccionados
            // 
            cmbSeleccionados.FormattingEnabled = true;
            cmbSeleccionados.Location = new Point(804, 81);
            cmbSeleccionados.Name = "cmbSeleccionados";
            cmbSeleccionados.Size = new Size(151, 28);
            cmbSeleccionados.TabIndex = 2;
            cmbSeleccionados.SelectedIndexChanged += cmbSeleccionados_SelectedIndexChanged;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(12, 13);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(218, 29);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar por orden alfabético";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(643, 232);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 62);
            txtDescripcion.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(819, 371);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 29);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar alumno";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 58);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 6;
            label1.Text = "Disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(804, 58);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Seleccionados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(643, 209);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "Descripción";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 413);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(btnOrdenar);
            Controls.Add(cmbSeleccionados);
            Controls.Add(lbDisponibles);
            Controls.Add(dgvAlumnos);
            Name = "Form1";
            Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
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
    }
}
