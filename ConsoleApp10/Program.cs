using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Program
    {
        public static void Punto2()
        {
            Console.WriteLine("Digite el numero para la escalera");

            bool resultado = false;
            int n = 0;
            string line = "";
            while (resultado == false)
            {
                var num = Console.ReadLine();
                resultado = int.TryParse(num, out int numero);
                if (resultado == false)
                    Console.WriteLine("Valor invalido, debe ser numerico");
                else if (numero == 0)
                {
                    Console.WriteLine("El numero debe ser entre 1 y 100");
                    resultado = false;
                }
                else
                    n = numero;

            }
            Console.WriteLine("Construyendo la escalera");
            //METODO 1
            Console.WriteLine("Agente 1");
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
                Console.WriteLine(line);
            }
            //METODO 2
            Console.WriteLine("Agente 2");
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
                Console.WriteLine(line);
            }
            /*METODO 3*/
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
                    Console.WriteLine(espacios + escalera + line);
                }
            }
            Console.Read();
        }
        static void Main(string[] args)
        {
            bool resultado = false;
            int n = 0;
            Console.WriteLine("Digite la opcion correspondiente:");
            Console.WriteLine("1 Obtener media");
            Console.WriteLine("2 Escalera");
            while (resultado == false)
            {
                var num = Console.ReadLine();
                resultado = int.TryParse(num, out int numero);
                if (resultado == false)
                    Console.WriteLine("Valor invalido, debe ser numerico");
                else
                    n = numero;
                if(n > 2) 
                {
                    Console.WriteLine("Valor invalido, debe 1 o 2");
                    resultado = false;
                }
                else
                {
                    resultado = true;
                }  
            }
            if (n == 1)
                Program.Punto1();
            else if (n == 2)
                Program.Punto2();
        }
        public static void Punto1()
        {
            Console.WriteLine("Digite la cantidad de numeros:");
            bool resultado = false;
            int n = 0, p, w, v;
            decimal l, s = 0, e, ma, mar, mm, aux, c = 0;

            while (resultado == false)
            {
                var num = Console.ReadLine();
                resultado = int.TryParse(num, out int numero);
                if (resultado == false)
                    Console.WriteLine("Valor invalido, debe ser numerico");
                else
                    n = numero;

            }
            decimal[] a = new decimal[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite el " + (i + 1) + " numero:");
                string linea;
                linea = Console.ReadLine();
                a[i] = int.Parse(linea);
            }
            //media aritmetica
            for (int i = 0; i < n; i++)
            {
                c += a[i];
            }
            ma = c / n;
            Console.WriteLine("La media aritmetica es: " + ma);
            //mediana
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
            }
            Console.WriteLine("Los numeros ordenados son:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
            if ((n % 2) != 0)
            {
                p = ((n + 1) / 2) - 1;
                Console.WriteLine("La mediana es " + a[p]);
            }
            else
            {
                w = (n / 2) - 1;
                v = (n / 2);
                l = a[w];
                e = a[v];
                mm = (l + e) / 2;
                Console.WriteLine("La mediana es " + mm);
            }
            //media armonica

            for (int i = 0; i < n; i++)
            {//realizando las sumas del denominador
                s += 1 / a[i];
            }
            mar = n / s;
            Console.WriteLine("La Media armonica es " + mar);//imprimiendo el resultado
            Console.ReadLine();
        }
    }
}
