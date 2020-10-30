using System;
using System.Collections.Generic;
using System.Text;

namespace RelacaoClasses.Heranca
{
    public class Secretaria : Funcionario
    {
        private int ramal;

        public int Ramal { get => ramal; set => ramal = value; }

        public Secretaria(int ramal, string nome, double salario)
            : base (nome, salario)
        {
            this.ramal = ramal;
        }

        public Secretaria()
        {
        }
    }
}
