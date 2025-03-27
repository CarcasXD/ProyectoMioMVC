using System.ComponentModel.DataAnnotations;
namespace ProyectoMioMVC.Models
{
    public class marcas
    {
        [Key]
        [Display(Name = "ID")]
        public int id_marcas { get; set; }
        [Required]
        [Display(Name = "Nombre de marca")]
        public string? nombre_marca { get; set; }
        [Display(Name = "Estado")]
        public string? estados {  get; set; }
    }
}
