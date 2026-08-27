using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodesarrolloApp
{
    public partial class Form2 : Form
    {
        // Propiedad pública para que el Form1 pueda leer el alumno creado
        public Alumno NuevoAlumno;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // ==========================================
            // 1. VALIDACIÓN DE CAMPOS VACÍOS
            // ==========================================
            List<string> camposFaltantes = new List<string>();

            // string.IsNullOrWhiteSpace verifica que no esté vacío y que no sean solo espacios
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                camposFaltantes.Add("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                camposFaltantes.Add("Descripción");
            }

            // Si la lista de campos faltantes tiene elementos, mostramos el error
            if (camposFaltantes.Count > 0)
            {
                // Unimos los elementos con " y " (ej: "Nombre y Descripción" o solo "Nombre")
                string mensaje = "Debe ingresar los datos: " + string.Join(" y ", camposFaltantes);

                MessageBox.Show(mensaje, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // El return detiene la ejecución del código aquí, así no se cierra la ventana
                return;
            }

            this.NuevoAlumno = new Alumno
            {
                Nombre = txtNombre.Text,
                Activo = chkActivo.Checked,
                Descripcion = txtDescripcion.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
