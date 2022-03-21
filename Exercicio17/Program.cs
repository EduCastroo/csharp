//17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 
//80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba 
//o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.


int velocidade;

Console.WriteLine("Digite a velocidade do carro: ");
velocidade = Convert.ToInt32(Console.ReadLine());

int multa = (velocidade - 80) * 5;

if(velocidade == 80)
{
    Console.WriteLine("Velocidade permitida!!");
}
else
{
    Console.WriteLine("Você deverá pagar R$" + multa + ",00 pelo excesso de velocidade!!");
}

