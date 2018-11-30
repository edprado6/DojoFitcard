using System;

namespace DojoFitcard.Domain.Entities
{
    public abstract class EntidadeBase
    {
        //public EntidadeBase()
        //{
        //    Id = Guid.NewGuid().ToString();
        //}
       
        public string Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? UltimaAtualizacao { get; set; }

        public bool Ativo { get; set; }

        public bool Excluido { get; set; }

        public DateTime? DataExclusao { get; set; }
    }
}
