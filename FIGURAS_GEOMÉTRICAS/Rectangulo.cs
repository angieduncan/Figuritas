using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Rectangulo
    {
        public decimal area;
        public decimal b;
        public decimal altura;
        public decimal perimetro;
        public string nombrerectangulo = "|     2. RECTÁNGULO     |";
        public void rectangulo()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.calcularAreaRectangulo();
            calculadora.calcularPerimetroRectangulo();

        }
    }
}
