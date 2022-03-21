//Informe se o número é par ou impar

int num, resto;

Console.WriteLine("Informe um número inteiro para descobrir se é par ou impar: ");
num = Convert.ToInt32(Console.ReadLine());

resto = num % 2;

if(resto == 0) {
    Console.WriteLine("O número digitado é PAR!");
}
else
{
    Console.WriteLine("O número digitado é IMPAR!");
}