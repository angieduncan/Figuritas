using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class FigurasGeometricas
    {
        public String Cuadrado { get; set; }
        public String Rectangulo { get; set; }
        public String Triangulo { get; set; }
        public String Rombo { get; set; }
        public String Romboide { get; set; }
        public String Trapecio { get; set; }
        public String Circulo { get; set; }
        public String Poligono { get; set; }
        public int Area { get; set; }
        public int Perimetro { get; set; }
        public int b {get; set;}
        public int a { get; set; }

        public void Listadefiguras(int area, int perimetro)
        {
          
            String si;
            do
            {
                int numero;
                Console.WriteLine("FIGURAS GEOMÉTRICAS");
                Console.ReadLine();
                Console.WriteLine("1. Cuadrado");              
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Rombo");
                Console.WriteLine("5. Romboide");
                Console.WriteLine("6. Trapecio");
                Console.WriteLine("7. Circulo");
                Console.WriteLine("8. Poligono\n");
                Console.WriteLine("Elija una figura\n");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce un número");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro número");
                a = Convert.ToInt32(Console.ReadLine());
                switch (numero)

                {
                    case 1:
                        area = b * a;
                        perimetro = b + a + b + a;
                        Console.WriteLine("\nCálculo de área y perímetro del cuadrado");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;
                    case 2:
                        area = a * b;
                        perimetro = b + b + a + a;
                        Console.WriteLine("\nCálculo de área y perímetro del Rectángulo");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;
                    case 3:
                        area = b * a/2;
                        perimetro = b + b +b;
                        Console.WriteLine("\nCálculo de área y perímetro del Triángulo");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;
                    case 4:
                        area = b*a;
                        perimetro = b + b + a + a;
                        Console.WriteLine("\nCálculo de área y perímetro del Rombo");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;
                    case 5:
                        area = b*a;
                        perimetro = b + b + a + a;
                        Console.WriteLine("\nCálculo de área y perímetro del Romboide");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;
                    case 6:
                        area = a*b*b/2;
                        perimetro = b + b + a + a;
                        Console.WriteLine("\nCálculo de área y perímetro del Trapecio");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;
                    case 7:
                        area = (int)System.Math.PI *b*b;
                        perimetro = (int)System.Math.PI *a;
                        Console.WriteLine("\nCálculo de área y perímetro del Círculo");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;
                    case 8:
                        area = b*a/2;
                        perimetro = b*b*b*a*a;
                        Console.WriteLine("\nCálculo de área y perímetro del Polígono");
                        Console.ReadLine();
                        Console.WriteLine("El resultado del área es: " + area);
                        Console.WriteLine("El resultado del perímetro es: " + perimetro);
                        break;

                }
                Console.WriteLine("\n¿Quieres calcular otra figura? (Si/No)");
                si = Console.ReadLine();

            } while (si == "Si" || si == "SI" || si == "si");   

        }
        public void ElegirFigura(int area, int perimetro)
        {
            String mensaje = "";


            if (area.Equals("Cuadrado") || perimetro.Equals("Cuadrado"))
            {
  


             
            }


            else if (area.Equals("Rectangulo") || perimetro.Equals("Rectangulo"))
            {
                mensaje = "Elegiste el Rectángulo";
            }
            else if (area.Equals("Triangulo") && perimetro.Equals("Triangulo"))
            {
                mensaje = "Elegiste el Triángulo";
            }
            else if (area.Equals("Rombo") && perimetro.Equals("Rombo"))
            {
                mensaje = "Elegiste el Rombo";
            }
            else if (area.Equals("Romboide") && perimetro.Equals("Romboide"))
            {
                mensaje = "Elegiste el Romboide";
            }
            else if (area.Equals("Trapecio") && perimetro.Equals("Trapecio"))
            {
                mensaje = "Elegiste el Trapecio";
            }
            else if (area.Equals("Circulo") && perimetro.Equals("Circulo"))
            {
                mensaje = "Elegiste el Circulo";
            }
            else if (area.Equals("Poligono") && perimetro.Equals("Poligono"))
            {
                mensaje = "Elegiste el Poligono";
            }
            else {
                mensaje = "Debes elegir un idioma"; }
            Console.WriteLine(mensaje);
        }
    }

}
