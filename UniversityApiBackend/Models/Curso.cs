using System.ComponentModel.DataAnnotations;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Models
{
    public class Curso : BaseEntity
    {
        [Required, MaxLength]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [Required]
        public string PublicoObjetivo { get; set;} = string.Empty;
        [Required]
        public string Ojetivo { get; set; } = string.Empty;
        [Required] 
        public string Requisito { get; set; } = string.Empty;
        [Required]
        public Nivel Nivel { get; set;}
    }

    public enum Nivel
    {
        Basico,
        Intermedio,
        Avanzado
    }
}
