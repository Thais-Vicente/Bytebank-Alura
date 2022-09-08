using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitários
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }
            
        public double getBonificacao()
        {
            return this.totalBonificacao;
        }

        internal string GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }

}



