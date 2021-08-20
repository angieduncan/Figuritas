using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{

    class Cuadrado
    {
        public decimal lado;
        public decimal area;
        public decimal perimetro;
        public string nombrecuadrado= "+-----------------------+\n|  FIGURAS GEOMÉTRICAS  |\n+_______________________+\n|     1. CUADRADO       |";
        public void cuadrado()                                       
        {
            Calculadora calculadora = new Calculadora();
            calculadora.calcularAreaCuadrado();
            calculadora.calcularPerimetroCuadrado();
        }

    }
}
