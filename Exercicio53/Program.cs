//53) Faça um programa que leia a idade e o sexo de 5 pessoas, mostrando no final:
//a) Quantos homens foram cadastrados
//b) Quantas mulheres foram cadastradas
//c) A média de idade do grupo
//d) A média de idade dos homens
//e) Quantas mulheres tem mais de 20 anos

int[] idade = new int[5];
string[] sexos = new string[5];

int homem = 0, mulher = 0, mulherMais20 = 0, aux = 0, auxDivisor = 0;
double mediaIdade = 0, mediaHomens = 0;

for (int i = 0; i < idade.Length ; i++)
{
    Console.WriteLine("Digite a idade: ");
    idade[i] = Convert.ToInt32(Console.ReadLine());
}
for(int j = 0; j < sexos.Length; j++)
{
    Console.WriteLine("Digite o sexo M = Masculino / F = Feminino: ");
    sexos[j] = Convert.ToString(Console.ReadLine());
}
foreach (String sexo in sexos) //percorre todo array sexos
{
    if (sexo == "M")
    {
        homem++;
    }
    else if (sexo == "F"){
        mulher++;
    }
}

Console.WriteLine("A quantidade de HOMENS cadastrados é: " + homem);
Console.WriteLine("A quantidade de MULHERES cadastradas é: " + mulher);

foreach (int idades in idade)
{
    mediaIdade += idades;
}

Console.WriteLine("A média de idade do grupo é :" + mediaIdade / idade.Length);


while(aux <= (idade.Length - 1))
{
    if(sexos[aux] == "M" )
    {
        mediaHomens += idade[aux];
        auxDivisor++;

    }else if(sexos[aux] == "F")
    {
        if(idade[aux] > 20)
        {
            mulherMais20++;
        }
    }

    aux++;

}

Console.WriteLine("A média de idade dos homens é: " + (mediaHomens / auxDivisor));
Console.WriteLine("A quantidade de mulheres com mais de 20 anos é: " + mulherMais20);
