using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Exercícios de C# ===\n");

        // Chamando cada exercício individualmente
        SaudacaoComNome();
        ConversaoTemperatura();
        ImpressaoDadosUsuario();
        CalculadoraDesconto();
        EmprestimoBancario();
        ConversorMoeda();
    }

    /*01 - Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
Descrição: Crie um script que declare uma variável para o nome de
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá,
João! Bem-vindo ao nosso site!".
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de
uma string com aspas duplas.*/
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

    /* 02 - Conversão de Temperatura (Celsius para Fahrenheit)
    */
    
    static void ConversaoTemperatura()
    {
        Console.WriteLine("\n--- 02 - Conversão de Temperatura ---");

        double celsius = 20.0;
        const double fatorConversao = 9.0 / 5.0;
        const double ajuste = 32;

        double fahrenheit = (celsius * fatorConversao) + ajuste;

        Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F.");
    }

    /* 03 - Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
Descrição: Crie um script que solicite ao usuário seu nome, idade e
cidade e depois mostre uma mensagem com essas informações.
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.*/
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

    /* 04 - Empréstimo Bancário Objetivo: Cálculos financeiros e declaração de variáveis.
    Descrição: Crie um script que calcule o valor de uma parcela de um empréstimo, dado o valor total do empréstimo, a taxa de juros e o número de parcelas. Exemplo de fórmula:
Valor do Empréstimo×(1+Taxa de Juros) Número de Parcelas
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o número de parcelas.*/
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

    /* 05 - Conversor de Moeda 
Objetivo: Trabalhar com variáveis, operadores e arredondamento.
Descrição: Crie um script que converta uma quantia em reais para
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor
convertido com 2 casas decimais.
Dica: Use round() para arredondar o valor para 2 casas decimais.*/
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

    /*06 - Calculadora de Desconto 6. Calculadora de Desconto
Objetivo: Cálculos matemáticos e uso de variáveis.
Descrição: Crie um script que calcule o valor do desconto de um produto, dado o preço original e a porcentagem de desconto. Exemplo de fórmula:
Preço Original (Preço Original x Desconto)
Dica: Use variáveis para armazenar o preço e a porcentagem do desconto e calcule o valor final.
    */
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
