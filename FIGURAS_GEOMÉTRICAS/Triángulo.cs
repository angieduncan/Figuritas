using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIGURAS_GEOMÉTRICAS
{
    class Triángulo
    {
        public decimal area;
        public decimal b;
        public decimal altura;
        public decimal perimetro;
        public decimal lado;
        public string nombretriangulo = "|     3. TRIÁNGULO      |";
        public void Triangulo(){
            Calculadora calculadora = new Calculadora();
            calculadora.calcularAreaTriangulo();
            calculadora.calcularPerimetroTriangulo();
        }
    }
}
