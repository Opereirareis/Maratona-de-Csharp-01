using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Exercícios de C# ===\n");


    }

    // 01 - Saudação com Nome
    static void SaudacaoComNome()
    {
        Console.WriteLine("\n--- 01 - Saudação com Nome ---");

        string nome = "João";

        // Concatenação
        string saudacao1 = "Olá, " + nome + "! Bem-vindo ao nosso site!";
        Console.WriteLine(saudacao1);

        // Interpolação
        string saudacao2 = $"Olá, {nome}! Bem-vindo ao nosso site!";
        Console.WriteLine(saudacao2);
    }

    // 02 - Conversão de Temperatura (Celsius para Fahrenheit)
    static void ConversaoTemperatura()
    {
        Console.WriteLine("\n--- 02 - Conversão de Temperatura ---");

        double celsius = 20.0;
        const double fatorConversao = 9.0 / 5.0;
        const double ajuste = 32;

        double fahrenheit = (celsius * fatorConversao) + ajuste;

        Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F.");
    }

    // 03 - Impressão de Dados do Usuário
    static void ImpressaoDadosUsuario()
    {
        Console.WriteLine("\n--- 03 - Impressão de Dados do Usuário ---");

        // Simulação (sem ReadLine para rodar no W3Schools)
        string nome = "Ana";
        int idade = 25;
        string cidade = "São Paulo";

        Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos e moro em {cidade}.");
        Console.WriteLine("Meu nome é " + nome + ", tenho " + idade + " anos e moro em " + cidade + ".");
    }

    // 04 - Empréstimo Bancário
    static void EmprestimoBancario()
    {
        Console.WriteLine("\n--- 04 - Empréstimo Bancário ---");

        double valorEmprestimo = 10000.0;
        double taxaJuros = 0.05;
        int numeroParcelas = 12;

        double valorTotalComJuros = valorEmprestimo * (1 + taxaJuros);
        double valorParcela = valorTotalComJuros / numeroParcelas;

        Console.WriteLine("Valor do empréstimo: R$ " + valorEmprestimo.ToString("F2"));
        Console.WriteLine("Taxa de juros: " + (taxaJuros * 100) + "%");
        Console.WriteLine("Número de parcelas: " + numeroParcelas);
        Console.WriteLine("Valor total com juros: R$ " + valorTotalComJuros.ToString("F2"));
        Console.WriteLine("Valor de cada parcela: R$ " + valorParcela.ToString("F2"));
    }

    // 05 - Conversor de Moeda
    static void ConversorMoeda()
    {
        Console.WriteLine("\n--- 05 - Conversor de Moeda ---");

        double valorEmReais = 500.0;
        double taxaCambio = 5.25;

        double valorEmDolares = valorEmReais / taxaCambio;
        double valorFinal = Math.Round(valorEmDolares, 2);

        Console.WriteLine("Valor em reais: R$ " + valorEmReais.ToString("F2"));
        Console.WriteLine("Taxa de câmbio: R$ " + taxaCambio.ToString("F2") + " por dólar");
        Console.WriteLine("Valor convertido: US$ " + valorFinal.ToString("F2"));
    }

    // 06 - Calculadora de Desconto
    static void CalculadoraDesconto()
    {
        Console.WriteLine("\n--- 06 - Calculadora de Desconto ---");

        double precoOriginal = 250.00;
        double percentualDesconto = 20.0;

        double valorDesconto = precoOriginal * (percentualDesconto / 100);
        double precoFinal = precoOriginal - valorDesconto;

        Console.WriteLine("Preço original: R$ " + precoOriginal.ToString("F2"));
        Console.WriteLine("Desconto aplicado: " + percentualDesconto + "%");
        Console.WriteLine("Valor do desconto: R$ " + valorDesconto.ToString("F2"));
        Console.WriteLine("Preço final com desconto: R$ " + precoFinal.ToString("F2"));
    }
}
