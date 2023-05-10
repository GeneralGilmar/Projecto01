using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03 {
    internal class Funcionario {
        private string Nome;
        private double SalarioBruto;
        private double Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto) {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public  double SalarioLiquido() {
            return SalarioBruto-Imposto;
        }
        public void  AumentarSalario(double porcentagem) {
            SalarioBruto += SalarioBruto * porcentagem / 100;
        }

        public override string ToString() {
            return Nome+ ", $ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
