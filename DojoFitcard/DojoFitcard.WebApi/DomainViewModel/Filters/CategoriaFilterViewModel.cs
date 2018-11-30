using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DojoFitcard.WebApi.DomainViewModel.Filters
{
    public class CategoriaFilterViewModel : BaseFilterViewModel
    {
        public string Nome { get; set; }

        public bool? Ativo { get; set; }
    }
}