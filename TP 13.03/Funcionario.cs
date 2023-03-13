using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_13._03
{
    internal class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public float DiasTrabalhados { get; set; }
        public float ValorDiaria { get; set; }
        public float salBase { get; private set; }
        public float salLiq { get; private set; }
        public float IR { get; private set; }
        public float percentual { get; private set; }
        public void CalcSalBase()
        {
            salBase = DiasTrabalhados * ValorDiaria;
        }
        public float CalcPercIR()
        {
            if(salBase <= 1903.98f){
                return 0;
            }else if(salBase <= 2826.65f)
            {
                return 0.075f;
            }else if(salBase <= 3751.05f)
            {
               return 0.15f;
            }else //if(salBase < 4664.68f)
            {
                return (22.50f / 100f);
            }
        }
        public void CalcIR()
        {
            IR = salBase * (CalcPercIR());
        }
        public void CalcSalLiq()
        {
            salLiq = salBase - IR;
        }
        public void ResetSalLiq()
        {
            salLiq = 0;
        }
    }
}
