//44) Crie um algoritmo que leia o valor inicial da contagem, o valor final e o
//incremento, mostrando em seguida todos os valores no intervalo:
//Ex: Digite o primeiro Valor: 3
//Digite o último Valor: 10
//Digite o incremento: 2
//Contagem: 3 5 7 9 Acabou!


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
    
}
Console.WriteLine("Acabou");
