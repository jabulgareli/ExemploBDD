using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalarioLiquidoTests.Models
{
    public class CalculoINSS
    {
        private readonly decimal _salario;

        public CalculoINSS(decimal salario)
        {
            _salario = salario;
        }

        public decimal OberAliquotaINSS()
        {
            decimal aliqInss = 0;
            if (_salario <= 1399.12M)
            {
                aliqInss = 8;
            }
            else if (_salario <= 2331.88M)
            {
                aliqInss = 9;
            }
            else
            {
                aliqInss = 11;
            }

            return aliqInss;
        }
    }
}
