/*
 Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. 
*/

int senha;

do
{
    Console.WriteLine("Digite a senha para entrar: ");
    senha = Convert.ToInt32(Console.ReadLine());

    if (senha == 2002)
    {
        Console.WriteLine("ACESSO PERMITIDO!");
    }
    else
    {
        Console.WriteLine("SENHA INVALIDA!!");
    }

} while (senha != 2002);




/*while (senha != 2002)
{
    Console.WriteLine("SENHA INVALIDA!!");
}
Console.WriteLine("ACESSO PERMITIDO!");

*/

