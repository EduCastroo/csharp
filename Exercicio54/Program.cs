//54) Desenvolva um aplicativo que leia o peso e a altura de 7 pessoas, mostrando 
//no final:
//a) Qual foi a média de altura do grupo
//b) Quantas pessoas pesam mais de 90Kg
//c) Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m
//d) Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.

int[] peso = new int[7];
double[] altura = new double[7];

int mais90 = 0, menos160m = 0, mais190m = 0, aux = 0;
double menos50kg = 0, mais100kg = 0, mediaAltura = 0;

for (int i = 0; i < peso.Length; i++)
{
    Console.WriteLine("Digite o peso: ");
    peso[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < altura.Length; j++)
{
    Console.WriteLine("Digite a altura: ");
    altura[j] = Convert.ToDouble(Console.ReadLine());
}
foreach (int alturas in altura)
{
    mediaAltura += alturas;
}
Console.WriteLine("A média de altura do grupo é :" + mediaAltura / altura.Length);

if (peso[aux] > 90)
{
    mais90++;
}

Console.WriteLine("A quantidade de pessoas com mais de 90kg é: " + mais90);










