using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DojoFitcard.WebApi.DomainViewModel.Filters
{
    public class BaseFilterViewModel
    {
        public int RegistrosPorPagina { get; set; }

        public int Pagina { get; set; }
    }
}