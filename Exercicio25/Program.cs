//25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta. 
//Analise seus comprimentos e diga se é possível formar um triângulo com essas 
//retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento 
//de cada lado deve ser menor que a soma dos outros dois.


int ladoA;
int ladoB;
int ladoC;

Console.WriteLine("Digite o tamanho do lado A do triângulo: ");
ladoA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o tamanho do lado B do triângulo: ");
ladoB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o tamanho do lado C do triângulo: ");
ladoC = Convert.ToInt32(Console.ReadLine());

if(ladoA > (ladoB + ladoC) || ladoB > (ladoA + ladoC) || ladoC > (ladoA + ladoB))
{
    Console.WriteLine("É possível formar um triângulo!");
}
else
{
    Console.WriteLine("Não é possível formar um triângulo!");
}
