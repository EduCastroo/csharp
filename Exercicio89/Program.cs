/*89) Crie um programa que melhore o procedimento Gerador() da questão anterior 
para que o programador possa escolher uma entre três bordas:
 +-------======= ------+Borda 1
 ~~~~~~~~:::::::~~~~~~~Borda 2
<<<<<<<< ------->>>>>>> Borda 3*/

static void Gerador(string texto, int rep, int borda)
{
    string bordas = "";
    if (borda == 1)
    {
        bordas = "+-------=======------+";
    } else if (borda == 2)
    {
        bordas = "~~~~~~~~:::::::~~~~~~~";
    } else if (borda == 3)
    {
        bordas = "<<<<<<<<------->>>>>>>";
    }

    Console.WriteLine(bordas);
    for (int i = 0; i < rep; i++)
    {
        Console.WriteLine(texto);
    }
    Console.WriteLine(bordas);
}

Gerador("Aprendendo C#", 10 , 1);
