using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Rombo
    {
        public decimal Diagonal_mayor;
        public decimal Diagonal_menor;
        public decimal area;
        public decimal perimetro;
        public decimal lado;
        public string nombrerombo = "|     4. ROMBO          |";
        public void rombo()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.CalcularAreaRombo();
            calculadora.CalcularPerimetroRombo();
        }
    }
}
