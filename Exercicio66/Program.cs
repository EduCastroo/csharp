//66) Escreva um programa que leia um número qualquer e mostre a tabuada desse 
//número, usando a estrutura “para”.
// Ex: Digite um valor: 5
//5 x 1 = 5
//5 x 2 = 10
//5 x 3 = 15...

int num = 0;
Console.WriteLine("Digite um número para mostrar a tabuada: ");
num = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(num + " x " + i + " = " + (num*i) );

}