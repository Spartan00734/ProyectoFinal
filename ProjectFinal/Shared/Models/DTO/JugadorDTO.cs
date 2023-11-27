using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Shared.Models.DTO
{
    public class JugadorDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Pais_Residencia { get; set; }
        public string? NombreJuegos { get; set; }
        public string? NombreOrganizador { get; set; }
        public string? NombreTorneo { get; set; }

    }
}
