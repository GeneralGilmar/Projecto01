using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica02 {
    internal class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public double ValorTotalEmEstouqe() {
            return _quantidade * _preco;
        }
        public void AdicionarPruduto(int quant) {
            _quantidade += quant;
        }
        public void RemoverProdutos(int quant) {
            _quantidade-= quant;
        }

        public override string ToString() {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
            + _quantidade + " unidades, Total: $ "
            + ValorTotalEmEstouqe().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
    }
}
