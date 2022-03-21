/*52) Crie um algoritmo que leia a idade de 10 pessoas, mostrando no final:
a) Qual é a média de idade do grupo --------------- OK
b) Quantas pessoas tem mais de 18 anos ---------------- OK
c) Quantas pessoas tem menos de 5 anos ----------------- OK
d) Qual foi a maior idade lida ------------------------- OK*/ 

double soma = 0, div = 0, cont = 0, contmenos = 0, maior = 0;


for (int i = 0; i < 10; i++ )
{
    div++;
    Console.WriteLine("Digite a idade da "+ div +"ª pessoa: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    soma += Convert.ToDouble(idade);

    if (idade >= 18)
    {
        cont++;
    }

    if (idade <= 5)
    {
        contmenos++;
    }
    if (idade > maior)
    {
        maior = idade;
    }
}

Console.WriteLine("A média todas as idades é: " + soma/div + " anos!");
Console.WriteLine("A quantidade de pessoas com mais de 18 anos é: "+ cont);
Console.WriteLine("A quantidade de pessoas com menos de 5 anos é: " + contmenos);
Console.WriteLine("A maior idade informada foi: " + maior);
