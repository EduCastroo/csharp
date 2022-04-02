/*
PARTE 1: ESTRUTURA SEQUENCIAL
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/


int item1, quant1, item2, quant2;
double valorItem1, valorItem2;

Console.WriteLine("Digite o cod do item 1: ");
item1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade do item 1: ");
quant1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor do item 1:");
valorItem1 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Digite o cod do item 2: ");
item2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade do item 2: ");
quant2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor do item 2:");
valorItem2 = Convert.ToDouble(Console.ReadLine());

double totalItem1 = quant1 * valorItem1;
double totalItem2 = quant2 * valorItem2;
double valorFinal = totalItem1 + totalItem2;

Console.WriteLine("VALOR A PAGAR: R$" + valorFinal);


