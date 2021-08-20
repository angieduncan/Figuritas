using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            Rectangulo rectangulo = new Rectangulo();
            Triángulo triángulo = new Triángulo();
            Rombo rombo = new Rombo();
            Romboide romboide = new Romboide();
            Trapecio trapecio = new Trapecio();
            Circulo circulo = new Circulo();
            Poligono poligono = new Poligono();
            string opcion;
            do
            {
                int numero;
                Console.WriteLine(cuadrado.nombrecuadrado);
                Console.WriteLine(rectangulo.nombrerectangulo);
                Console.WriteLine(triángulo.nombretriangulo);
                Console.WriteLine(rombo.nombrerombo);
                Console.WriteLine(romboide.nombreromboide);
                Console.WriteLine(trapecio.nombretrapecio);
                Console.WriteLine(circulo.nombrecirculo);
                Console.WriteLine(poligono.nombrepoligono);
                Console.WriteLine("\nElija una figura\n");
                numero = Convert.ToInt32(Console.ReadLine());
                switch (numero)
                {
                    case 1:
                        cuadrado.cuadrado();
                        break;
                    case 2:
                        rectangulo.rectangulo();
                        break;
                    case 3:
                        triángulo.Triangulo();
                        break;
                    case 4:
                        rombo.rombo();
                        break;
                    case 5:
                        romboide.romboide();
                        break;
                    case 6:
                        trapecio.trapecio();
                        break;
                    case 7:
                        circulo.circulo();
                        break;
                    case 8:
                        poligono.poligono();
                        break;


                }
                Console.WriteLine("¿Desea hallar el área o perímetro de otra figura? (Si/No)");
                opcion = Console.ReadLine();
                Console.Clear();
            } while (opcion == "SI" || opcion == "Si" || opcion == "si" || opcion == "sI");


        }
    }
}
