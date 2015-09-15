using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculoSalarioLiquidoTests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace CalculoSalarioLiquidoTests
{
    [Binding]
    public sealed class CalculoSalarioLiquidoStepDefinition
    {
        private decimal _salario;
        private CalculadoraSalario _calculadoraSalario;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _salario = 0;
            _calculadoraSalario = new CalculadoraSalario();
        }
       
       [Given(@"que eu tenho o salário de (.*) reais")]
        public void DadoQueEuTenhoOSalarioDeReais(Decimal p0)
       {
           _salario = p0;
       }
        
        [When(@"selecionar o cálculo de salário")]
        public void QuandoSelecionarOCalculoDeSalario()
        {
            _calculadoraSalario.InformarSalario(_salario);
            _calculadoraSalario.Calcular();
        }
        
        [Then(@"a alíquota de INSS será (.*)")]
        public void EntaoAAliquotaDeINSSSera(Decimal p0)
        {
            Assert.AreEqual(p0, _calculadoraSalario.ObterAliquotaINSS());
        }
        
        [Then(@"o valor de INSS será (.*)")]
        public void EntaoOValorDeINSSSera(Decimal p0)
        {
            Assert.AreEqual(p0, _calculadoraSalario.ObterValorINSS());
        }
        
        [Then(@"a alíquota de IRRF será (.*)")]
        public void EntaoAAliquotaDeIRRFSera(Decimal p0)
        {
            Assert.AreEqual(p0, _calculadoraSalario.ObterAliquotaIRRF());
        }
        
        [Then(@"o valor do IRRF será (.*)")]
        public void EntaoOValorDoIRRFSera(Decimal p0)
        {
            Assert.AreEqual(p0, _calculadoraSalario.ObterValorIRRF());
        }
        
        [Then(@"a parcela a deduzir será (.*)")]
        public void EntaoAParcelaADeduzirSera(Decimal p0)
        {
            Assert.AreEqual(p0, _calculadoraSalario.ObterParcelaDeduzirIRRF());
        }
        
        [Then(@"o salário líquido será (.*)")]
        public void EntaoOSalarioLiquidoSera(Decimal p0)
        {
            Assert.AreEqual(p0, _calculadoraSalario.ObterValorLiquido());
        }
    }
}
