// 55) [DESAFIO] Vamos melhorar o jogo que fizemos no exercício 32. A partir de 
//agora, o computador vai sortear um número entre 1 e 10 e o jogador vai ter 4 
//tentativas para tentar acertar.

//32) [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o
//jogador vai tentar descobrir qual foi o valor sorteado.

int num, escolha = 0, cont = 0;

Random numeroAleatorio = new Random();

num = Convert.ToInt32(numeroAleatorio.Next(1,10));

Console.WriteLine("Tente adivinhar o número: ");


    while (escolha != num)
    {
        escolha = Convert.ToInt32(Console.ReadLine());
    }
    if (escolha > num)
    {
        Console.WriteLine("ERRADO! Escolha um número menor!");
    }
    if (escolha < num)
    {
    Console.WriteLine("ERRADO! Escolha um número maior!");
    }
    if (escolha == num && cont ==0)
    {
    Console.WriteLine("CORRETO! Parabéns você acertou");
    }
    else
    {
    Console.WriteLine("CORRETO! " + num + " é ´número!!");
    cont++;
    }

















