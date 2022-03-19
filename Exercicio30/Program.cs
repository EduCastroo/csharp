//30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo
//de triângulo será formado:
//-EQUILÁTERO: todos os lados iguais
//- ISÓSCELES: dois lados iguais
//- ESCALENO: todos os lados diferentes

//25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta.
//Analise seus comprimentos e diga se é possível formar um triângulo com essas
//retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento
//de cada lado deve ser menor que a soma dos outros dois.

double ladoA, ladoB, ladoC;

Console.WriteLine("Digite o tamanho do LADO A do triângulo: ");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o tamanho do LADO B do triângulo: ");
ladoB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o tamanho do LADO C do triângulo: ");
ladoC = Convert.ToDouble(Console.ReadLine());

if ((ladoA + ladoB) > ladoC && (ladoA+ladoC)>ladoB && (ladoB+ladoC) > ladoA)
{
    Console.WriteLine("É possivel formar um triângulo!!");
    if (ladoA == ladoB && ladoA == ladoC)
    {
        Console.WriteLine("EQUILÁTERO: todos os lados iguais!!");
    }
    else
    {
        if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
        {
            Console.WriteLine("ISÓSCELES: dois lados iguais!!");
        }
        else
        {
            Console.WriteLine("ESCALENO: todos os lados diferentes!!");
        }
    }
}
else
{
    Console.WriteLine("Não é possível formar um triângulo!!");
}