using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public class Escalera : IFuncionalidad
    {
        public readonly int numeroEscalera;

        public Escalera(int numeroEscalera)
        {
            this.numeroEscalera = numeroEscalera;
        }
        public List<string> Agente1()
        {
            List<string> lista = new List<string>();
            int n = 0;
            string line = "";
            for (int numEscalera = 1; numEscalera <= n; numEscalera++)
            {
                line = "";
                for (int i = n; i > numEscalera; i--)
                {
                    line += " ";
                }
                for (int i = 1; i <= numEscalera; i++)
                {
                    line += "#";
                }
                lista.Add(line);
            }
            return lista;
        }

        public List<string> Agente2()
        {
            List<string> lista = new List<string>();
            int n = 0;
            string line = "";
            for (int numEscalera = 1; numEscalera <= n; numEscalera++)
            {
                line = "";
                for (int i = 1; i < numEscalera; i++)
                {
                    line += " ";
                }
                for (int i = n; i >= numEscalera; i--)
                {
                    line += "#";
                }
                lista.Add(line);
            }
            return lista;
        }

        public List<string> Agente3()
        {
            List<string> lista = new List<string>();
            int n = 0;
            string line = "";
            int x, y, lado = n;
            Console.WriteLine("Agente 3");
            line = "";

            for (x = 0; x < lado; x++)
            {
                line += "#";
            }
            for (x = 0; x < lado; x++)
            {
                string espacios = "";
                string escalera = "";
                for (y = lado - 1; y > x; y--)
                {
                    espacios += " ";
                }
                for (y = 0; x > y; y++)
                {
                    escalera += "##";
                }
                Console.WriteLine(espacios + escalera + line);
            }
            for (x = 0; x < lado; x++)
            {
                if (x > 0)
                {
                    string espacios = "";
                    string escalera = "";
                    for (y = lado - 1; y > x; y--)
                    {
                        escalera += "##";
                    }
                    for (y = 0; x > y; y++)
                    {
                        espacios += " ";
                    }
                    lista.Add(espacios + escalera + line);
                }
            }
            return lista;
        }

        public List<string> ObtenerRespuesta()
        {
            List<string> lista1 = this.Agente1();
            List<string> lista2 = this.Agente2();
            List<string> lista3 = this.Agente3();
            List<string> lista = new List<string>();
            foreach (var item in lista1)
            {
                lista.Add(item);
            }
            foreach (var item in lista2)
            {
                lista.Add(item);
            }
            foreach (var item in lista3)
            {
                lista.Add(item);
            }
            return lista;
        }
    }
}
