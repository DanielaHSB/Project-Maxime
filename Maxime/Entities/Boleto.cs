using System;
using System.Collections.Generic;
using System.Text;

namespace Maxime.Entities
{
    public class Boleto
    {
        private string comprador;
        private double valor;
        private DateTime vencimento;
        private double taxa;
        private const int PRAZO = 5;

        public string Comprador { get => comprador.ToUpper(); set => comprador = value; }
        public double Valor { get => valor + taxa; set => valor = value; }
        public DateTime Vencimento { get => vencimento; set => vencimento = value; }
        public double Taxa { get => taxa; set => taxa = value; }

        public void SetVencimento()
        {
            DateTime hoje = DateTime.Today;
            Vencimento = hoje.AddDays(PRAZO);
            if (Vencimento.DayOfWeek == DayOfWeek.Sunday)
            {
                Vencimento = Vencimento.AddDays(1);
            }
            else if (Vencimento.DayOfWeek == DayOfWeek.Saturday)
            {
                Vencimento = Vencimento.AddDays(2);
            }
            Console.WriteLine();
        }

        public void AplicaDesconto(double desconto, bool isPercentage)
        {
            if (isPercentage)
            {
                valor -= (desconto * valor)/ 100;
            }
            else
            {
                valor -= desconto;
            }

          //  valor -= (isPercentage) ? (desconto * valor) / 100 : desconto;
        }
    }
}
