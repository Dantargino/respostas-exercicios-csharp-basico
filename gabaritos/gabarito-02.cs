/*
 * GABARITO - Exercício 02: Operadores Aritméticos
 * 
 * Tópicos cobertos:
 * - Operadores: +, -, *, /, %
 * - Cálculos com diferentes tipos numéricos
 * - Aplicação prática em cenários de venda
 */

using System;

class Exercicio02
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 02 - OPERADORES ARITMÉTICOS ===\n");

        // ===== TAREFA 1: Cálculo de Venda Simples =====
        
        string nomeProduto = "Notebook";
        decimal precoUnitario = 2500.00m;
        int quantidadeComprada = 2;

        // Multiplicação para calcular subtotal
        decimal subtotal = precoUnitario * quantidadeComprada;
        
        // Cálculo de porcentagem (10% = 0.10)
        decimal percentualDesconto = 10m;
        decimal valorDesconto = subtotal * (percentualDesconto / 100);
        
        // Subtração para calcular total
        decimal totalPagar = subtotal - valorDesconto;

        Console.WriteLine("=== CÁLCULO DE VENDA ===");
        Console.WriteLine($"Produto: {nomeProduto}");
        Console.WriteLine($"Preço Unitário: {precoUnitario:C}");
        Console.WriteLine($"Quantidade: {quantidadeComprada}");
        Console.WriteLine();
        Console.WriteLine($"Subtotal: {subtotal:C}");
        Console.WriteLine($"Desconto ({percentualDesconto:P}): {valorDesconto:C}");
        Console.WriteLine($"Total a Pagar: {totalPagar:C}");
        Console.WriteLine();

        // ===== TAREFA 2: Cálculo de Troco =====
        
        decimal valorPago = 5000.00m;
        decimal troco = valorPago - totalPagar;

        Console.WriteLine("=== CÁLCULO DE TROCO ===");
        Console.WriteLine($"Total a Pagar: {totalPagar:C}");
        Console.WriteLine($"Valor Pago: {valorPago:C}");
        Console.WriteLine($"Troco: {troco:C}");
        Console.WriteLine();

        // ===== TAREFA 3: Divisão em Parcelas =====
        
        int numeroParcelas = 3;
        
        // Divisão para calcular valor da parcela
        decimal valorParcela = totalPagar / numeroParcelas;
        
        // Operador módulo (%) retorna o resto da divisão
        decimal restoDivisao = totalPagar % numeroParcelas;

        Console.WriteLine("=== PARCELAMENTO ===");
        Console.WriteLine($"Total a Pagar: {totalPagar:C}");
        Console.WriteLine($"Número de Parcelas: {numeroParcelas}x");
        Console.WriteLine($"Valor de cada Parcela: {valorParcela:C}");
        Console.WriteLine($"Resto da Divisão: {restoDivisao:C}");
        Console.WriteLine();

        // ===== TAREFA 4: Múltiplos Produtos =====
        
        // Produto 1
        string nomeProduto1 = "Mouse";
        decimal precoUnitario1 = 45.00m;
        int quantidadeComprada1 = 5;
        decimal subtotal1 = precoUnitario1 * quantidadeComprada1;

        // Produto 2
        string nomeProduto2 = "Teclado";
        decimal precoUnitario2 = 120.00m;
        int quantidadeComprada2 = 3;
        decimal subtotal2 = precoUnitario2 * quantidadeComprada2;

        // Produto 3
        string nomeProduto3 = "Monitor";
        decimal precoUnitario3 = 800.00m;
        int quantidadeComprada3 = 2;
        decimal subtotal3 = precoUnitario3 * quantidadeComprada3;

        // Soma de todos os subtotais
        decimal totalGeral = subtotal1 + subtotal2 + subtotal3;
        
        // Desconto de 15%
        decimal descontoGeral = totalGeral * 0.15m;
        decimal valorFinal = totalGeral - descontoGeral;

        Console.WriteLine("=== COMPRA MÚLTIPLOS PRODUTOS ===");
        Console.WriteLine($"{nomeProduto1} - {quantidadeComprada1} x {precoUnitario1:C} = {subtotal1:C}");
        Console.WriteLine($"{nomeProduto2} - {quantidadeComprada2} x {precoUnitario2:C} = {subtotal2:C}");
        Console.WriteLine($"{nomeProduto3} - {quantidadeComprada3} x {precoUnitario3:C} = {subtotal3:C}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Total Geral: {totalGeral:C}");
        Console.WriteLine($"Desconto (15%): {descontoGeral:C}");
        Console.WriteLine($"Valor Final: {valorFinal:C}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 1: Economia em porcentagem =====
        
        decimal economiaPercentual = descontoGeral / totalGeral * 100;
        Console.WriteLine("=== ECONOMIA ===");
        Console.WriteLine($"Você economizou: {descontoGeral:C} ({economiaPercentual:P})");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 2: Taxa de entrega =====
        
        decimal taxaEntrega = 50.00m;
        decimal valorComEntrega = valorFinal + taxaEntrega;
        
        Console.WriteLine("=== COM TAXA DE ENTREGA ===");
        Console.WriteLine($"Valor Final: {valorFinal:C}");
        Console.WriteLine($"Taxa de Entrega: {taxaEntrega:C}");
        Console.WriteLine($"Total com Entrega: {valorComEntrega:C}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 3: Valor médio por produto =====
        
        int quantidadeTotal = quantidadeComprada1 + quantidadeComprada2 + quantidadeComprada3;
        decimal valorMedio = totalGeral / quantidadeTotal;
        
        Console.WriteLine("=== ESTATÍSTICAS ===");
        Console.WriteLine($"Quantidade Total de Itens: {quantidadeTotal}");
        Console.WriteLine($"Valor Médio por Item: {valorMedio:C}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 4: Cashback =====
        
        decimal percentualCashback = 5m;
        decimal valorCashback = valorFinal * (percentualCashback / 100);
        
        Console.WriteLine("=== CASHBACK ===");
        Console.WriteLine($"Valor da Compra: {valorFinal:C}");
        Console.WriteLine($"Cashback ({percentualCashback:P}): {valorCashback:C}");
        Console.WriteLine($"Você receberá {valorCashback:C} de volta!");

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Ordem das operações (precedência):
         *    - Parênteses ()
         *    - Multiplicação * e Divisão /
         *    - Adição + e Subtração -
         *    Exemplo: 10 + 5 * 2 = 20 (não 30)
         *             (10 + 5) * 2 = 30
         * 
         * 2. Divisão entre inteiros:
         *    - int / int = int (resultado truncado)
         *    - 10 / 3 = 3 (não 3.333...)
         *    - Para resultado decimal, use: 10.0 / 3 ou (decimal)10 / 3
         * 
         * 3. Operador Módulo (%):
         *    - Retorna o resto da divisão
         *    - Útil para verificar se número é par/ímpar
         *    - Útil para distribuir valores
         *    Exemplo: 10 % 3 = 1 (10 ÷ 3 = 3 com resto 1)
         * 
         * 4. Cálculo de porcentagem:
         *    - Desconto: valor * (percentual / 100)
         *    - Acréscimo: valor * (1 + percentual / 100)
         *    - Percentual: (parte / total) * 100
         * 
         * 5. Precisão com decimal:
         *    - Sempre use 'm' em literais: 10.50m
         *    - Evita erros de arredondamento em valores monetários
         */
    }
}
