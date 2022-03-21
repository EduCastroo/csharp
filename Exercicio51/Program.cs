//51) Faça um aplicativo que leia o preço de 8 produtos. No final, mostre na tela 
//qual foi o maior e qual foi o menor preço digitados.

int maior = 0, menor,num= 0, i = 0, valor =0;

Console.WriteLine("Quantos preços você deseja adicionar? ");
valor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o primeiro número: ");
num = Convert.ToInt32(Console.ReadLine());

maior = num;
menor = num;
i = 1;

for(i = 2; i <= valor; i++) //i = 2 pois será o segundo número lido
{
    Console.WriteLine("Informe o " + i + " número");
    num = Convert.ToInt32(Console.ReadLine());

    if (num < menor) // se número digitado menor que o ultimo número.
    {
        menor = num;
    }
    if(num > maior) // se número digitado maior que o ultimo número.
    {
        maior = num;
    }

}

Console.WriteLine("O maior número é: " + maior);
Console.WriteLine("O menor número é: " + menor);