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
            ConfigurarListas();
            CargarDatosIniciales();
        }

        private void ConfigurarListas()
        {
            listaTodosLosAlumnos = new BindingList<Alumno>();
            listaDisponibles = new BindingList<Alumno>();
            listaSeleccionados = new BindingList<Alumno>();

            // Enlazar las listas a los controles visuales
            dgvAlumnos.DataSource = listaTodosLosAlumnos;

            lbDisponibles.DataSource = listaDisponibles;
            lbDisponibles.DisplayMember = "Nombre"; // Mostramos el nombre

            cmbSeleccionados.DataSource = listaSeleccionados;
            cmbSeleccionados.DisplayMember = "Nombre"; // Mostramos el nombre
        }

        // PUNTO 3: Cargar N elementos (mínimo 6) al iniciar el programa
        private void CargarDatosIniciales()
        {
            var datosPrueba = new[]
            {
                new Alumno { Identificador = 1, Nombre = "Marco Peréz", Activo = true, Descripcion = "Alumno con excelentes calificaciones" },
                new Alumno { Identificador = 2, Nombre = "Pilar Toapanta", Activo = false, Descripcion = "Alumno ha desertado en múltiples ocasiones" },
                new Alumno { Identificador = 3, Nombre = "Adrián Almeida", Activo = true, Descripcion = "Alumno promedio, proceso aprendizaje" },
                new Alumno { Identificador = 4, Nombre = "Marcela Pazmiño", Activo = true, Descripcion = "Alumno regular, requiere refuerzo" },
                new Alumno { Identificador = 5, Nombre = "Arturo Ureña", Activo = true, Descripcion = "Alumno regular, ha desertado en 2 ocasiones" },
                new Alumno { Identificador = 6, Nombre = "Lina Cachago", Activo = false, Descripcion = "Alumno no asiste desde segunda clase" }
            };

            foreach (var alumno in datosPrueba)
            {
                listaTodosLosAlumnos.Add(alumno);

                // PUNTO 4: La lista DISPONIBLES solo contiene ítems activos
                if (alumno.Activo)
                {
                    listaDisponibles.Add(alumno);
                }
            }
        }

        private void lbDisponibles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbDisponibles.SelectedItem is Alumno alumnoSeleccionado)
            {
                // Uso de LINQ para buscar el elemento en la lista original
                var alumnoMover = listaDisponibles.FirstOrDefault(a => a.Identificador == alumnoSeleccionado.Identificador);
                if (alumnoMover != null)
                {
                    // Retirar de disponibles y agregar a seleccionados
                    listaDisponibles.Remove(alumnoMover);
                    listaSeleccionados.Add(alumnoMover);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (Form2 formAgregar = new Form2())
            {
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    Alumno alumnoCreado = formAgregar.NuevoAlumno;

                    // ========================================================
                    // GENERACIÓN AUTOMÁTICA DEL ID (AUTOINCREMENTAL) CON LINQ
                    // ========================================================
                    // Verificamos si hay elementos en la lista. Si los hay, buscamos el ID máximo y le sumamos 1.
                    // Si la lista está vacía, empezamos desde el ID 1.
                    alumnoCreado.Identificador = listaTodosLosAlumnos.Any()
                                                 ? listaTodosLosAlumnos.Max(a => a.Identificador) + 1
                                                 : 1;

                    // Lo agregamos a la lista general
                    listaTodosLosAlumnos.Add(alumnoCreado);

                    // Si está activo, lo agregamos también a la lista de Disponibles
                    if (alumnoCreado.Activo)
                    {
                        listaDisponibles.Add(alumnoCreado);
                    }
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Usamos LINQ para ordenar por nombre de forma ascendente
            var listaOrdenada = listaTodosLosAlumnos.OrderBy(a => a.Nombre).ToList();

            // Limpiamos y volvemos a llenar para refrescar el GridView
            listaTodosLosAlumnos.Clear();
            foreach (var alumno in listaOrdenada)
            {
                listaTodosLosAlumnos.Add(alumno);
            }
        }

        private void cmbSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeleccionados.SelectedItem is Alumno alumnoSeleccionado)
            {
                txtDescripcion.Text = alumnoSeleccionado.Descripcion;
            }
            else
            {
                txtDescripcion.Text = string.Empty; // Limpiar si no hay selección
            }
        }
    }
}
