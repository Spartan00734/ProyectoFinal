using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Shared.Models
{
    public class Juego
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe escribir el nombre del videojuego")]
        [StringLength(100, ErrorMessage = "El nombre del juego no es válido")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe escribir la categoría del videojuego")]
        [StringLength(50, ErrorMessage = "El nombre de la categoría no es válido")]
        public string? Categoria { get; set; }
        [Required(ErrorMessage = "Debe escribir la plataforma compatible del juego")]
        [StringLength(30, ErrorMessage = "La plataforma no es válida")]
        public string? Plataforma { get; set; }
    }
}
