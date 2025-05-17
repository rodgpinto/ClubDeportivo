using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_NoSocio
    {
        public int IdNoSocio { get; set; }
        public int PersonaId { get; set; }
        public bool FichaInscripcion { get; set; }

        public E_NoSocio() { }

        public E_NoSocio(int personaId, bool fichaInscripcion)
        {
            PersonaId = personaId;
            FichaInscripcion = fichaInscripcion;
        }
    }

}
