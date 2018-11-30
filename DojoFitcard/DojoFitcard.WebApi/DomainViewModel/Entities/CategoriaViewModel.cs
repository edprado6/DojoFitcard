using System.ComponentModel.DataAnnotations;

namespace DojoFitcard.WebApi.DomainViewModel.Entities
{
    public class CategoriaViewModel : EntidadeBaseViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }
    }
}