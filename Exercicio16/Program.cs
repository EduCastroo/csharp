//16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um 
//fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele 
//já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule 
//quantos dias de vida um fumante perderá e exiba o total em dias.


int QuantCigarros;
int anos;

Console.WriteLine("Quantos anos você fumou? ");
anos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quandos cigarros em média fuma por dia? ");
QuantCigarros = Convert.ToInt32(Console.ReadLine());

int dias = anos * 365;
int min = dias * 1440;
int totalCig = (QuantCigarros * dias);
int diasPerdidos = (totalCig * 10) / 1440;

//Console.WriteLine(dias + " equeivale a " + min + " a minutos");
//Console.WriteLine("Você já fumou " + totalCig + " cigarros!");
Console.WriteLine("Você já perdeu: " + diasPerdidos + " dias de vida!");
    