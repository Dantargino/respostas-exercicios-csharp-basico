/*
 * GABARITO - Exercício 08: Foreach e Controle de Fluxo
 * 
 * Tópicos cobertos:
 * - Foreach para iterar sobre coleções
 * - break para interromper loops
 * - continue para pular iterações
 * - Integração de todos os conceitos aprendidos
 */

using System;

class Exercicio08
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 08 - FOREACH E CONTROLE DE FLUXO ===\n");

        // ===== TAREFA 1: Processamento de Lista de Produtos =====
        
        decimal[] precos = [45.90m, 120.00m, 8.50m, 250.00m, 15.75m, 89.90m, 5.00m, 180.00m];
        
        decimal total;
        int produtosAcima50;
        decimal produtoMaisCaro = decimal.MinValue;
        decimal produtoMaisBarato = decimal.MaxValue;
        int indice;

        Console.WriteLine("=== PROCESSAMENTO DE PRODUTOS ===");
        
        foreach (decimal preco in precos)
        {
            indice++;
            Console.WriteLine($"Produto {indice}: {preco:C}");
            
            // Acumular total
            total += preco;
            
            // Contar produtos acima de R$ 50
            if (preco > 50.00m)
                produtosAcima50++;
            
            // Encontrar maior e menor
            if (preco > produtoMaisCaro)
                produtoMaisCaro = preco;

            if (preco < produtoMaisBarato)
                produtoMaisBarato = preco;
        }
        
        Console.WriteLine();
        Console.WriteLine($"Total: {total:C}");
        Console.WriteLine($"Produtos acima de R$ 50: {produtosAcima50}");
        Console.WriteLine($"Produto mais caro: {produtoMaisCaro:C}");
        Console.WriteLine($"Produto mais barato: {produtoMaisBarato:C}");
        Console.WriteLine();

        // ===== TAREFA 2: Filtro de Produtos com Continue =====
        
        decimal totalFiltrado;
        int processados;
        int ignorados;

        Console.WriteLine("=== FILTRO DE PRODUTOS (R$ 10 a R$ 100) ===");
        
        foreach (decimal preco in precos)
        {
            // Continue pula para a próxima iteração
            if (preco < 10.00m || preco > 100.00m)
            {
                ignorados++;
                continue;  // Pula o resto do código e vai para o próximo item
            }
            
            // Este código só executa se não pulou com continue
            processados++;
            totalFiltrado += preco;
            Console.WriteLine($"Produto processado: {preco:C}");
        }
        
        Console.WriteLine();
        Console.WriteLine($"Produtos processados: {processados}");
        Console.WriteLine($"Produtos ignorados: {ignorados}");
        Console.WriteLine($"Total filtrado: {totalFiltrado:C}");
        Console.WriteLine();

        // ===== TAREFA 3: Busca de Produto com Break =====
        
        string[] produtos = ["Arroz", "Feijão", "Macarrão", "Óleo", "Açúcar", "Café", "Leite", "Pão"];
        string produtoBuscado = "Óleo";
        bool produtoEncontrado; 
        int produtosVerificados;

        Console.WriteLine("=== BUSCA DE PRODUTO ===");
        Console.WriteLine($"Procurando por: {produtoBuscado}");
        Console.WriteLine();
        
        foreach (string produto in produtos)
        {
            produtosVerificados++;
            Console.WriteLine($"Verificando: {produto}");
            
            if (produto == produtoBuscado)
            {
                produtoEncontrado = true;
                Console.WriteLine($"✅ Produto encontrado!");
                break;  // Para o loop imediatamente
            }
        }
        
        Console.WriteLine();
        Console.WriteLine($"Produtos verificados: {produtosVerificados}");
        
        if (!produtoEncontrado)
            Console.WriteLine("❌ Produto não encontrado");

        Console.WriteLine();

        // ===== TAREFA 4: Processamento com Múltiplas Condições =====
        
        string[] nomesProdutos = ["Notebook", "Mouse", "Teclado", "Monitor", "Webcam", "Headset"];
        decimal[] precosEletronicos = [2500.00m, 45.00m, 120.00m, 800.00m, 150.00m, 200.00m];
        int[] estoques = [5, 50, 30, 8, 15, 20];
        
        decimal valorTotalEstoque;

        Console.WriteLine("=== PROCESSAMENTO DE ELETRÔNICOS ===");
        Console.WriteLine();
        
        for (int i; i < nomesProdutos.Length; i++)
        {
            // Continue para pular produtos sem estoque
            if (estoques[i] == 0)
            {
                Console.WriteLine($"{nomesProdutos[i]} - SEM ESTOQUE (ignorado)");
                continue;
            }
            
            decimal precoFinal = precosEletronicos[i];
            string observacao = "";
            
            // Aplicar desconto se estoque > 20
            if (estoques[i] > 20)
            {
                precoFinal = precoFinal * 0.90m;  // 10% desconto
                observacao = " (10% desconto aplicado)";
            }
            
            // Marcar estoque baixo
            string alerta = "";
            if (estoques[i] < 10)
                alerta = " ⚠️ ESTOQUE BAIXO";
            
            decimal valorEstoque = precoFinal * estoques[i];
            valorTotalEstoque += valorEstoque;
            
            Console.WriteLine($"{nomesProdutos[i]}:");
            Console.WriteLine($"  Preço: {precoFinal:C}{observacao}");
            Console.WriteLine($"  Estoque: {estoques[i]} unidades{alerta}");
            Console.WriteLine($"  Valor em Estoque: {valorEstoque:C}");
            Console.WriteLine();
        }
        
        Console.WriteLine($"Valor Total do Estoque: {valorTotalEstoque:C}");
        Console.WriteLine();

        // ===== TAREFA 5: Sistema Completo de Relatório =====
        
        string[] produtosVenda = ["Produto A", "Produto B", "Produto C", "Produto D", "Produto E"];
        decimal[] valoresVenda = [150.00m, 0m, 300.00m, 75.00m, 0m];
        bool[] pagamentosAprovados = [true, false, true, true, false];
        
        decimal totalVendasAprovadas;
        int vendasProcessadas;
        int vendasCanceladas;
        bool metaAtingida;

        Console.WriteLine("=== RELATÓRIO DE VENDAS ===");
        Console.WriteLine();
        
        for (int i; i < produtosVenda.Length; i++)
        {
            // Continue para vendas canceladas (valor)
            if (valoresVenda[i] == 0)
            {
                Console.WriteLine($"{produtosVenda[i]} - VENDA CANCELADA");
                vendasCanceladas++;
                continue;
            }
            
            // Continue para pagamentos não aprovados
            if (!pagamentosAprovados[i])
            {
                Console.WriteLine($"{produtosVenda[i]} - PAGAMENTO NÃO APROVADO");
                vendasCanceladas++;
                continue;
            }
            
            // Venda válida
            vendasProcessadas++;
            totalVendasAprovadas += valoresVenda[i];
            Console.WriteLine($"{produtosVenda[i]} - {valoresVenda[i]:C} ✅");
            
            // Break se atingir meta
            if (totalVendasAprovadas > 500)
            {
                metaAtingida = true;
                Console.WriteLine();
                Console.WriteLine("🎉 META ATINGIDA!");
                break;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("=== RESUMO ===");
        Console.WriteLine($"Vendas Processadas: {vendasProcessadas}");
        Console.WriteLine($"Vendas Canceladas: {vendasCanceladas}");
        Console.WriteLine($"Total de Vendas Aprovadas: {totalVendasAprovadas:C}");
        Console.WriteLine($"Meta Atingida: {(metaAtingida ? "Sim" : "Não")}");
        Console.WriteLine();

        // ===== TAREFA 6: Desafio Final - Sistema Integrado =====
        
        string[] produtosCompra = ["Arroz", "Feijão", "Óleo", "Açúcar", "Café"];
        decimal[] precosCompra = [25.00m, 8.50m, 12.00m, 6.00m, 15.00m];
        int[] quantidadesCompra = [3, 5, 2, 4, 1];
        
        decimal totalCompra;

        Console.WriteLine("=== SISTEMA INTEGRADO - COMPRA COMPLETA ===");
        Console.WriteLine();
        
        // 1. Calcular subtotais
        for (int i; i < produtosCompra.Length; i++)
        {
            decimal subtotal = precosCompra[i] * quantidadesCompra[i];
            totalCompra += subtotal;
            
            Console.WriteLine($"{produtosCompra[i]}:");
            Console.WriteLine($"  {quantidadesCompra[i]}x {precosCompra[i]:C} = {subtotal:C}");
        }
        
        Console.WriteLine();
        Console.WriteLine($"Total: {totalCompra:C}");
        Console.WriteLine();
        
        // 2. Desconto progressivo (if/else)
        decimal percentualDesconto;
        
        if (totalCompra > 100)
            percentualDesconto = 10m;

        else if (totalCompra >= 50)
            percentualDesconto = 5m;

        else
            percentualDesconto = 0m;

        
        decimal valorDesconto = totalCompra * (percentualDesconto / 100);
        decimal totalFinal = totalCompra - valorDesconto;
        
        Console.WriteLine($"Desconto ({percentualDesconto:P}): {valorDesconto:C}");
        Console.WriteLine($"Total Final: {totalFinal:C}");
        Console.WriteLine();
        
        // 3. Categorização (switch)
        string categoriaCompra = totalFinal switch
        {
            < 50 => "Compra Pequena",
            >= 50 and <= 150 => "Compra Média",
            > 150 => "Compra Grande",
            _ => "Indefinido"
        };
        
        Console.WriteLine($"Categoria: {categoriaCompra}");
        Console.WriteLine();
        Console.WriteLine("🎉 Parabéns! Você completou todos os exercícios!");

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Foreach:
         *    foreach (tipo variavel in colecao)
         *    {
         *        // código
         *    }
         *    
         *    - Percorre TODOS os elementos
         *    - Não permite modificar a coleção
         *    - Mais limpo que for quando não precisa de índice
         * 
         * 2. Continue:
         *    - Pula para a próxima iteração
         *    - Útil para filtrar elementos
         *    - Evita ifs aninhados
         * 
         * 3. Break:
         *    - Para o loop imediatamente
         *    - Útil para buscas
         *    - Economiza processamento
         * 
         * 4. Foreach vs For:
         *    - Foreach: quando percorre todos os elementos
         *    - For: quando precisa de índice ou controle preciso
         * 
         * 5. Padrões Comuns:
         *    - Busca com break: para quando encontrar
         *    - Filtro com continue: pula elementos indesejados
         *    - Acumuladores: soma, contagem, média
         *    - Maior/menor: comparação em cada iteração
         * 
         * 6. Integração de Conceitos:
         *    - Tipos de dados: variáveis corretas
         *    - Operadores: cálculos e comparações
         *    - Condicionais: decisões
         *    - Loops: repetição
         *    - Controle de fluxo: otimização
         */
    }
}
