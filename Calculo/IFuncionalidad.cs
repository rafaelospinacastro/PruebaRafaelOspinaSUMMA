using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public interface IFuncionalidad
    {
        public List<string> ObtenerRespuesta();
        public List<string> Agente1();
        public List<string> Agente2();
        public List<string> Agente3();
    }
}
