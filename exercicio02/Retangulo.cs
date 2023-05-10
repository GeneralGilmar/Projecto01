using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02 {
    internal class Retangulo {
        private double Largura;
        private double Altura;

        public Retangulo() {

        }
        public Retangulo(double Largura, double Altura) {
               this.Largura = Largura;
               this.Altura = Altura;
        }
        public  double Area() {
            return Largura * Altura;
        }
        public double Perimetro() {
            return 2*(Largura + Altura);

        }
        public double Diagonal() {
            return Math.Sqrt(Largura*Largura+Altura*Altura);
        }
    }
}
