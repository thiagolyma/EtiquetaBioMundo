using System;

namespace EtiquetaBLL
{
    internal class StringHelper
    {
        public static bool Contains(string paragrafo, string target)
        {
            return paragrafo.IndexOf(target, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}