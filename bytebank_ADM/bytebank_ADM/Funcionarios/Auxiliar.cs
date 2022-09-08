﻿using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 4000)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.10;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.20;

        }
    }
}
