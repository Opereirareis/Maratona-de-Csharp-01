//01 - 

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
// 02 - 
using System;

class Program
{
    static void Main()
    {
        // Variáveis e constantes
        double celsius = 20.0;
        
        // Para a divisão 9/5 funcionar certo, usamos "9.0" ou "5.0" (double)
        // Se usarmos "9/5" (int), o C# acha que o resultado é 1 (inteiro).
        const double fatorConversao = 9.0 / 5.0; 
        const double ajuste = 32;

        // Cálculo
        double fahrenheit = (celsius * fatorConversao) + ajuste;

        // Exibição
        Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F.");
    }
}
