using System.Text;

namespace App.Core
{
    public static class Common
    {
        public static string ConcatenarComMais(params string[] valores)
        {
            var resultado = string.Empty;
            
            foreach (var valor in valores)
            {
                resultado += valor;
            }
            
            return resultado;
        }

        public static string ConcatenarComStringBuilder(params string[] valores)
        {
            var resultado = new StringBuilder();

            foreach (var valor in valores)
            {
                resultado.Append(valor);
            }

            return resultado.ToString();
        }
    }
}
