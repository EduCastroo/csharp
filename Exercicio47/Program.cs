//47) Desenvolva um aplicativo que mostre na tela o resultado da expressão 500 + 450 + 400 + 350 + 300 + ... +50 + 0

int num=550;
int soma = 0;

while (num > 0)
{
    num = num - 50;
    Console.WriteLine(num);
    soma = soma + num;
}
Console.WriteLine(soma);
//Implementar soma dos números!


