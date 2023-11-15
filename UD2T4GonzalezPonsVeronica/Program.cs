/////////////////////////////////////////////
///Tarea:UD2T4
///Alumna: Verónica González Pons
///Curso: 2023/2024
////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4GonzalezPonsVeronica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num != 0)
            {
                Console.Clear();
                Console.WriteLine("-------MENU--------");
                Console.Write("0 - Salir\r\n" +
                                  "1 - Rectángulo\r\n" +
                                  "2 - Círculo\r\n" +
                                  "3 – Tríangulo\r\n" +
                                  "Introduzca su opcion:");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        num = 0;
                        Console.WriteLine("ADIOS!!");
                        break;

                    case 1:
                        num = 1;
                        Console.WriteLine(" ");
                        Rectangulo();
                        break;

                    case 2:
                        num = 2;
                        Console.WriteLine(" ");
                        Circulo();
                        break;

                    case 3:
                        num = 3;
                        Console.WriteLine(" ");
                        Triangulo();
                        break;

                    default:
                        Console.WriteLine("Introduce un número del 0 al 3");
                        Console.WriteLine(" ");
                        break;

                }
                Console.Write("Pulsa INTRO para continuar....");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;



            }




        }
        /// <summary>
        /// Metodo Rectángulo donde rellenamos las variables "l1, l2"
        /// y calcula y muestra el resultado de perimetro y area .
        /// </summary>
        static void Rectangulo()
        {
            Console.Write("Introduce la medida en cm de un lado: ");
            float l1 = float.Parse(Console.ReadLine());
            Console.Write("Introduce la medida en cm de otro lado: ");
            float l2 = float.Parse(Console.ReadLine());
            Figura rectangulo = new Rectangulo(l1, l2);
            Console.WriteLine($"El perimetro de el rectángulo es {rectangulo.Perimetro()}");
            Console.WriteLine($"El area de el rectángulo es {rectangulo.Area()}");
        }
        /// <summary>
        /// Metodo Círculo donde rellenamos la variable "r"
        /// y calcula y muestra el resultado de perimetro y area .
        /// </summary>
        static void Circulo()
        {
            Console.Write("Introduce el radio en cm: ");
            float r = float.Parse(Console.ReadLine());
            Figura circulo = new Circulo(r);
            Console.WriteLine($"El perimetro de el círculo es {circulo.Perimetro()}");
            Console.WriteLine($"El area de el círculo es {circulo.Area()}");
        }
        /// <summary>
        /// Metodo Triángulo donde rellenamos las variables "b, h"
        /// y calcula y muestra el resultado de perimetro y area .
        /// </summary>
        static void Triangulo()
        {
            Console.Write("Introduce la base: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Introduce la altura: ");
            float h = float.Parse(Console.ReadLine());
            Figura triangulo = new Triangulo(b, h);
            Console.WriteLine($"El perimetro de el triángulo es {triangulo.Perimetro()}");
            Console.WriteLine($"El area de el triángulo es {triangulo.Area()}");
        }
    }

}
