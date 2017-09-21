using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaDAL.Contexto
{
    public class ContextoProvider
    {
        private EtiquetaContexto etiquetaContexto = null;
        private static ContextoProvider contextoProvider = null;

        public static ContextoProvider Get()
        {
            contextoProvider = contextoProvider == null ? new ContextoProvider() : contextoProvider;
            return contextoProvider;
        }

        public EtiquetaContexto GetContexto()
        {
            etiquetaContexto = etiquetaContexto == null ? new EtiquetaContexto() : etiquetaContexto;
            return etiquetaContexto;
        }
    }
}
