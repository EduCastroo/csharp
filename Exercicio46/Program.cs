// 46) Crie um programa que calcule e mostre na tela o resultado da soma entre 6 +8 + 10 + 12 + 14 + ... +98 + 100.


int soma = 0;

for (int numero = 6; numero <=100; numero++)
{
    //verifica se é par
    if (numero % 2 == 0)
    {
        soma = soma + numero;
        
    }

}
Console.WriteLine(soma);









/*int num = 6, soma = 0;

while (num <= 100)
{
    if (num % 2 ==0)
    {
        Console.WriteLine(soma + num);
        num++;
    }
}

Console.WriteLine(soma);*/
