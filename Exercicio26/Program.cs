//26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando 
//na tela uma das mensagens abaixo:
//-O primeiro valor é o maior
//- O segundo valor é o maior
//- Não existe valor maior, os dois são iguais


int num1, num2;

Console.WriteLine("Digite o primeiro número inteiro: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número inteiro: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("O PRIMEIRO valor é MAIOR!");
}if (num2 > num1)
{
    Console.WriteLine("O SEGUNDO valor é MAIOR!");
}
if (num1 == num2)
{
    Console.WriteLine("Não existe valor maior, os dois são iguais!");
}
