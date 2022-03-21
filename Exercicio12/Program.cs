//12) Crie um programa que leia o preço de um produto, calcule e mostre o seu 
//PREÇO PROMOCIONAL, com 5% de desconto.

double valor;

Console.WriteLine("Digite o valor do produto: ");
valor = Convert.ToDouble(Console.ReadLine());

double percentual = 5 / 100.0;
double valorFinal = valor - (percentual * valor);

Console.WriteLine("O valor final do produto com desconto de 5% é: " +
  valorFinal);


