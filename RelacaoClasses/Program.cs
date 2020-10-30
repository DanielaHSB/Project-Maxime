using RelacaoClasses.Heranca;
using System;

namespace RelacaoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            gerente.Usuario = "Pedro";
            gerente.Senha = "test1";
            gerente.Nome = "Pedro S";
            gerente.Salario = 5000.00;

            Gerente gerente1 = new Gerente("Joao", "test2", "Joao Paulo", 3000.00);
            Gerente gerente2 = new Gerente("Dani", "test3", "Dani S");
            Secretaria secretaria = new Secretaria(1234, "Maria", 2500.00);
            Funcionario func = new Funcionario();
            
        }
    }
}
