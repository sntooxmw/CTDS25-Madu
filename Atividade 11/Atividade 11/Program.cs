int Ano;
int Data;

Console.WriteLine("Em que ano você nasceu?");
Ano = int.Parse(Console.ReadLine());

Data = 2025 - Ano;

if (Data >= 21)
{
    Console.WriteLine("Você já tem a idade adequada para votar!");
}
else
{
    Console.WriteLine("Você não tem idade adequada para votar!");
}