using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Trapecio
    {
        public decimal basemayor;
        public decimal basemenor;
        public decimal altura;
        public decimal area;
        public decimal perimetro;
        public decimal lado;
        public string nombretrapecio = "|     6. TRAPECIO       |";

        public void trapecio()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.CalcularAreaTrapecio();
            calculadora.CalcularPerimetroTrapecio();
        }
    }
}
