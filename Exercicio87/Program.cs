// 87) Crie um programa que melhore o procedimento Gerador() da questão anterior 
//para que mostre uma mensagem personalizada, passada como parâmetro.
//Ex: Ao chamar Gerador("Aprendendo Portugol") aparece:
//+-------======= ------+
// Aprendendo Portugol
//+ -------======= ------+

static void Gerador(string texto)
{
    Console.WriteLine("+-------======= ------+");
    Console.WriteLine(texto);
    Console.WriteLine("+-------======= ------+");
}
Gerador("Aprendendo C#");