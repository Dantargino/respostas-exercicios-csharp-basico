/*
 * GABARITO - Exercício 06: Loop For
 * 
 * Tópicos cobertos:
 * - Estrutura for
 * - Incrementos e decrementos
 * - Processamento de múltiplos itens
 * - Acumuladores e contadores
 */

using System;

class Exercicio06
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 06 - LOOP FOR ===\n");

        // ===== TAREFA 1: Processamento de Múltiplos Produtos =====
        
        decimal[] precos = [50.00m, 120.00m, 80.00m, 200.00m, 45.00m];
        decimal totalVenda;

        Console.WriteLine("=== PROCESSAMENTO DE VENDA ===");
        
        for (int i = 0; i < precos.Length; i++)
        {
            Console.WriteLine($"Produto {i + 1}: {precos[i]:C}");
            totalVenda += precos[i];  // Acumular total
        }
        
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Total da Venda: {totalVenda:C}");
        Console.WriteLine();

        // ===== TAREFA 2: Relatório de Estoque =====
        
        int estoqueMinimo = 10;
        int produtosEmAlerta;

        Console.WriteLine("=== RELATÓRIO DE ESTOQUE ===");
        
        for (int i = 1; i <= 10; i++)
        {
            string codigoProduto = $"PROD{i:D3}";  // D3 = 3 dígitos (PROD001, PROD002...)
            int estoqueAtual = 15 - i;
            
            string alerta = "";
            if (estoqueAtual < estoqueMinimo)
            {
                alerta = " ⚠️ ALERTA";
                produtosEmAlerta++;
            }
            
            Console.WriteLine($"{codigoProduto} - Estoque: {estoqueAtual} unidades{alerta}");
        }
        
        Console.WriteLine();
        Console.WriteLine($"Total de produtos em alerta: {produtosEmAlerta}");
        Console.WriteLine();

        // ===== TAREFA 3: Cálculo de Parcelas =====
        
        decimal valorTotal = 1200.00m;
        int numeroParcelas = 6;
        decimal taxaJuros = 0.02m;  // 2% por parcela
        
        decimal valorParcela = valorTotal / numeroParcelas;
        decimal totalPago = 0;

        Console.WriteLine("=== PLANO DE PARCELAMENTO ===");
        Console.WriteLine($"Valor Total: {valorTotal:C}");
        Console.WriteLine($"Número de Parcelas: {numeroParcelas}x");
        Console.WriteLine($"Taxa de Juros: {taxaJuros:P} por parcela");
        Console.WriteLine();

        for (int parcela = 1; parcela <= numeroParcelas; parcela++)
        {
            // Juros compostos: valor * (1 + taxa)^parcela
            decimal valorComJuros = valorParcela * (decimal)Math.Pow((double)(1 + taxaJuros), parcela);
            totalPago += valorComJuros;
            
            // Data de vencimento (30 dias entre parcelas)
            DateTime dataVencimento = DateTime.Now.AddDays(30 * parcela);
            
            Console.WriteLine($"Parcela {parcela}: {valorComJuros:C} - Vencimento: {dataVencimento:dd/MM/yyyy}");
        }
        
        Console.WriteLine();
        Console.WriteLine($"Total Pago ao Final: {totalPago:C}");
        Console.WriteLine($"Juros Totais: {totalPago - valorTotal:C}");
        Console.WriteLine();

        // ===== TAREFA 4: Contagem Regressiva de Promoção =====
        
        Console.WriteLine("=== CONTAGEM REGRESSIVA ===");
        
        // Loop decrescente
        for (int dias = 10; dias >= 1; dias--)
        {
            Console.Write($"Faltam {dias} dias para o fim da promoção");
            
            if (dias <= 3 && dias > 1)
                Console.Write(" ⚠️ ÚLTIMOS DIAS!");

            else if (dias == 1)
                Console.Write(" 🔥 ÚLTIMO DIA DE PROMOÇÃO!");
            
            Console.WriteLine();
        }
        Console.WriteLine();

        // ===== TAREFA 5: Processamento com Condições =====
        
        decimal totalVendas;
        int vendasAcima300;
        decimal maiorVenda = decimal.MinValue;
        decimal menorVenda = decimal.MaxValue;

        Console.WriteLine("=== PROCESSAMENTO DE 20 VENDAS ===");
        
        for (int venda = 1; venda <= 20; venda++)
        {
            decimal valorVenda;
            
            // Vendas ímpares: R$ 50 a R$ 150
            // Vendas pares: R$ 200 a R$ 500
            if (venda % 2 != 0)  // Ímpar
                valorVenda = 50 + (venda * 5);  // Valores variados

            else  // Par
                valorVenda = 200 + (venda * 10);  // Valores variados

            // Acumular total
            totalVendas += valorVenda;
            
            // Contar vendas acima de R$ 300
            if (valorVenda > 300)
                vendasAcima300++;
            
            // Encontrar maior e menor
            if (valorVenda > maiorVenda)
                maiorVenda = valorVenda;

            if (valorVenda < menorVenda)
                menorVenda = valorVenda;
            
            Console.WriteLine($"Venda {venda:D2}: {valorVenda:C}");
        }
        
        decimal mediaVendas = totalVendas / 20;
        
        Console.WriteLine();
        Console.WriteLine("=== ESTATÍSTICAS ===");
        Console.WriteLine($"Total de Vendas: {totalVendas:C}");
        Console.WriteLine($"Vendas acima de R$ 300: {vendasAcima300}");
        Console.WriteLine($"Média por Venda: {mediaVendas:C}");
        Console.WriteLine($"Maior Venda: {maiorVenda:C}");
        Console.WriteLine($"Menor Venda: {menorVenda:C}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 1: Tabuada =====
        
        int numero = 7;
        
        Console.WriteLine($"=== TABUADA DO {numero} ===");
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{numero} x {i} = {numero * i}");

        Console.WriteLine();

        // ===== DESAFIO EXTRA 2: Padrão de Estrelas =====
        
        Console.WriteLine("=== PADRÃO DE ESTRELAS ===");
        for (int linha = 1; linha <= 5; linha++)
        {
            for (int estrela = 1; estrela <= linha; estrela++)
                Console.Write("*");

            Console.WriteLine();
        }

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Estrutura do For:
         *    for (inicialização; condição; incremento)
         *    {
         *        // código
         *    }
         * 
         * 2. Partes do For:
         *    - Inicialização: executada uma vez no início
         *    - Condição: verificada antes de cada iteração
         *    - Incremento: executado após cada iteração
         * 
         * 3. Variações de Incremento:
         *    i++    : incrementa 1
         *    i--    : decrementa 1
         *    i += 2 : incrementa 2
         *    i *= 2 : multiplica por 2
         * 
         * 4. Arrays e Length:
         *    - array.Length retorna o tamanho do array
         *    - Índices vão de 0 a Length-1
         *    - for (int i = 0; i < array.Length; i++)
         * 
         * 5. Acumuladores:
         *    - Inicialize antes do loop
         *    - Atualize dentro do loop
         *    - Use após o loop
         * 
         * 6. Encontrar Maior/Menor:
         *    decimal maior = decimal.MinValue;
         *    decimal menor = decimal.MaxValue;
         *    
         *    if (valor > maior) maior = valor;
         *    if (valor < menor) menor = valor;
         */
    }
}
