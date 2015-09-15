#language: pt-br

Funcionalidade: Cálculo de salário líquido
	Como um analista de departamento pessoal
	Desejo calcular o salário líquido de um funcionário
	Para que o funcionário receba sua remuneração mensal

Cenário: Salário isento de IRRF
	Dado que eu tenho o salário de 1200,50 reais
	Quando selecionar o cálculo de salário
	Então a alíquota de INSS será 8,00
	E o valor de INSS será 96,04
	E a alíquota de IRRF será 0,00
	E o valor do IRRF será 0,00
	E a parcela a deduzir será 0,00
	E o salário líquido será 1104,46

Cenário: Salário taxado por INSS de 8% e IRRF 7,5%
	Dado que eu tenho o salário de 2200,00 reais
	Quando selecionar o cálculo de salário
	Então a alíquota de INSS será 9,00
	E o valor de INSS será 198,00
	E a alíquota de IRRF será 7,50
	E o valor do IRRF será 150,15
	E a parcela a deduzir será 142,80
	E o salário líquido será 1994,65

