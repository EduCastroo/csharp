// 60) Desenvolva um algoritmo que leia o nome, a idade e o sexo de várias pessoas. 
//O programa vai perguntar se o usuário quer ou não continuar. No final, mostre:
//a) O nome da pessoa mais velha
//b) O nome da mulher mais jovem
//c) A média de idade do grupo
//d) Quantos homens tem mais de 30 anos
//e) Quantas mulheres tem menos de 18 anos

int idade = 0, parar = 1, maiorIdade = 0;
string nome, sexo;

Console.WriteLine("Digite 0 para CONTINUAR ou 1 para PARAR: ");
parar = Convert.ToInt32(Console.ReadLine());

while (parar == 0)
{
    Console.WriteLine("Digite o nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite a idade: ");
    idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o sexo: ");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite 0 para CONTINUAR ou 1 para PARAR: ");
    parar = Convert.ToInt32(Console.ReadLine());

    if (idade > maiorIdade)
    {
        maiorIdade = idade;
    }

}

Console.WriteLine("A maior idade é :" + maiorIdade);