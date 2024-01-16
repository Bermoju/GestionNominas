using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV1
{
    public class Nomina
    {
        // MIEMBROS PRIVADOS DE LA CLASE
        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horas;
        private float _salarioHora;

        // PROPIEDADES
        /// <summary>
        /// Nombre del Empleado
        /// </summary>
        public string NombreEmpleado
        {
            get
            {
                // Control de Contenido
                if (string.IsNullOrEmpty(_nombre)) throw new Exception("Nombre del Trabajador no establecido");
                // Devolución del valor
                return _nombre;
            }
            set 
            {
                // Validación de los Datos a Establecer
                if (string.IsNullOrEmpty(value)) throw new Exception("El nombre del trabajador no puedes ser null o la cadena vacía");
                
                // Establecimiento del valor al miembro privado
                _nombre = value;

            }
        }
        public strin ApellidosEmpleado{
            get{

                retun _apellidos;
            }
            set{
                _apellidos = value;
            }
        }
    }
}
