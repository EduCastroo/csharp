//56) Crie um programa que leia vários números pelo teclado e mostre no final o 
//somatório entre eles.
//Obs: O programa será interrompido quando o número 1111 for digitado.

int num = 0, cont = 0, soma = 0;

Console.WriteLine("Digite 1111 para PARAR O PROGRAMA: ");
num = Convert.ToInt32(Console.ReadLine());

while (num != 1111)
{
    Console.WriteLine("Digite 1111 para PARAR O PROGRAMA: ");
    soma +=num; //soma = soma+num
    cont += 1;//cont = cont+1
    num = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Você digitou " + cont + " números e a soma deles foi: " + soma);











/*n=0
c=-1
s=0
while n!=999:
    c+=1
    s+=n
    n=int(input('Num: '))
print('Quandade: {}\nSoma: {}'.format(c,s))*/