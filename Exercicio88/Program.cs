//88) Crie um programa que melhore o procedimento Gerador() da questão anterior 
//para que mostre uma mensagem vário
//Ex: Ao chamar Gerador("Aprendendo Portugol", 4) aparece:
//+-------======= ------+
// Aprendendo Portugol
// Aprendendo Portugol
// Aprendendo Portugol
// Aprendendo Portugol
//+-------=======------+

static void Gerador(string texto, int rep = 3)
{
    Console.WriteLine("+-------======= ------+");
    for (int i = 0; i <= rep; i++)
    {
        Console.WriteLine(texto);   
    }
    Console.WriteLine("+-------======= ------+");
}
Gerador("Aprendendo C#");