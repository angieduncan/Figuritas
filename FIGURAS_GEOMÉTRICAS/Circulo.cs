using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Circulo
    {
        public decimal radio;
        public decimal area;
        public decimal perimetro;
        public decimal diametro;
        public string nombrecirculo = "|     7. CÍRCULO        |";
        public void circulo()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.calcularareaCirculo();
            calculadora.calcularPerimetroCirculo();
        }
    }
}
