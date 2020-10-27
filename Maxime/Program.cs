using Maxime.Entities;
using System;

namespace Maxime
{
    class Program
    {

        static void Main(string[] args)
        {
            Produto prod1 = new Produto();
            prod1.Codigo = "001";
            prod1.Modelo = "Mouse Optico";
            prod1.Marca = "HP";
            prod1.ImpostoFederal = 1.50;
            prod1.ImpostoProvincial = 1.00;
            prod1.Valor = 15.50;
            Registradora reg1 = new Registradora();
            reg1.AddProduto(prod1);

            Produto prod2 = new Produto("002", "Teclado", "Microsoft", 2.00, 20.00, 1.00);
            reg1.AddProduto(prod2);

            Console.WriteLine("Nome Prod1:" + reg1.GetNomeDoProduto(prod1));
            Console.WriteLine("Nome Prod2:" + reg1.GetNomeDoProduto(prod2));

            Console.WriteLine("Total: {0:0.00}", reg1.Total);

            Boleto b1 = new Boleto();
            b1.Comprador = "daniela";
            b1.Valor = reg1.Total;
            b1.SetVencimento();
            b1.Taxa = 1.00;
            b1.AplicaDesconto(10, false);
            Console.WriteLine("Nome Comprador:" + b1.Comprador);
            Console.WriteLine("Valor:" + b1.Valor);
            Console.WriteLine("Vencimento:" + b1.Vencimento);
            Console.ReadKey();
        }
    }
}
