//20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou ÍMPAR.

int num, resto;

Console.WriteLine("Digite um número inteiro: ");
num = Convert.ToInt32(Console.ReadLine());

resto = num % 2;

if(resto == 0)
{
    Console.WriteLine("O numero digitado é PAR!!");
}
else
{
    Console.WriteLine("O número digitado é IMPAR!!");
}