using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Calculadora
    {
        Circulo circulito = new Circulo();
        Cuadrado cuadradito = new Cuadrado();
        Rectangulo rectangulito = new Rectangulo();
        Triángulo triangulito = new Triángulo();
        Rombo rombito = new Rombo();
        Romboide romboidecito = new Romboide();
        Trapecio trapecio = new Trapecio();
        Poligono poligonito = new Poligono();
        public void calcularareaCirculo()
        {
            Console.WriteLine("Introduce el valor del radio");
            circulito.radio = Convert.ToDecimal(Console.ReadLine());
            circulito.area = (int)System.Math.PI * circulito.radio * circulito.radio;
            Console.WriteLine("El área es: " + circulito.area);
            Console.ReadLine();

        }
        public void calcularPerimetroCirculo()
        {
            
            Console.WriteLine("                  ooo OOO OOO ooo");
            Console.WriteLine("              oOO                 OOo");
            Console.WriteLine("          oOO                         OOo");
            Console.WriteLine("       oOO                               OOo");
            Console.WriteLine("     oOO                                   OOo");
            Console.WriteLine("   oOO                                       OOo");
            Console.WriteLine("  oOO                                         OOo");
            Console.WriteLine(" oOO                                           OOo");
            Console.WriteLine("oOO                                             OOo");
            Console.WriteLine("oOO                                             OOo");
            Console.WriteLine("oOO                                             OOo");
            Console.WriteLine("oOO                                             OOo");
            Console.WriteLine("oOO                                             OOo");
            Console.WriteLine(" oOO                                           OOo");
            Console.WriteLine("  oOO                                         OOo");
            Console.WriteLine("   oOO                                       OOo");
            Console.WriteLine("     oOO                                   OOo");
            Console.WriteLine("       oO                                OOo");
            Console.WriteLine("       oOO                               OOo");
            Console.WriteLine("          oOO                         OOo");
            Console.WriteLine("              oOO                 OOo");
            Console.WriteLine("                  ooo OOO OOO ooo");
            Console.WriteLine("Introduce el valor del diámetro");
            circulito.diametro = Convert.ToDecimal(Console.ReadLine());
            circulito.perimetro = (int)System.Math.PI * circulito.diametro;
            Console.WriteLine("El perímetro es: " + circulito.perimetro);
            Console.ReadLine();

        }
        public void calcularAreaCuadrado()
        {
            Console.WriteLine("Introduce el valor del lado");
            cuadradito.lado = Convert.ToDecimal(Console.ReadLine());
            cuadradito.area = cuadradito.lado * cuadradito.lado;
            Console.WriteLine("El área es: " + cuadradito.area);
        }
        public void calcularPerimetroCuadrado()
        {
            cuadradito.perimetro = cuadradito.lado + cuadradito.lado + cuadradito.lado + cuadradito.lado;
            Console.WriteLine("El perímetro es: " + cuadradito.perimetro);
            Console.ReadLine();
        }
        public void calcularAreaRectangulo()
        {
            Console.WriteLine("Introduce el valor de la base");
            rectangulito.b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la altura");
            rectangulito.altura = Convert.ToDecimal(Console.ReadLine());
            rectangulito.area = rectangulito.b * rectangulito.altura;
            Console.WriteLine("El área es: " + rectangulito.area);
          
        }
        public void calcularPerimetroRectangulo()
        {
            rectangulito.perimetro = rectangulito.b + rectangulito.b + rectangulito.altura + rectangulito.altura;
            Console.WriteLine("El perímetro es: " + rectangulito.perimetro);
            Console.ReadLine();
        }
        public void calcularAreaTriangulo()
        {
            Console.WriteLine("Introduce el valor de la base");
            triangulito.b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la altura");
            triangulito.altura = Convert.ToDecimal(Console.ReadLine());
            triangulito.area = triangulito.b * triangulito.altura;
            Console.WriteLine("El área es: " + triangulito.area);
        }
        public void calcularPerimetroTriangulo()
        {
            Console.WriteLine("Introduce el valor del lado");
            triangulito.lado = Convert.ToDecimal(Console.ReadLine());
            triangulito.perimetro = triangulito.lado + triangulito.lado + triangulito.lado;
            Console.WriteLine("El perímetro es: " + triangulito.perimetro);
            Console.ReadLine();
        }
        public void CalcularAreaRombo()
        {
            Console.WriteLine("Introduce el valor de la diagonal mayor");
            rombito.Diagonal_mayor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la diagonal menor");
            rombito.Diagonal_menor = Convert.ToDecimal(Console.ReadLine());
            rombito.area = rombito.Diagonal_mayor * rombito.Diagonal_mayor;
            Console.WriteLine("El área es: " + rombito.area);
        }
        public void CalcularPerimetroRombo()
        {
            Console.WriteLine("Introduce el valor del lado");
            rombito.lado = Convert.ToDecimal(Console.ReadLine());
            rombito.perimetro = rombito.lado + rombito.lado + rombito.lado + rombito.lado;
            Console.WriteLine("El perímetro es: " + rombito.perimetro);
            Console.ReadLine();
        }
        public void CalcularAreaRomboide()
        {
            Console.WriteLine("Introduce el valor de la base");
            romboidecito.b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la altura");
            romboidecito.altura = Convert.ToDecimal(Console.ReadLine());
            romboidecito.area = romboidecito.b * romboidecito.altura;
            Console.WriteLine("El área es: " + romboidecito.area);
        }
        public void CalcularPerimetroRomboide()
        {
            romboidecito.perimetro = romboidecito.b + romboidecito.b + romboidecito.altura + romboidecito.altura;
            Console.WriteLine("El perímetro es: " + romboidecito.perimetro);
            Console.ReadLine();
        }
        public void CalcularAreaTrapecio()
        {
            Console.WriteLine("Introduce el valor de la altura");
            trapecio.altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la base mayor");
            trapecio.basemayor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la base menor");
            trapecio.basemenor = Convert.ToDecimal(Console.ReadLine());
            trapecio.area = trapecio.altura * trapecio.basemayor * trapecio.basemenor / 2;
            Console.WriteLine("El área es: " + trapecio.area);

        }
        public void CalcularPerimetroTrapecio()
        {
            Console.WriteLine("Introduce el valor de un lado");
            trapecio.lado = Convert.ToDecimal(Console.ReadLine());
            trapecio.perimetro = trapecio.basemayor + trapecio.basemenor + trapecio.lado + trapecio.lado;
            Console.WriteLine("El perímetro es: " + trapecio.perimetro);
            Console.ReadLine();
        }
        public void CalcularPerimetroPoligono()
        {
            Console.WriteLine("Introduce el valor del lado");
            poligonito.lado = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Introduce el número total de lados");
            poligonito.n_lados = Convert.ToDecimal(Console.ReadLine());
            poligonito.perimetro = poligonito.lado*poligonito.n_lados;
            Console.WriteLine("El perímetro es: " + poligonito.perimetro);
            Console.ReadLine();
        }
        public void CalcularAreaPoligono()
        {
            Console.WriteLine("Introduce el valor del apotema");
            poligonito.apotema = Convert.ToDecimal(Console.ReadLine());
            poligonito.area = poligonito.perimetro * poligonito.apotema / 2;
            Console.WriteLine("El área es: " + poligonito.area);
            Console.ReadLine();
        }
    }
}
