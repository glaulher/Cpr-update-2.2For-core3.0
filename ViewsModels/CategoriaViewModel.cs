using System.ComponentModel.DataAnnotations;

namespace Cpr.Web.ViewsModels
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "O campo Categoria é obrigatório.")]
        [Display(Name = "Categoria")]
        public string Name { get; set; }
    }
}