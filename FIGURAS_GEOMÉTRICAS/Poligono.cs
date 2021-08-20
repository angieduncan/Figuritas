using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Poligono
    {
        public decimal area;
        public decimal apotema;
        public decimal perimetro;
        public decimal n_lados;
        public decimal lado;
        public string nombrepoligono = "|     8. POLÍGONO       |\n+_______________________+";
        public void poligono()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.CalcularPerimetroPoligono();
            calculadora.CalcularAreaPoligono();
           
        }

    }
}
