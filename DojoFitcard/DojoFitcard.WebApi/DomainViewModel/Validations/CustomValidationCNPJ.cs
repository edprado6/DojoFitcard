using DojoFitcard.Infra.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DojoFitcard.WebApi.DomainViewModel.Validations
{
    public class CustomValidationCNPJ : ValidationAttribute, IClientValidatable
    {
        public CustomValidationCNPJ()
        {

        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = FormatErrorMessage(null),
                ValidationType = "customvalidationcnpj"
            };
        }

        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return true;

            bool valido = HelperCNPJ.CnpjIsValid(value.ToString());
            return valido;
        }
    }
}