/*
 * GABARITO - Exercício 05: Switch e Switch Expression
 * 
 * Tópicos cobertos:
 * - Switch tradicional
 * - Switch expression (C# 8.0+)
 * - Múltiplos casos
 * - Quando usar switch vs if/else
 */

using System;

class Exercicio05
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 05 - SWITCH E SWITCH EXPRESSION ===\n");

        // ===== TAREFA 1: Menu de Operações =====
        
        int opcaoMenu = 3;

        Console.WriteLine("=== MENU DE OPERAÇÕES ===");
        Console.WriteLine("1. Cadastrar produto");
        Console.WriteLine("2. Consultar estoque");
        Console.WriteLine("3. Realizar venda");
        Console.WriteLine("4. Emitir relatório");
        Console.WriteLine("5. Sair");
        Console.WriteLine();
        Console.WriteLine($"Opção escolhida: {opcaoMenu}");
        
        // Switch tradicional
        switch (opcaoMenu)
        {
            case 1:
                Console.WriteLine("➡️ Cadastrando novo produto...");
                break;
            case 2:
                Console.WriteLine("➡️ Consultando estoque...");
                break;
            case 3:
                Console.WriteLine("➡️ Realizando venda...");
                break;
            case 4:
                Console.WriteLine("➡️ Emitindo relatório...");
                break;
            case 5:
                Console.WriteLine("➡️ Encerrando sistema...");
                break;
            default:
                Console.WriteLine("❌ Opção inválida!");
                break;
        }
        Console.WriteLine();

        // ===== TAREFA 2: Categorização de Produtos =====
        
        char codigoCategoria = 'E';

        Console.WriteLine("=== CATEGORIZAÇÃO DE PRODUTOS ===");
        Console.WriteLine($"Código da Categoria: {codigoCategoria}");
        Console.WriteLine();

        // Switch com múltiplos casos
        switch (codigoCategoria)
        {
            case 'A':
                Console.WriteLine("Categoria: Alimentos");
                Console.WriteLine("Características:");
                Console.WriteLine("- Validade curta");
                Console.WriteLine("- Requer refrigeração");
                break;
            case 'B':
                Console.WriteLine("Categoria: Bebidas");
                Console.WriteLine("Características:");
                Console.WriteLine("- Validade média");
                Console.WriteLine("- Armazenamento normal");
                break;
            case 'E':
                Console.WriteLine("Categoria: Eletrônicos");
                Console.WriteLine("Características:");
                Console.WriteLine("- Sem validade");
                Console.WriteLine("- Requer cuidado especial");
                break;
            case 'L':
                Console.WriteLine("Categoria: Limpeza");
                Console.WriteLine("Características:");
                Console.WriteLine("- Validade longa");
                Console.WriteLine("- Armazenamento normal");
                break;
            case 'H':
                Console.WriteLine("Categoria: Higiene");
                Console.WriteLine("Características:");
                Console.WriteLine("- Validade média");
                Console.WriteLine("- Armazenamento normal");
                break;
            default:
                Console.WriteLine("Categoria desconhecida");
                break;
        }
        Console.WriteLine();

        // ===== TAREFA 3: Cálculo de Imposto (Switch Expression) =====
        
        string nomeProduto = "Notebook";
        string categoriaImposto = "Eletrônicos";
        decimal precoUnitario = 3000.00m;

        // Switch expression - retorna um valor diretamente
        decimal aliquotaImposto = categoriaImposto switch
        {
            "Alimentos" => 0.05m,
            "Bebidas" => 0.15m,
            "Eletrônicos" => 0.25m,
            "Livros" => 0.00m,
            _ => 0.18m  // _ é o default
        };

        decimal valorImposto = precoUnitario * aliquotaImposto;
        decimal precoFinal = precoUnitario + valorImposto;

        Console.WriteLine("=== CÁLCULO DE IMPOSTO ===");
        Console.WriteLine($"Produto: {nomeProduto}");
        Console.WriteLine($"Categoria: {categoriaImposto}");
        Console.WriteLine($"Preço: {precoUnitario:C}");
        Console.WriteLine($"Alíquota: {aliquotaImposto:P}");
        Console.WriteLine($"Valor do Imposto: {valorImposto:C}");
        Console.WriteLine($"Preço Final: {precoFinal:C}");
        Console.WriteLine();

        // ===== TAREFA 4: Prazo de Entrega por Região =====
        
        string regiao = "Sul";

        // Switch expression para determinar prazo
        int prazoEntrega = regiao switch
        {
            "Norte" => 10,
            "Nordeste" => 8,
            "Centro-Oeste" => 7,
            "Sudeste" => 3,
            "Sul" => 5,
            _ => 0  // Região não atendida
        };

        Console.WriteLine("=== PRAZO DE ENTREGA ===");
        Console.WriteLine($"Região: {regiao}");
        
        if (prazoEntrega > 0)
        {
            Console.WriteLine($"Prazo: {prazoEntrega} dias úteis");
            
            // Calcular data estimada (considerando apenas dias corridos para simplificar)
            DateTime dataEstimada = DateTime.Now.AddDays(prazoEntrega);
            Console.WriteLine($"Data Estimada: {dataEstimada:dd/MM/yyyy}");
        }
        
        else
            Console.WriteLine("Região não atendida");

        Console.WriteLine();

        // ===== TAREFA 5: Sistema Combinado =====
        
        string categoriaProduto = "Eletrônicos";
        string formaPagamento = "credito";
        decimal valorProduto = 2000.00m;

        // 1. Imposto por categoria (switch expression)
        decimal aliquotaImposto = categoriaProduto switch
        {
            "Alimentos" => 0.05m,
            "Bebidas" => 0.15m,
            "Eletrônicos" => 0.25m,
            "Livros" => 0.00m,
            _ => 0.18m
        };

        decimal valorComImposto = valorProduto * (1 + aliquotaImposto);

        // 2. Ajuste por forma de pagamento (switch expression)
        decimal ajustePagamento = formaPagamento switch
        {
            "dinheiro" => -0.10m,  // -10% desconto
            "pix" => -0.05m,       // -5% desconto
            "debito" => 0.00m,     // sem alteração
            "credito" => 0.05m,    // +5% acréscimo
            _ => 0.00m
        };

        decimal valorFinalCombinado = valorComImposto * (1 + ajustePagamento);

        Console.WriteLine("=== SISTEMA COMBINADO ===");
        Console.WriteLine($"Categoria: {categoriaProduto}");
        Console.WriteLine($"Valor Original: {valorProduto:C}");
        Console.WriteLine($"Imposto ({aliquotaImposto:P}): {valorComImposto - valorProduto:C}");
        Console.WriteLine($"Valor com Imposto: {valorComImposto:C}");
        Console.WriteLine();
        Console.WriteLine($"Forma de Pagamento: {formaPagamento}");
        Console.WriteLine($"Ajuste ({ajustePagamento:P}): {valorFinalCombinado - valorComImposto:C}");
        Console.WriteLine($"Valor Final: {valorFinalCombinado:C}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 1: Dia da Semana =====
        
        int numeroDia = 3;
        
        string diaSemana = numeroDia switch
        {
            1 => "Domingo",
            2 => "Segunda-feira",
            3 => "Terça-feira",
            4 => "Quarta-feira",
            5 => "Quinta-feira",
            6 => "Sexta-feira",
            7 => "Sábado",
            _ => "Dia inválido"
        };

        Console.WriteLine($"Dia {numeroDia}: {diaSemana}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 2: Conversão de Mês =====
        
        int numeroMes = 6;
        
        string nomeMes = numeroMes switch
        {
            1 => "Janeiro",
            2 => "Fevereiro",
            3 => "Março",
            4 => "Abril",
            5 => "Maio",
            6 => "Junho",
            7 => "Julho",
            8 => "Agosto",
            9 => "Setembro",
            10 => "Outubro",
            11 => "Novembro",
            12 => "Dezembro",
            _ => "Mês inválido"
        };

        Console.WriteLine($"Mês {numeroMes}: {nomeMes}");

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Switch Tradicional:
         *    - Usa case e break
         *    - Pode ter múltiplos statements por case
         *    - Precisa de break para evitar fall-through
         *    - default é opcional mas recomendado
         * 
         * 2. Switch Expression (C# 8.0+):
         *    - Mais conciso
         *    - Retorna um valor diretamente
         *    - Usa => ao invés de :
         *    - Usa _ para default
         *    - Não precisa de break
         * 
         * 3. Quando usar Switch:
         *    - Comparar uma variável com múltiplos valores específicos
         *    - Valores constantes (int, string, char, enum)
         *    - Código mais legível que vários if/else
         * 
         * 4. Quando usar If/Else:
         *    - Condições complexas (ranges, múltiplas variáveis)
         *    - Operadores relacionais (>, <, >=, <=)
         *    - Condições compostas com && ou ||
         * 
         * 5. Múltiplos casos:
         *    case 1:
         *    case 2:
         *    case 3:
         *        // código
         *        break;
         */
    }
}
