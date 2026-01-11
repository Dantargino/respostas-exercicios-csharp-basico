/*
 * GABARITO - Exercício 01: Tipos de Dados e Variáveis
 * 
 * Tópicos cobertos:
 * - Tipos primitivos: int, double, decimal, bool, char
 * - String e DateTime
 * - Declaração e inicialização de variáveis
 * - var vs tipo explícito
 */

using System;

class Exercicio01
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 01 - TIPOS DE DADOS E VARIÁVEIS ===\n");

        // ===== TAREFA 1: Cadastro de Produto com Tipo Explícito =====
        
        // String - armazena texto
        string nomeProduto = "Arroz Integral";
        
        // Decimal - ideal para valores monetários (maior precisão)
        decimal precoUnitario = 12.50m;  // 'm' indica decimal literal
        
        // Int - números inteiros
        int quantidadeEstoque = 150;
        
        // Double - números com ponto flutuante
        double pesoKg = 1.5;
        
        // Bool - verdadeiro ou falso
        bool emPromocao = true;
        
        // Char - um único caractere (usa aspas simples)
        char categoriaProduto = 'A';  // A = Alimentos
        
        // DateTime - data e hora
        DateTime dataValidade = new DateTime(2026, 6, 15);
        // Alternativa: DateTime dataValidade = DateTime.Parse("15/06/2026");

        // ===== TAREFA 2: Exibição dos Dados =====
        
        Console.WriteLine("=== CADASTRO DE PRODUTO (Tipo Explícito) ===");
        Console.WriteLine($"Nome: {nomeProduto}");
        Console.WriteLine($"Preço: {precoUnitario:C}");  // :C formata como moeda
        Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque} unidades");
        Console.WriteLine($"Peso: {pesoKg} kg");
        Console.WriteLine($"Em Promoção: {(emPromocao ? "Sim" : "Não")}");  // Operador ternário
        Console.WriteLine($"Categoria: {categoriaProduto}");
        Console.WriteLine($"Data de Validade: {dataValidade:dd/MM/yyyy}");  // Formato de data
        Console.WriteLine();

        // ===== TAREFA 3: Uso de var =====
        
        // var - o compilador infere o tipo baseado no valor atribuído
        var nomeProduto2 = "Feijão Preto";        // Inferido como string
        var precoUnitario2 = 8.90m;               // Inferido como decimal
        var quantidadeEstoque2 = 200;             // Inferido como int
        var pesoKg2 = 1.0;                        // Inferido como double
        var emPromocao2 = false;                  // Inferido como bool
        var categoriaProduto2 = 'A';                     // Inferido como char
        var dataValidade2 = new DateTime(2026, 8, 20);  // Inferido como DateTime

        Console.WriteLine("=== CADASTRO DE PRODUTO (usando var) ===");
        Console.WriteLine($"Nome: {nomeProduto2}");
        Console.WriteLine($"Preço: {precoUnitario2:C}");
        Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque2} unidades");
        Console.WriteLine($"Peso: {pesoKg2} kg");
        Console.WriteLine($"Em Promoção: {(emPromocao2 ? "Sim" : "Não")}");
        Console.WriteLine($"Categoria: {categoriaProduto2}");
        Console.WriteLine($"Data de Validade: {dataValidade2:dd/MM/yyyy}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 1: Mais um produto =====
        
        var nomeProduto3 = "Macarrão Integral";
        var precoUnitario3 = 5.75m;
        var quantidadeEstoque3 = 80;
        var pesoKg3 = 0.5;
        var emPromocao3 = true;
        var categoriaProduto3 = 'A';
        var dataValidade3 = new DateTime(2026, 12, 31);

        Console.WriteLine("=== PRODUTO ADICIONAL ===");
        Console.WriteLine($"Nome: {nomeProduto3}");
        Console.WriteLine($"Preço: {precoUnitario3:C}");
        Console.WriteLine($"Quantidade: {quantidadeEstoque3} unidades");
        Console.WriteLine($"Peso: {pesoKg3} kg");
        Console.WriteLine($"Em Promoção: {(emPromocao3 ? "Sim" : "Não")}");
        Console.WriteLine($"Categoria: {categoriaProduto3}");
        Console.WriteLine($"Data de Validade: {dataValidade3:dd/MM/yyyy}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 2: Dias até vencer =====
        
        DateTime hoje = DateTime.Now;
        TimeSpan diasRestantes = dataValidade - hoje;
        
        Console.WriteLine("=== ANÁLISE DE VALIDADE ===");
        Console.WriteLine($"Data de hoje: {hoje:dd/MM/yyyy}");
        Console.WriteLine($"Data de validade: {dataValidade:dd/MM/yyyy}");
        Console.WriteLine($"Dias até vencer: {diasRestantes.Days} dias");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 3: Formato diferente de data =====
        
        Console.WriteLine("=== FORMATOS DE DATA ===");
        Console.WriteLine($"Formato padrão: {dataValidade:dd/MM/yyyy}");
        Console.WriteLine($"Formato extenso: {dataValidade:dd 'de' MMMM 'de' yyyy}");
        Console.WriteLine($"Formato curto: {dataValidade:dd/MM/yy}");
        Console.WriteLine($"Formato americano: {dataValidade:MM/dd/yyyy}");

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Decimal vs Double:
         *    - Use decimal para valores monetários (mais preciso)
         *    - Use double para cálculos científicos/matemáticos
         * 
         * 2. Literal 'm' em decimal:
         *    - Sem 'm': 12.50 é interpretado como double
         *    - Com 'm': 12.50m é interpretado como decimal
         * 
         * 3. var:
         *    - Facilita a escrita do código
         *    - O tipo ainda é fortemente tipado (definido em tempo de compilação)
         *    - Deve ser inicializado na declaração
         *    - Use quando o tipo é óbvio pelo valor atribuído
         * 
         * 4. Formatação de strings:
         *    - :C = moeda (currency)
         *    - :dd/MM/yyyy = formato de data
         *    - Interpolação: $"texto {variavel}"
         */
    }
}
