using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public interface IEscalera
    {
        public List<string> ObtenerRespuesta();
        protected List<string> Agente1();
        protected List<string> Agente2();
        protected List<string> Agente3();
    }
}
