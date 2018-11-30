using DojoFitcard.WebApi.DomainViewModel.Validations;
using System.ComponentModel.DataAnnotations;

namespace DojoFitcard.WebApi.DomainViewModel.Entities
{
    public class EstabelecimentoViewModel : EntidadeBaseViewModel
    {
        [Required]
        public string RazaoSocial { get; set; }

        [Required]
        public string NomeFantasia { get; set; }

        [Required]
        [CustomValidationCNPJ(ErrorMessage = "CNPJ inválido")]
        public string CNPJ { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Bairro { get; set; }

        public string Complemento { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2)]
        public string Estado { get; set; }

        [Required]       
        public string Ddd { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string CategoriaId { get; set; }

        public virtual CategoriaViewModel Categoria { get; set; }        
    }
}