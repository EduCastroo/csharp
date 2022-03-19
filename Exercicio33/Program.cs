//33) Escreva um programa para aprovar ou não o empréstimo bancário para a compra
//de uma casa. O programa vai perguntar o valor da casa, o salário do comprador e
//em quantos anos ele vai pagar. Calcule o valor da prestação mensal, sabendo que
//ela não pode exceder 30% do salário ou então o empréstimo será negado.

int valorCasa, salarioComprador, quantAnos;

Console.WriteLine("Digite o VALOR DA CASA: ");
valorCasa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o SALÁRIO DO COMPRADOR: ");
salarioComprador = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite em QUANTOS ANOS será o pagamento: ");
quantAnos = Convert.ToInt32(Console.ReadLine());

int meses = quantAnos * 12;
int mensalidade = valorCasa / meses;


if(mensalidade > (salarioComprador * 30) / 100)
{
    Console.WriteLine("EMPRESTIMO NEGADO!!");
}
else
{
    Console.WriteLine("EMPRESTIMO APROVADO!! - Valor da mensalidade: R$" + mensalidade);
}