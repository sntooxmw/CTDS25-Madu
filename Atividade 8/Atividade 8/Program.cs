int Valor;

Console.WriteLine("Digite um número");
Valor = int.Parse(Console.ReadLine());

if (Valor > 0)
{
    Console.WriteLine("Seu número é positivo!");
}
else
{
    Console.WriteLine("Seu número é negativo!");
}