using System;
using System.Collections.Generic;
using System.Text;

namespace CodesarrolloApp
{
    internal class Alumno
    {
        // Propiedades solicitadas en el punto 2
        // Al ser publicas se pone con mayuscula la primera letra de cada palabra
        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }
    }
}
