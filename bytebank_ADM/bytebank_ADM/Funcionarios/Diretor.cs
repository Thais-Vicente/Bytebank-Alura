﻿using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:Funcionario
    {
       
        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.5;

        }


    }
}
