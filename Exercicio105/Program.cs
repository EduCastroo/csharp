/*
PARTE 2: ESTRUTURA CONDICIONAL
Com base na tabela de preços ao lado, faça
um programa que leia o código de um item e a 
quantidade deste item. A seguir, calcule e 
mostre o valor da conta a pagar.*/


int codigo, quantidade;
double valor1 = 4, valor2 = 4.50, valor3 = 5, valor4 = 2, valor5 = 1.50;

Console.WriteLine("FAÇA SEU PEDIDO: ");
Console.WriteLine("Digite o código do produto: ");
codigo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade: ");
quantidade = Convert.ToInt32(Console.ReadLine());



if (codigo == 1)
{
    Console.WriteLine("Cachorro Quente - Total: R$ " + (quantidade*valor1));
}
else if (codigo == 2)
{
    Console.WriteLine("X-Salada - Total: R$ " + (quantidade * valor2));
}
else if (codigo == 3)
{
    Console.WriteLine("X-Bacon - Total: R$ " + (quantidade * valor3));
}
else if (codigo == 4)
{
    Console.WriteLine("Torrada Simples - Total: R$ " + (quantidade * valor4));
}
else if (codigo == 5)
{
    Console.WriteLine("Refrigerante - Total: R$ " + (quantidade * valor5));
}
else
{
    Console.WriteLine("DIGITE UM CÓDIGO VÁLIDO (1,2,3,4 ou 5)");
}
