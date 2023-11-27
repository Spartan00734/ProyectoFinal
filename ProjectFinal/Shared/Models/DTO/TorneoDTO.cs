using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Shared.Models.DTO
{
    public class TorneoDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? FechaIn { get; set; }
        public string? Premios { get; set; }
        public string? NombreJuegos { get; set; }
        public string? NombreOrganizador { get; set; }
    }
}
