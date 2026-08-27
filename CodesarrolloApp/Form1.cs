using System.ComponentModel;

namespace CodesarrolloApp
{
    public partial class Form1 : Form
    {
        // Usamos BindingList porque actualiza automáticamente la UI (Grid y Listas) al modificar los datos
        private BindingList<Alumno> listaTodosLosAlumnos;
        private BindingList<Alumno> listaDisponibles;
        private BindingList<Alumno> listaSeleccionados;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
