namespace CodesarrolloApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            txtNombre = new TextBox();
            chkActivo = new CheckBox();
            txtDescripcion = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(12, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(401, 39);
            txtNombre.TabIndex = 0;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActivo.Location = new Point(125, 298);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(18, 17);
            chkActivo.TabIndex = 2;
            chkActivo.TextAlign = ContentAlignment.MiddleRight;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(12, 168);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(401, 88);
            txtDescripcion.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 16F);
            btnCancelar.Location = new Point(22, 401);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(176, 49);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.Control;
            btnConfirmar.Font = new Font("Segoe UI", 16F);
            btnConfirmar.Location = new Point(226, 401);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(176, 49);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(131, 38);
            label1.TabIndex = 6;
            label1.Text = "Nombre*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 287);
            label3.Name = "label3";
            label3.Size = new Size(93, 38);
            label3.TabIndex = 8;
            label3.Text = "Activo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(174, 38);
            label4.TabIndex = 9;
            label4.Text = "Descripción*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(98, 344);
            label2.Name = "label2";
            label2.Size = new Size(228, 17);
            label2.TabIndex = 10;
            label2.Text = "Todos los valores con * son obligatorios";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 492);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripcion);
            Controls.Add(chkActivo);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Agregar alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox textBox2;
        private CheckBox chkActivo;
        private TextBox txtDescripcion;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}