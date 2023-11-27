using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Shared.Models
{
    public class Torneo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe escribir el nombre del torneo")]
        [StringLength(50, ErrorMessage = "El nombre del torneo no es válido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe escribir la fecha de inicio del torneo")]
        [StringLength(50, ErrorMessage = "El nombre de la fecha de inicio no es válido")]
        public string? FechaIn { get; set; }
        [Required(ErrorMessage = "Debe escribir los premios del torneo")]
        [StringLength(100, ErrorMessage = "El valor de los premios no es válido")]
        public string? Premios { get; set; }
        public int JuegoId { get; set; }
        public Juego? Juego { get; set; }
        public int OrganizadorId { get; set; }
        public Organizador? Organizador { get; set; }
        public virtual ICollection<Jugador>? Jugadores { get; set; }

    }
}
