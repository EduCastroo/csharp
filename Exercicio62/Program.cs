//62) Faça um programa usando a estrutura “faça enquanto” que leia a idade de 
//várias pessoas. A cada laço, você deverá perguntar para o usuário se ele quer ou 
//não continuar a digitar dados. No final, quando o usuário decidir parar, mostre 
//na tela:
//a) Quantas idades foram digitadas
//b) Qual é a média entre as idades digitadas
//c) Quantas pessoas tem 21 anos ou mais.


int i = 0, idade = 0, cont = 0, soma = 0, mais21 = 0, maiorIdade = 0, parar = 0;

do
{
    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
    soma += idade;
    cont += 1;
    i++;

    if(idade > maiorIdade)
    {
        maiorIdade = idade;
    }

    Console.WriteLine("Digite 0 para CONTINUAR ou 1 para SAIR: ");
    parar = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();

} while (parar == 0);

Console.WriteLine("-----------------------------------");
Console.WriteLine("Foram digitadas: " + i + " idades!");
Console.WriteLine("-----------------------------------");
Console.WriteLine("A média entre as idade é: " + (soma / i));
Console.WriteLine("-----------------------------------");
Console.WriteLine("A maior idade digitada foi: " + maiorIdade);
Console.WriteLine("-----------------------------------");



