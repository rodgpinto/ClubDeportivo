using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Socio
    {
        
        public E_Socio(int personaId, int carnet, bool fichaInscripcion, bool aptoFisico, bool socioActivo)
        {
            PersonaId = personaId;
            Carnet = carnet;
            FichaInscripcion = fichaInscripcion;
            AptoFisico = aptoFisico;
            SocioActivo = socioActivo;
        }
        public int IdSocio { get; set; }
        public int PersonaId { get; set; }
        public int Carnet { get; set; }
        public bool FichaInscripcion { get; set; }
        public bool AptoFisico { get; set; }
        public bool SocioActivo { get; set; }

    }

}
