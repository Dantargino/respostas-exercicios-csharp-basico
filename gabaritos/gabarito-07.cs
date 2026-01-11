/*
 * GABARITO - Exercício 07: Loop While
 * 
 * Tópicos cobertos:
 * - Estrutura while
 * - Condições de parada
 * - Diferença entre for e while
 * - Loops baseados em eventos
 */

using System;

class Exercicio07
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 07 - LOOP WHILE ===\n");

        // ===== TAREFA 1: Sistema de Caixa Simples =====
        
        decimal[] vendas = [150.00m, 80.00m, 220.00m, 95.00m, 0m];
        int indiceVenda;
        decimal totalCaixa;
        int quantidadeVendas;

        Console.WriteLine("=== SISTEMA DE CAIXA ===");
        
        // While continua enquanto não encontrar 0
        while (vendas[indiceVenda] != 0)
        {
            decimal valorVenda = vendas[indiceVenda];
            quantidadeVendas++;
            totalCaixa += valorVenda;
            
            Console.WriteLine($"Venda {quantidadeVendas}: {valorVenda:C}");
            
            indiceVenda++;
        }
        
        Console.WriteLine("Encerrando caixa...");
        Console.WriteLine();
        
        decimal ticketMedio = quantidadeVendas > 0 ? totalCaixa / quantidadeVendas : 0;
        
        Console.WriteLine("=== RESUMO DO CAIXA ===");
        Console.WriteLine($"Total de Vendas: {quantidadeVendas}");
        Console.WriteLine($"Valor Total: {totalCaixa:C}");
        Console.WriteLine($"Ticket Médio: {ticketMedio:C}");
        Console.WriteLine();

        // ===== TAREFA 2: Validação de Senha =====
        
        string senhaCorreta = "loja2026";
        string[] tentativasSenha = [ "senha123", "loja2025", "loja2026" ];
        int indiceTentativa;
        int tentativasMaximas = 3;
        int tentativasRealizadas;
        bool senhaCorretaDigitada = false;

        Console.WriteLine("=== SISTEMA DE LOGIN ===");
        
        while (tentativasRealizadas < tentativasMaximas && !senhaCorretaDigitada)
        {
            tentativasRealizadas++;
            string senhaDigitada = tentativasSenha[indiceTentativa];
            
            Console.WriteLine($"Tentativa {tentativasRealizadas}: Digite a senha");
            Console.WriteLine($"Senha digitada: {senhaDigitada}");
            
            if (senhaDigitada == senhaCorreta)
            {
                senhaCorretaDigitada = true;
                Console.WriteLine("✅ Senha correta! Acesso liberado.");
            }
            
            else
                Console.WriteLine($"❌ Senha incorreta. Tentativas restantes: {tentativasMaximas - tentativasRealizadas}");
            
            Console.WriteLine();
            indiceTentativa++;
        }
        
        if (!senhaCorretaDigitada)
        {
            Console.WriteLine("🔒 Acesso bloqueado! Número máximo de tentativas excedido.");
            Console.WriteLine();
        }

        // ===== TAREFA 3: Reabastecimento de Estoque =====
        
        string nomeProduto = "Água Mineral";
        int estoqueAtual = 45;
        int estoqueDesejado = 100;
        int quantidadePorCaixa = 12;
        int caixasAdicionadas;

        Console.WriteLine("=== REABASTECIMENTO DE ESTOQUE ===");
        Console.WriteLine($"Produto: {nomeProduto}");
        Console.WriteLine($"Estoque Inicial: {estoqueAtual}");
        Console.WriteLine($"Estoque Desejado: {estoqueDesejado}");
        Console.WriteLine($"Quantidade por Caixa: {quantidadePorCaixa}");
        Console.WriteLine();

        while (estoqueAtual < estoqueDesejado)
        {
            estoqueAtual += quantidadePorCaixa;
            caixasAdicionadas++;
            Console.WriteLine($"Caixa {caixasAdicionadas} adicionada. Estoque atual: {estoqueAtual}");
        }
        
        int excedente = estoqueAtual - estoqueDesejado;
        
        Console.WriteLine();
        Console.WriteLine("=== RESULTADO ===");
        Console.WriteLine($"Caixas Adicionadas: {caixasAdicionadas}");
        Console.WriteLine($"Estoque Final: {estoqueAtual}");
        Console.WriteLine($"Excedente: {excedente} unidades");
        Console.WriteLine();

        // ===== TAREFA 4: Processamento de Vendas com Meta =====
        
        decimal metaDiaria = 5000.00m;
        decimal[] vendasDia = [850.00m, 1200.00m, 650.00m, 980.00m, 1500.00m, 420.00m];
        int indiceVendaDia;
        decimal totalDia;
        int vendasProcessadas;

        Console.WriteLine("=== PROCESSAMENTO DE VENDAS COM META ===");
        Console.WriteLine($"Meta Diária: {metaDiaria:C}");
        Console.WriteLine();

        while (totalDia < metaDiaria && indiceVendaDia < vendasDia.Length)
        {
            decimal venda = vendasDia[indiceVendaDia];
            vendasProcessadas++;
            totalDia += venda;
            
            Console.WriteLine($"Venda {vendasProcessadas}: {venda:C} - Total: {totalDia:C}");
            
            indiceVendaDia++;
        }
        
        decimal diferenca = totalDia - metaDiaria;
        decimal mediaPorVenda = vendasProcessadas > 0 ? totalDia / vendasProcessadas : 0;
        
        Console.WriteLine();
        Console.WriteLine("=== RESULTADO ===");
        Console.WriteLine($"Vendas Processadas: {vendasProcessadas}");
        Console.WriteLine($"Total Arrecadado: {totalDia:C}");
        Console.WriteLine($"Meta: {metaDiaria:C}");
        
        if (totalDia >= metaDiaria)
            Console.WriteLine($"✅ Meta atingida! Ultrapassou em: {diferenca:C}");

        else
            Console.WriteLine($"❌ Meta não atingida. Faltaram: {Math.Abs(diferenca):C}");
        
        Console.WriteLine($"Valor Médio por Venda: {mediaPorVenda:C}");
        Console.WriteLine();

        // ===== TAREFA 5: Menu Interativo =====
        
        int[] escolhas = [ 1, 2, 3, 1, 0 ];
        int indiceEscolha;
        int opcao = -1;

        Console.WriteLine("=== MENU INTERATIVO ===");
        
        while (opcao != 0)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Consultar Estoque");
            Console.WriteLine("2 - Registrar Venda");
            Console.WriteLine("3 - Emitir Relatório");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            
            opcao = escolhas[indiceEscolha];
            Console.WriteLine($"Opção escolhida: {opcao}");
            
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("➡️ Consultando estoque...");
                    break;
                case 2:
                    Console.WriteLine("➡️ Registrando venda...");
                    break;
                case 3:
                    Console.WriteLine("➡️ Emitindo relatório...");
                    break;
                case 0:
                    Console.WriteLine("➡️ Encerrando sistema...");
                    break;
                default:
                    Console.WriteLine("❌ Opção inválida!");
                    break;
            }
            
            indiceEscolha++;
        }
        
        Console.WriteLine();
        Console.WriteLine("Sistema encerrado.");

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Estrutura While:
         *    while (condição)
         *    {
         *        // código
         *    }
         *    
         *    - Verifica a condição ANTES de executar
         *    - Pode não executar nenhuma vez se condição for falsa
         * 
         * 2. Do-While (alternativa):
         *    do
         *    {
         *        // código
         *    } while (condição);
         *    
         *    - Executa PELO MENOS UMA VEZ
         *    - Verifica condição no final
         * 
         * 3. For vs While:
         *    - Use FOR quando sabe quantas iterações
         *    - Use WHILE quando depende de uma condição
         * 
         * 4. Evitar Loop Infinito:
         *    - Sempre garanta que a condição eventualmente se torne falsa
         *    - Atualize variáveis de controle dentro do loop
         *    - Use break como escape de emergência
         * 
         * 5. Condições Compostas:
         *    while (total < meta && vendas < 10)
         *    - Usa && ou || para múltiplas condições
         *    - Cuidado com a lógica para evitar loops infinitos
         * 
         * 6. Flags (Bandeiras):
         *    bool continuar = true;
         *    while (continuar)
         *    {
         *        if (condicao) continuar = false;
         *    }
         */
    }
}
