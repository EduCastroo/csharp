//Programa para retornar um número de três digitos invertidos
//Ex: 978 => 879

int num1;
int num2; 
int num3;
int numInv;

Console.WriteLine("Digite um número de três digitos: ");
numInv = Convert.ToInt32(Console.ReadLine());

num1 = numInv / 100;
num2 = (numInv % 100) / 10;
num3 = numInv % 10;

Console.WriteLine("O número invertido é igual a: " + num3 + num2 + num1);



