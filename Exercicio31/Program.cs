//31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)

//Pedra > Tesoura
//Pedra == Pedra *
//Pedra < Papel
//
//Papel > Pedra
//Papel == Papel *
//Papel < tesoura
//
//tesoura > papel
//tesoura == tesoura *
//Tesoura < Pedra
//

int jogador1, jogador2;

Console.WriteLine("JOGADOR 1: Escolha Pedra = 0, Papel = 1, Tesoura = 2");
jogador1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("JOGADOR 2: Escolha Pedra = 0, Papel = 1, Tesoura = 2");
jogador2 = Convert.ToInt32(Console.ReadLine());

int pedra = 0;
int papel = 1;
int tesoura = 2;

if (jogador1 == jogador2)
{
    Console.WriteLine("EMPATE");
}else if (jogador1 - jogador2 == -2 || jogador1 - jogador2 == 1)
{
    Console.WriteLine("JOGADOR 1 GANHOU");
}
else
{
    Console.WriteLine("JOGADOR 2 GANHOU");
}