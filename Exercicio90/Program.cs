/*90) Desenvolva um algoritmo que leia dois valores pelo teclado e passe esses 
valores para um procedimento Somador() que vai calcular e mostrar a soma entre 
eles.*/

int num1, num2;

Console.WriteLine("Digite o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
num2 = Convert.ToInt32(Console.ReadLine());


static void Somador(int num1, int num2)
{
    int soma = num1 + num2;
    Console.WriteLine("O resultado da soma é: " + soma);
}
Somador(num1, num2);