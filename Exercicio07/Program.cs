//7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte.
//Ex: 
//Digite um número: 3.5
//O dobro de 3.5 é 7.0
//A terça parte de 3.5 é 1.16666

double num;

Console.WriteLine("Digite um número inteiro: ");
num = Convert.ToDouble(Console.ReadLine());

double dobro = (num * 2);
double terca = (num / 3);
Console.WriteLine("O dobro de " + num + " é " + dobro);
Console.WriteLine("A terça parte de " + num + " é " + terca);