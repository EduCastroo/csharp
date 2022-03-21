//6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.
//Ex: 
//Digite um número: 9
//O antecessor de 9 é 8
//O sucessor de 9 é 10

int num;


Console.WriteLine("Digite um número inteiro: ");
num = Convert.ToInt32(Console.ReadLine());
int ant = (num - 1);
int suc = (num + 1);
Console.WriteLine("O antecessor de " + num + " é igual a " + ant + ".");
Console.WriteLine("O sucessor de " + num + " é igual a " + suc + ".");