//18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade 
//dela e depois mostre se ela pode ou não votar.

int anoNasc;

Console.WriteLine("Digite o ano de nascimento: ");
anoNasc = Convert.ToInt32(Console.ReadLine());

int ano = 2022;
int idade = (ano - anoNasc);

if (idade >= 16)
{
    Console.WriteLine("Você poderá votar nas eleições de 2022");
}
else {
    Console.WriteLine("Você só poderar votar quando tiver mais de 16 anos.");
}