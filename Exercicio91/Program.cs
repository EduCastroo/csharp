/* 91) Desenvolva um algoritmo que leia dois valores pelo teclado e passe esses 
valores para um procedimento Maior() que vai verificar qual deles é o maior e 
mostrá-lo na tela. Caso os dois valores sejam iguais, mostrar uma mensagem 
informando essa característica.*/

int num1, num2;

Console.WriteLine("Digite o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
num2 = Convert.ToInt32(Console.ReadLine());

static void Maior(int num1, int num2)
{
    if(num1 > num2)
    {
        Console.WriteLine("O número " + num1 + " é maior que " + num2);
    }
    else if (num1 == num2){
        Console.WriteLine("OS DOIS NÚMEROS SÃO IGUAIS!");
    }
    else
    {
        Console.WriteLine("O número " + num2 + " é maior que " + num1);
    }
}
Maior(num1, num2);