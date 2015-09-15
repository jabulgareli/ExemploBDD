using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalarioLiquidoTests.Models
{
    public class CalculoIRRF
    {
        private readonly decimal _salario;
        private decimal _aliqIrrf;
        private decimal _parcelaDeduzir;

        public CalculoIRRF(decimal salario)
        {
            _salario = salario;
            CalcularValores();
        }

        private void CalcularValores()
        {
            if (_salario <= 1903.98M)
            {
                _aliqIrrf = 0;
                _parcelaDeduzir = 0;
            }
            else if (_salario <= 2826.65M)
            {
                _aliqIrrf = 7.5M;
                _parcelaDeduzir = 142.80M;

            }
            else if (_salario <= 3751.05M)
            {
                _aliqIrrf = 15;
                _parcelaDeduzir = 354.80M;
            }
            else if (_salario <= 4664.68M)
            {
                _aliqIrrf = 22.5M;
                _parcelaDeduzir = 636.13M;
            }
            else
            {
                _aliqIrrf = 27.5M;
                _parcelaDeduzir = 869.36M;
            }
        }

        public decimal ObterAliquotaIRRF()
        {
            return _aliqIrrf;
        }

        public decimal ObterParecelaDeduzir()
        {
            return _parcelaDeduzir;
        }
    }
}
