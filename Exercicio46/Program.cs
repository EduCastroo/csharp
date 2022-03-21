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