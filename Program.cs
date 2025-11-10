using System;

class Program
{
    static void Main()
    {
        // 1. Declarando a variável
        string nome = "João";

        // 2. Usando Concatenação (+)
        string saudacao1 = "Olá, " + nome + "! Bem-vindo ao nosso site!";
        Console.WriteLine(saudacao1);

        // 3. Usando Interpolação ($)
        string saudacao2 = $"Olá, {nome}! Bem-vindo ao nosso site!";
        Console.WriteLine(saudacao2);
    }
}
