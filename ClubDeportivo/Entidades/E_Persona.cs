using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Persona
    {
       
        public E_Persona() { }

        public E_Persona(int codigo, string nombre, string apellido, int dni, string direccion, DateTime fechaNacimiento)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }

}
