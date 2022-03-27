// 68) Crie um programa que leia sexo e peso de 8 pessoas, usando a estrutura 
//“para”. No final, mostre na tela:
//a) Quantas mulheres foram cadastradas
//b) Quantos homens pesam mais de 100Kg
//c) A média de peso entre as mulheres 
//d) O maior peso entre os homens



string sexo;
int peso, soma = 0, media;
int homens = 0, mulheres = 0, maior = 0;

for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Digite o sexo (F/M): ");
    sexo = Console.ReadLine();

    if (sexo == "F")
    {
        mulheres++;
    }

    Console.WriteLine("Informe seu peso: ");
    peso = Convert.ToInt32(Console.ReadLine());

    if (sexo == "M" && peso > 100)
    {
        homens++;   
    }
    if (sexo == "M" && peso > maior)
    {
        maior = peso;
    }
    if (sexo == "F")
    {
        soma += peso;
    }
}
media = soma / 8;

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("A quantidade de mulheres cadastradas foi: " + mulheres);
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("A quantidade de homens com mais de 100kg foi: " + homens);
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("A média de peso das mulheres foi: " + media);
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("O maior peso entre os homens foi: " + maior);