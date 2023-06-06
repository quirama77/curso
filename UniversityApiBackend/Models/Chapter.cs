using Microsoft.Build.Framework;
using UniversityApiBackend.Models.DataModels;
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models
{
    public class Chapter : BaseEntity
    {
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }=new Curso();
        [System.ComponentModel.DataAnnotations.Required]
        public string List = string.Empty;
    }
}
