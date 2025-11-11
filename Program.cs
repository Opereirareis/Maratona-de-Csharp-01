using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: Mario");
        string nome = Console.ReadLine();

        // Concatenação
        Console.WriteLine("Olá, " + nome + "! Bem-vindo ao nosso site!");

        // Interpolação
        Console.WriteLine($"Olá, {nome}! Que bom te ver por aqui 😄");
    }
}
