using System;

namespace DojoFitcard.WebApi.DomainViewModel.Entities
{
    public abstract class EntidadeBaseViewModel
    {       
        public string Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? UltimaAtualizacao { get; set; }

        public bool Ativo { get; set; }

        public bool Excluido { get; set; }

        public DateTime? DataExclusao { get; set; }
    }
}