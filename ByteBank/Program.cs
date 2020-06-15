using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func01 = new Funcionario();
            func01.Nome = "01 Funcionario";
            func01.CPF = "000.000.000-01";
            func01.Salario = 1000.00;

            Console.WriteLine($"Bonificaçao: {func01.GetBonificacao()}");
            Console.ReadLine();
        }
    }
}
