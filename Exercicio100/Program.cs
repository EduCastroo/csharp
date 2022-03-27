/*100) Melhore o exercício 96, criando além da função Media() uma outra função 
chamada Situacao(), que vai retornar para o programa principal se o aluno está 
APROVADO, em RECUPERAÇÃO ou REPROVADO. Essa nova função, vai receber como 
parâmetro o resultado retornado pela função Media().*/

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

static string Situacao(double media)
{
    if (media >= 7 && media <= 10)
    {
        return "APROVADO!";
    }
    else if (media >= 4 && media < 7)
    {
        return "RECUPERAÇÃO!";
    }
    else if (media < 4)
    {
        return "REPROVADO!";
    }
    else
    {
        return "INVÁLIDO!";
    }
}
Console.WriteLine(Situacao(media));