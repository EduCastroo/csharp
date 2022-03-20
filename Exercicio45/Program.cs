//45) O programa acima vai ter um problema quando digitarmos o primeiro valor
//maior que o último. Resolva esse problema com um código que funcione em qualquer
//situação.

int valor, valorFinal, incremento;

Console.WriteLine("Digite o PRIMEIRO VALOR: ");
valor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ULTIMO VALOR: ");
valorFinal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o INCREMENTO: ");
incremento = Convert.ToInt32(Console.ReadLine());


while (valor < valorFinal)
{
    Console.WriteLine(valor);
    valor = valor + incremento;

}if(valor > valorFinal)
{
    Console.WriteLine("Digite o valor FINAL maior que o INICIAL");
}
Console.WriteLine("Acabou");