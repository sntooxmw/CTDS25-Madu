int Idade;
int Data;

Console.WriteLine("Qual ano em que você nasceu?");
Idade = int.Parse(Console.ReadLine());
Data = (2025 - Idade) * 365;
Console.WriteLine($"Você tem {Data} dias de vida.");