//4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório 
//entre eles.
//Ex:
//Digite um valor: 8
//Digite outro valor: 5
//A soma entre 8 e 5 é igual a 13.


int num1, num2;

Console.WriteLine("Digite um valor: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro valor: ");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("A soma entre " + num1 + " e " + num2 + " é igual a " + (num1+num2) + ".");
