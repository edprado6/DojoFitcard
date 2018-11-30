namespace DojoFitcard.WebApi.DomainViewModel.Filters
{
    public class EstabelecimentoFilterViewModel : BaseFilterViewModel
    {
        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string Cnpj { get; set; }

        public bool? Ativo { get; set; }
    }
}