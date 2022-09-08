using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public abstract class Funcionario
    {
        // 0 - funcionário
        // 1 - diretor
        // 2 - designer
        // N - ...
        // private int _tipo;

        public static int TotalFuncionarios { get; set }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um Funcionário.");
            TotalFuncionarios ++;
        }

        public string Nome { get; set; }

        public string Cpf { get; private set; }

       public double Salario { get; protected set; }


        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
        
    }
}
