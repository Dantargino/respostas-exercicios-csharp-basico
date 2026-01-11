/*
 * GABARITO - Exercício 04: Estruturas Condicionais (if/else)
 * 
 * Tópicos cobertos:
 * - if, else if, else
 * - Condições simples e compostas
 * - Lógica de decisão
 * - Combinação com operadores
 */

using System;

class Exercicio04
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 04 - ESTRUTURAS CONDICIONAIS ===\n");

        // ===== TAREFA 1: Sistema de Descontos Progressivos =====
        
        decimal valorCompra = 350.00m;
        decimal percentualDesconto;
        decimal valorDesconto;
        decimal valorFinal;

        // Estrutura if/else if/else
        // Avalia da condição mais específica para a mais genérica
        if (valorCompra > 500)
            percentualDesconto = 20m;
        
        else if (valorCompra >= 300)
            percentualDesconto = 15m;

        else if (valorCompra >= 100)
            percentualDesconto = 10m;

        else
            percentualDesconto = 0m;

        valorDesconto = valorCompra * (percentualDesconto / 100);
        valorFinal = valorCompra - valorDesconto;

        Console.WriteLine("=== SISTEMA DE DESCONTOS ===");
        Console.WriteLine($"Valor Original: {valorCompra:C}");
        Console.WriteLine($"Desconto Aplicado: {percentualDesconto:P}");
        Console.WriteLine($"Valor do Desconto: {valorDesconto:C}");
        Console.WriteLine($"Valor Final: {valorFinal:C}");
        Console.WriteLine();

        // ===== TAREFA 2: Categorização de Cliente =====
        
        string nomeCliente = "Maria Silva";
        decimal totalGastoMes = 2800.00m;
        bool clienteAntigo = true;
        string categoria;
        string beneficios;

        // Condições compostas com operadores lógicos
        if (totalGastoMes > 5000)
        {
            categoria = "Diamante";
            beneficios = "25% de desconto + frete grátis";
        }
        else if (totalGastoMes >= 2000 && clienteAntigo)
        {
            // Condição composta: ambas devem ser verdadeiras
            categoria = "Ouro";
            beneficios = "15% de desconto + frete grátis";
        }
        else if (totalGastoMes >= 1000)
        {
            categoria = "Prata";
            beneficios = "10% de desconto";
        }
        else
        {
            categoria = "Bronze";
            beneficios = "5% de desconto";
        }

        Console.WriteLine("=== CATEGORIZAÇÃO DE CLIENTE ===");
        Console.WriteLine($"Cliente: {nomeCliente}");
        Console.WriteLine($"Total Gasto no Mês: {totalGastoMes:C}");
        Console.WriteLine($"Cliente há mais de 1 ano: {(clienteAntigo ? "Sim" : "Não")}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Benefícios: {beneficios}");
        Console.WriteLine();

        // ===== TAREFA 3: Validação de Venda com Múltiplas Condições =====
        
        string nomeProduto = "Smart TV 50 polegadas";
        decimal precoUnitario = 2200.00m;
        int quantidadeEstoque = 3;
        int quantidadeSolicitada = 2;
        bool temLimiteCredito = true;
        decimal limiteDisponivel = 3000.00m;
        string formaPagamento = "credito";
        
        decimal valorTotal = precoUnitario * quantidadeSolicitada;
        bool vendaAprovada = false;
        string motivoRecusa = "";

        // Validação em cascata
        if (quantidadeEstoque < quantidadeSolicitada)
            motivoRecusa = "Estoque insuficiente";
        
        else if (formaPagamento != "dinheiro" && formaPagamento != "debito" && formaPagamento != "credito" && formaPagamento != "pix")
            motivoRecusa = "Forma de pagamento inválida";
        
        else if (formaPagamento == "credito")
        {
            // Validação específica para crédito
            if (!temLimiteCredito)
                motivoRecusa = "Cliente não possui limite de crédito";
            
            else if (limiteDisponivel < valorTotal)
                motivoRecusa = "Limite de crédito insuficiente";

            else
                vendaAprovada = true;
        }
        else
            // Outras formas de pagamento aprovadas automaticamente
            vendaAprovada = true;

        Console.WriteLine("=== VALIDAÇÃO DE VENDA ===");
        Console.WriteLine($"Produto: {nomeProduto}");
        Console.WriteLine($"Preço: {precoUnitario:C}");
        Console.WriteLine($"Quantidade Solicitada: {quantidadeSolicitada}");
        Console.WriteLine($"Valor Total: {valorTotal:C}");
        Console.WriteLine($"Estoque: {quantidadeEstoque}");
        Console.WriteLine($"Forma de Pagamento: {formaPagamento}");
        Console.WriteLine($"Limite Disponível: {limiteDisponivel:C}");
        Console.WriteLine();
        
        if (vendaAprovada)
            Console.WriteLine("VENDA APROVADA!");

        else
            Console.WriteLine($"VENDA RECUSADA: {motivoRecusa}");

        Console.WriteLine();

        // ===== TAREFA 4: Alerta de Estoque =====
        
        string nomeProduto1 = "Arroz 5kg";
        int quantidadeEstoque1 = 15;
        int estoqueMinimo = 20;
        int estoqueMaximo = 100;
        int diasProximaEntrega = 3;
        
        string statusEstoque;
        string acaoRecomendada;

        if (quantidadeEstoque1 < estoqueMinimo && diasProximaEntrega > 5)
        {
            statusEstoque = "🔴 CRÍTICO";
            acaoRecomendada = "Realizar pedido URGENTE de reabastecimento!";
        }
        else if (quantidadeEstoque1 < estoqueMinimo && diasProximaEntrega <= 5)
        {
            statusEstoque = "⚠️ ATENÇÃO";
            acaoRecomendada = "Monitorar estoque. Entrega programada em breve.";
        }
        else if (quantidadeEstoque1 >= estoqueMinimo && quantidadeEstoque1 <= estoqueMaximo)
        {
            statusEstoque = "✅ NORMAL";
            acaoRecomendada = "Nenhuma ação necessária.";
        }
        else  // quantidadeEstoque > estoqueMaximo
        {
            statusEstoque = "📦 EXCESSO";
            acaoRecomendada = "Considerar promoção para reduzir estoque.";
        }

        Console.WriteLine("=== ALERTA DE ESTOQUE ===");
        Console.WriteLine($"Produto: {nomeProduto1}");
        Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque1}");
        Console.WriteLine($"Estoque Mínimo: {estoqueMinimo}");
        Console.WriteLine($"Estoque Máximo: {estoqueMaximo}");
        Console.WriteLine($"Dias até próxima entrega: {diasProximaEntrega}");
        Console.WriteLine();
        Console.WriteLine($"Status: {statusEstoque}");
        Console.WriteLine($"Ação Recomendada: {acaoRecomendada}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA: Frete Grátis =====
        
        decimal valorCompra2 = 250.00m;
        decimal valorFrete;
        
        if (valorCompra2 >= 200)
        {
            Console.WriteLine($"🎉 Frete GRÁTIS para compras acima de R$ 200!");
        }
        else
        {
            valorFrete = 15.00m;
            Console.WriteLine($"Valor do frete: {valorFrete:C}");
        }

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Estrutura if/else:
         *    - if: primeira condição
         *    - else if: condições alternativas (quantas forem necessárias)
         *    - else: caso nenhuma condição anterior seja verdadeira
         * 
         * 2. Ordem das condições:
         *    - Coloque condições mais específicas primeiro
         *    - Condições mais genéricas por último
         *    - Exemplo: > 500 antes de > 100
         * 
         * 3. Condições compostas:
         *    - Use && quando TODAS as condições devem ser verdadeiras
         *    - Use || quando PELO MENOS UMA deve ser verdadeira
         *    - Use parênteses para clareza
         * 
         * 4. Boas práticas:
         *    - Sempre use chaves {} mesmo para uma linha
         *    - Evite ifs aninhados demais (máximo 3 níveis)
         *    - Use variáveis booleanas para condições complexas
         *    - Considere early return para simplificar
         * 
         * 5. Validação em cascata:
         *    - Valide condições críticas primeiro
         *    - Use else if para evitar verificações desnecessárias
         *    - Armazene mensagens de erro para feedback claro
         */
    }
}
