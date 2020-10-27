using System;
using System.Collections.Generic;
using System.Text;

namespace Maxime.Entities
{
    public class Registradora
    {
        private double total;

        public double Total { get => total; }

        public void AddProduto(Produto produto)
        {
            this.total += produto.GetPreco();
            
        }
        public void RemoveProduto(Produto produto)
        {
            this.total -= produto.GetPreco();

        }

        public string GetNomeDoProduto(Produto produto)
        {
            return produto.Codigo + "/" + produto.Modelo + " - " + produto.Marca;
            
        }

    }

}
