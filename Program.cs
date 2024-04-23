
using Desafio_lógica;

Console.WriteLine("Digite a quantidade de vitórias:");
int vitorias = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de derrotas:");
int derrotas = int.Parse(Console.ReadLine());
string nivel = CalcularNivel.CalcularLv(vitorias);

Console.WriteLine($"O Herói tem um saldo de {vitorias - derrotas} e está no nível de {nivel}");

        
