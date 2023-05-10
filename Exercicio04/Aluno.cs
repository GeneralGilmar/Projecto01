using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04 {
    internal class Aluno {
        private string Nome;
        private double Nota1;
        private double Nota2;
        private double Nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3) {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
        }

        public double NotaFinal() {
            return Nota1+Nota2 + Nota3;
        }
        public bool IsAproved() {
            return NotaFinal() >= 60;
        }
        public double Falta() { return NotaFinal()<60?60.0-NotaFinal(): 0.0; }
    }
}
