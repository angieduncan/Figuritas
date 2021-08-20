using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Romboide
    {
        public decimal area;
        public decimal b;
        public decimal altura;
        public decimal perimetro;
        public string nombreromboide = "|     5. ROMBOIDE       |";

        public void romboide()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.CalcularAreaRomboide();
            calculadora.CalcularPerimetroRomboide();
        }
    }
}
