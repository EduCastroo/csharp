// 59) Crie um programa que leia o sexo e a idade de várias pessoas. O programa vai 
//perguntar se o usuário quer continuar ou não a cada pessoa. No final, mostre:
//a) qual é a maior idade lida
//b) quantos homens foram cadastrados
//c) qual é a idade da mulher mais jovem
//d) qual é a média de idade entre os homens


int idade = 0, parar = 1, maiorIdade = 0, homens = 0, menorIdadeMulher = 0, mediaIdadeHomens = 0, cont = 0, soma = 0;
string sexo;

Console.WriteLine("Digite 0 para CONTINUAR ou 1 para PARAR: ");
parar = Convert.ToInt32(Console.ReadLine());

while(parar == 0)
{
    Console.WriteLine("Digite a IDADE: ");
    idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o SEXO [M = Masculino] ou [F =  Feminino]: ");
    sexo = Console.ReadLine();

    Console.WriteLine("Digite 0 para CONTINUAR ou 1 para PARAR: ");
    parar = Convert.ToInt32(Console.ReadLine());

    if (idade > maiorIdade)
    {
        maiorIdade = idade;
    }
    if (sexo == "M")
    {
        homens += 1;

    }if(sexo == "F")
    {
        menorIdadeMulher = idade;
    }
    if(sexo == "M")
    {
        soma += idade;
        cont += 1;
        mediaIdadeHomens = soma / cont;
    }
    
}

Console.WriteLine("A maior idade foi: "+ maiorIdade);
Console.WriteLine("A quantidade de homens cadastrados foi: " + homens);
Console.WriteLine("A idade da mulher mais jovem é: " + menorIdadeMulher);
Console.WriteLine("A média da idade dos homens foi: " + mediaIdadeHomens);