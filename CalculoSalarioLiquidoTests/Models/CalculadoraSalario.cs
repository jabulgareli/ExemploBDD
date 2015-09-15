using System;

namespace CalculoSalarioLiquidoTests.Models
{
    class CalculadoraSalario
    {
        private decimal _salario;
        private decimal _aliqInss;
        private decimal _aliqIrrf;
        private decimal _parcelaDeduzir;

        public void InformarSalario(decimal salario)
        {
            _salario = salario;
        }

        public void Calcular()
        {
            var calculoIRRF = new CalculoIRRF(_salario);
            _aliqIrrf = calculoIRRF.ObterAliquotaIRRF();
            _parcelaDeduzir = calculoIRRF.ObterParecelaDeduzir();

            var calculoINSS = new CalculoINSS(_salario);
            _aliqInss = calculoINSS.OberAliquotaINSS();
        }
       

        public decimal ObterAliquotaINSS()
        {
            return _aliqInss;
        }

        public decimal ObterValorINSS()
        {
            return Math.Round((ObterAliquotaINSS() / 100) * _salario, 2);
        }

        public decimal ObterAliquotaIRRF()
        {
            return _aliqIrrf;
        }

        public decimal ObterValorIRRF()
        {
            return Math.Round(((ObterAliquotaIRRF() / 100) * (_salario - ObterValorINSS())), 2);
        }

        public decimal ObterParcelaDeduzirIRRF()
        {
            return _parcelaDeduzir;
        }

        public decimal ObterValorLiquido()
        {
            return _salario - ObterValorINSS() - ObterValorIRRF() + ObterParcelaDeduzirIRRF();
        }
    }
}
