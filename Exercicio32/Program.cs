//32) [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o
//jogador vai tentar descobrir qual foi o valor sorteado.





Random numAleatorio = new Random();

int computador = numAleatorio.Next(1, 6);
int jogador = numAleatorio.Next(1, 6);


Console.WriteLine(computador);
Console.WriteLine(jogador);

if (computador == jogador)
{
    Console.WriteLine("PARABÉNS, VOCÊ ACERTOU!!");
}
else
{
    Console.WriteLine("VOCÊ ERROU, TENTE NOVAMENTE!!");
}

