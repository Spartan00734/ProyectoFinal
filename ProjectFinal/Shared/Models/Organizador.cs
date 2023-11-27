using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Shared.Models
{
    public class Organizador
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe escribir el nombre del organizador")]
        [StringLength(100, ErrorMessage = "El nombre del organizador no es válido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe escribir el correo del videojuego")]
        [EmailAddress(ErrorMessage = "El correo debe ser válido")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "Debe escribir un número de teléfono")]
        [Phone(ErrorMessage = "El teléfono debe ser válido")]
        public string? Telefono { get; set; }
        public virtual ICollection<Torneo>? Torneos { get; set; }
    }
}
