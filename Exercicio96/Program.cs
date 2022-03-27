/*96) Crie um programa que tenha uma função Media(), que vai receber as 2 notas de 
um aluno e retornar a sua média para o programa principal.*/

double nota1, nota2;
double media;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

static double Media(double nota1, double nota2)
{
    return (nota1 + nota2) / 2;
}
media = Media(nota1, nota2);
Console.WriteLine("A primeira nota foi " + nota1 + ", a segunda nota foi: " + nota2 + " e a MÉDIA É: " + media);
