using System;
using System.Collections.Generic;

namespace Sinais
{
    public class BalanceaSinal
    {
        public bool SinaisBalanceados(string sinais)
        {
            bool resultado = false;
            if (sinais.Length > 1)
                resultado = new List<string> { "{}", "()", "[]" }.Contains(sinais) && SinaisBalanceados(sinais.Replace("()", "").Replace("[]", "").Replace("{}", ""));
            else if (sinais.Length == 1)
                resultado = false;
            else
                resultado = true;
            return resultado;
        }
    }
}
