using System;

namespace Veiculo
{
    public static class ExtensionMethods
    {
        public static int ConverterParaInteiro(this string valor)
        {
            return Convert.ToInt32(valor);
        }
    }
}