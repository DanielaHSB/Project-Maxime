using System;
using System.Collections.Generic;
using System.Text;

namespace RelacaoClasses.Heranca
{
    public class Gerente : Funcionario
    {
        private string usuario;
        private string senha;

        public Gerente()
        {
        }

        public Gerente(string usuario, string senha, string nome, double salario)
            : base(nome, salario)
        {
            this.usuario = usuario;
            this.senha = senha;
           
        }

        public Gerente(string usuario, string senha, string nome)
            : base(nome)
        {
            this.usuario = usuario;
            this.senha = senha;

        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
