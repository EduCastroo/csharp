//23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos 
//para todos, mas especialmente para mulheres. Faça um programa que leia nome,
//sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo 
//que:
// -Homens ganham 5 % de desconto
// - Mulheres ganham 13 % de desconto


string nome;
bool sexo;
double valor;

Console.WriteLine("Digite o seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite o seu sexo (M = true ou F = false): ");
sexo = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Digite o valor da compra: ");
valor = Convert.ToDouble(Console.ReadLine());

double descontoHomem = 5/100.0;
double descontoMulher = 15/100.0;
double valorFinalH = valor - (descontoHomem * valor);
double valorFinalM = valor - (descontoMulher * valor);

if(sexo == true)
{
    Console.WriteLine("O valor da sua compra com descontro é igual a R$" + valorFinalH + ",00");
}
else
{
    Console.WriteLine("O valor da sua compra com desconto é igual a R$" + valorFinalM + ",00");
}