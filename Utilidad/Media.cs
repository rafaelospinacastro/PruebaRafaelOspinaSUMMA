using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidad
{
    public class Media : IFuncionalidad
    {
        public readonly int cantidadNumero;
        public readonly decimal[] listadoNumero;

        public Media(int cantidadNumero, decimal[] listadoNumero)
        {
            this.cantidadNumero = cantidadNumero;
            this.listadoNumero = listadoNumero;
        }
        public List<string> Agente1()
        {
            List<string> lista = new List<string>();
            int n = this.cantidadNumero, p, w, v;
            decimal l, s = 0, e, ma, mar, mm, aux, c = 0;
            //media aritmetica
            for (int i = 0; i < n; i++)
            {
                c += listadoNumero[i];
            }
            ma = c / n;
            lista.Add("La media aritmetica es: " + ma);
            return lista;
        }

        public List<string> Agente2()
        {
            //mediana
            List<string> lista = new List<string>();
            int n = this.cantidadNumero, p, w, v;
            decimal l, s = 0, e, ma, mar, mm, aux, c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (listadoNumero[i] > listadoNumero[j])
                    {
                        aux = listadoNumero[i];
                        listadoNumero[i] = listadoNumero[j];
                        listadoNumero[j] = aux;
                    }
                }
            }
            lista.Add("Los numeros ordenados son:");
            for (int i = 0; i < n; i++)
            {
                lista.Add(listadoNumero[i].ToString());
            }
            if ((n % 2) != 0)
            {
                p = ((n + 1) / 2) - 1;
                lista.Add("La mediana es " + listadoNumero[p]);
            }
            else
            {
                w = (n / 2) - 1;
                v = (n / 2);
                l = listadoNumero[w];
                e = listadoNumero[v];
                mm = (l + e) / 2;
                lista.Add("La mediana es " + mm);
            }
            return lista;
        }

        public List<string> Agente3()
        {
            List<string> lista = new List<string>();
            int n = this.cantidadNumero, p, w, v;
            decimal l, s = 0, e, ma, mar, mm, aux, c = 0;
            for (int i = 0; i < n; i++)
            {//realizando las sumas del denominador
                s += 1 / listadoNumero[i];
            }
            mar = n / s;
            lista.Add("La Media armonica es " + mar);
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
