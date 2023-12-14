using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class areaTriangulo
    {
        public double baseTriangulo;
        public double alturaTriangulo;

        public double CalcularArea()
        {
            return ((this.baseTriangulo * this.alturaTriangulo) / 2);
        }
    }
}
