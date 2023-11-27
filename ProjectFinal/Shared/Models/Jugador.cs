using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Shared.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe escribir su nombre")]
        [StringLength(50, ErrorMessage = "El nombre del juagdor no es válido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe escribir su edad")]
        [Range(0, 100, ErrorMessage = "La edad debe estar entre 0 y 100")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Debe escribir su lugar de residencia")]
        [StringLength(50, ErrorMessage = "Su lugar de residencia no es válida")]
        public string? Pais_Residencia { get; set; }
        public int TorneoId { get; set; }
        public Torneo? Torneo { get; set; }
    }
}
