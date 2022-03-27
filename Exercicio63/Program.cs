// 63) Crie um programa usando a estrutura “faça enquanto” que leia vários números. 
//A cada laço, pergunte se o usuário quer continuar ou não. No final, mostre na 
//tela:
//a) O somatório entre todos os valores
//b) Qual foi o menor valor digitado
//c) A média entre todos os valores
//d) Quantos valores são pares


int i = 0, num = 0, maiorNum = 0, cont = 0, soma = 0, parar = 0, menorNum = 0, numPar = 0;


do
{
    Console.WriteLine("Digite um número: ");
    num = Convert.ToInt32(Console.ReadLine());

    maiorNum = num;
    menorNum = num;
    soma += num;
    cont += 1;
    i++;

    if(num < num)
    {
        menorNum = num;
    }
    if (num % 2 == 0)
    {
        numPar++;
    }

    Console.WriteLine("Digite 0 para CONTINUAR ou 1 para SAIR: ");
    parar = Convert.ToInt32(Console.ReadLine());

} while (parar == 0);

Console.WriteLine("----------------------------------------------");
Console.WriteLine("O somatório dos números digitados é: " + soma);
Console.WriteLine("----------------------------------------------");
Console.WriteLine("O menor número digitado foi: " + menorNum);
Console.WriteLine("----------------------------------------------");
Console.WriteLine("A média entre os números digitados foi: " + (soma/cont));
Console.WriteLine("----------------------------------------------");
Console.WriteLine("A quantidade de números pares é: " + numPar);
Console.WriteLine("----------------------------------------------");
