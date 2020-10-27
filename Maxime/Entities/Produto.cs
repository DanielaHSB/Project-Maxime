using System;
using System.Collections.Generic;
using System.Text;

namespace Maxime.Entities
{
    public class Produto
    {
        #region Atributos
        private string codigo;
        private string modelo;
        private string marca;
        private double impostoFederal;
        private double valor;
        private double impostoProvincial;
        #endregion

        public Produto()
        {

        }

        public Produto(string codigo, string modelo, string marca, double impostoFederal, double valor, double impostoProvincial)
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.marca = marca;
            this.impostoFederal = impostoFederal;
            this.valor = valor;
            this.impostoProvincial = impostoProvincial;

        }


        public string Codigo { get => codigo; set => codigo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double ImpostoFederal { get => impostoFederal; set => impostoFederal = value; }
        public double Valor { get => valor; set => valor = value; }
        public double ImpostoProvincial { get => impostoProvincial; set => impostoProvincial = value; }

        public double GetPreco()
        {
            return valor + impostoProvincial + impostoFederal;
        }
    }
}
