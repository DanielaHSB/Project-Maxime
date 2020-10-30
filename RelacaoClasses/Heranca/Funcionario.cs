using System;
using System.Collections.Generic;
using System.Text;

namespace RelacaoClasses.Heranca
{
    public abstract class Funcionario
    {
        protected string nome;
        protected double salario;

        protected Funcionario()
        {

        }

        protected Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
        protected Funcionario(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }
    }

}
