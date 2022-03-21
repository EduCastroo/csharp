// 49) Crie um programa que leia 6 números inteiros e no final mostre quantos deles são pares e quantos são ímpares.


int num = 0;
int par = 0;
int imp = 0;


while (num <= 6)
{
    if (num % 2 == 0)
    {
        par++;
    }
    else
    {
        imp++;
    }

    num++;
}


Console.WriteLine("A quantidade de números PARES é: " + par);
Console.WriteLine("A quantidade de números IMPARES é: " + imp);