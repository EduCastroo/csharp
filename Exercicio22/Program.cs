//22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua 
//situação em relação ao alistamento militar.
// - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o alistamento.
//- Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do alistamento.


int anoNasc;

Console.WriteLine("Informe o ano de nascimento: ");
anoNasc = Convert.ToInt32(Console.ReadLine());

int idade = (2022 - anoNasc);
int faltaAnos = (18 - idade);
int passaAnos = idade + (18 - idade);

if(idade > 18)
{
    Console.WriteLine("Passaram " + passaAnos + " anos do seu alistamento");
}
else
{
    Console.WriteLine("Faltam " + faltaAnos + " para o seu alistamento.");
}

