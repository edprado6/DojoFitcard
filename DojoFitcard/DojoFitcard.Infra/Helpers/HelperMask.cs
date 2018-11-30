namespace DojoFitcard.Infra.Helpers
{
    public class HelperMask
    {
        public static string RetiraMascaraCNPJ(string cnpj)
        {
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace("_", "");

            return cnpj;
        }
    }
}
