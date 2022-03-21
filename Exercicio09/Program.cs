//9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
//e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$5,11.

double dinheiro;

Console.WriteLine("Quantos reais você tem na carteira? ");
dinheiro = Convert.ToDouble(Console.ReadLine());

double dolar = dinheiro / 5.11;

Console.WriteLine("Você pode comprar " + dolar + " doláres" + " com esse valor.");