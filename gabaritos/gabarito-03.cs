/*
 * GABARITO - Exercício 03: Operadores Relacionais e Lógicos
 * 
 * Tópicos cobertos:
 * - Operadores relacionais: ==, !=, >, <, >=, <=
 * - Operadores lógicos: &&, ||, !
 * - Expressões lógicas compostas
 * - Validação de dados
 */

using System;

class Exercicio03
{
    static void Main()
    {
        Console.WriteLine("=== EXERCÍCIO 03 - OPERADORES RELACIONAIS E LÓGICOS ===\n");

        // ===== TAREFA 1: Validação de Estoque =====
        
        string nomeProduto = "Leite Integral";
        int quantidadeEstoque = 50;
        int quantidadeSolicitada = 30;
        int estoqueMinimo = 20;

        // Operador relacional: <= (menor ou igual)
        bool quantidadeDisponivel = quantidadeSolicitada <= quantidadeEstoque;
        
        // Operador relacional: < (menor que)
        bool estoqueAbaixoMinimo = quantidadeEstoque < estoqueMinimo;
        
        // Operadores: -, <
        int estoqueAposVenda = quantidadeEstoque - quantidadeSolicitada;
        bool ficaraAbaixoMinimo = estoqueAposVenda < estoqueMinimo;

        Console.WriteLine("=== VALIDAÇÃO DE ESTOQUE ===");
        Console.WriteLine($"Produto: {nomeProduto}");
        Console.WriteLine($"Estoque Atual: {quantidadeEstoque}");
        Console.WriteLine($"Quantidade Solicitada: {quantidadeSolicitada}");
        Console.WriteLine($"Estoque Mínimo: {estoqueMinimo}");
        Console.WriteLine();
        Console.WriteLine($"Quantidade disponível? {quantidadeDisponivel}");
        Console.WriteLine($"Estoque abaixo do mínimo? {estoqueAbaixoMinimo}");
        Console.WriteLine($"Estoque ficará abaixo do mínimo após venda? {ficaraAbaixoMinimo}");
        Console.WriteLine();

        // ===== TAREFA 2: Verificação de Promoção =====
        
        string nomeProduto1 = "Chocolate";
        decimal preco1 = 8.50m;
        int quantidadeEstoque1 = 100;
        DateTime dataValidade1 = new DateTime(2026, 2, 10);
        DateTime dataAtual = DateTime.Now;

        // Operador relacional: <=
        bool precoElegivel = preco1 <= 10.00m;
        
        // Operador relacional: >
        bool estoqueElegivel = quantidadeEstoque1 > 50;
        
        // Cálculo de dias e operador >
        int diasParaVencer = (dataValidade1 - dataAtual).Days;
        bool validadeElegivel = diasParaVencer > 30;

        // Operador lógico: && (E) - TODAS as condições devem ser verdadeiras
        bool elegivelPromocao = precoElegivel && estoqueElegivel && validadeElegivel;

        Console.WriteLine("=== VERIFICAÇÃO DE PROMOÇÃO ===");
        Console.WriteLine($"Produto: {nomeProduto1}");
        Console.WriteLine($"Preço: {preco1:C}");
        Console.WriteLine($"Estoque: {quantidadeEstoque1}");
        Console.WriteLine($"Data de Validade: {dataValidade1:dd/MM/yyyy}");
        Console.WriteLine($"Dias para vencer: {diasParaVencer}");
        Console.WriteLine();
        Console.WriteLine($"Preço elegível (≤ R$ 10)? {precoElegivel}");
        Console.WriteLine($"Estoque elegível (> 50)? {estoqueElegivel}");
        Console.WriteLine($"Validade elegível (> 30 dias)? {validadeElegivel}");
        Console.WriteLine($"Elegível para promoção? {elegivelPromocao}");
        Console.WriteLine();

        // ===== TAREFA 3: Validação de Compra =====
        
        decimal valorTotalCompra = 250.00m;
        decimal valorPagoCompra = 300.00m;
        bool clienteVIP = true;
        bool temCupom = false;

        // Operador relacional: >=
        bool pagamentoSuficiente = valorPagoCompra >= valorTotalCompra;
        
        // Operador lógico: || (OU) - PELO MENOS UMA condição deve ser verdadeira
        bool direitoDescontoExtra = clienteVIP || temCupom;
        
        // Operador lógico: ! (NÃO) - inverte o valor booleano
        bool naoEhVIP = !clienteVIP;
        
        // Operador lógico: && (E)
        bool descontoEspecial = clienteVIP && temCupom;

        Console.WriteLine("=== VALIDAÇÃO DE COMPRA ===");
        Console.WriteLine($"Valor Total: {valorTotalCompra:C}");
        Console.WriteLine($"Valor Pago: {valorPagoCompra:C}");
        Console.WriteLine($"Cliente VIP: {clienteVIP}");
        Console.WriteLine($"Tem Cupom: {temCupom}");
        Console.WriteLine();
        Console.WriteLine($"Pagamento suficiente? {pagamentoSuficiente}");
        Console.WriteLine($"Direito a desconto extra? {direitoDescontoExtra}");
        Console.WriteLine($"Cliente NÃO é VIP? {naoEhVIP}");
        Console.WriteLine($"Desconto especial (VIP + Cupom)? {descontoEspecial}");
        Console.WriteLine();

        // ===== TAREFA 4: Validação Complexa =====
        
        string nomeProduto2 = "Notebook Gamer";
        decimal preco2 = 4500.00m;
        int quantidadeEstoque2 = 5;
        int quantidadeSolicitada2 = 2;
        bool clienteTemCredito = true;
        decimal limiteCredito = 5000.00m;
        bool blackFriday = true;

        // Verificações individuais
        bool temEstoqueSuficiente = quantidadeEstoque2 >= quantidadeSolicitada2;
        
        decimal valorTotal2 = preco2 * quantidadeSolicitada2;
        bool limiteSuficiente = limiteCredito >= valorTotal2;
        
        // Expressão complexa com && e ||
        // Parênteses definem a ordem de avaliação
        bool vendaAprovada = temEstoqueSuficiente && 
                            ((clienteTemCredito && limiteSuficiente) || blackFriday);

        Console.WriteLine("=== VALIDAÇÃO COMPLEXA DE VENDA ===");
        Console.WriteLine($"Produto: {nomeProduto2}");
        Console.WriteLine($"Preço: {preco2:C}");
        Console.WriteLine($"Estoque: {quantidadeEstoque2}");
        Console.WriteLine($"Quantidade Solicitada: {quantidadeSolicitada2}");
        Console.WriteLine($"Valor Total: {valorTotal2:C}");
        Console.WriteLine($"Cliente tem crédito: {clienteTemCredito}");
        Console.WriteLine($"Limite de crédito: {limiteCredito:C}");
        Console.WriteLine($"É Black Friday: {blackFriday}");
        Console.WriteLine();
        Console.WriteLine($"Tem estoque suficiente? {temEstoqueSuficiente}");
        Console.WriteLine($"Limite suficiente? {limiteSuficiente}");
        Console.WriteLine($"VENDA APROVADA? {vendaAprovada}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 1: Produto perto de vencer =====
        
        DateTime validadeProduto = DateTime.Now.AddDays(5);
        int diasRestantes = (validadeProduto - DateTime.Now).Days;
        bool pertoDeVencer = diasRestantes < 7;
        
        Console.WriteLine("=== PRODUTO PERTO DE VENCER ===");
        Console.WriteLine($"Dias restantes: {diasRestantes}");
        Console.WriteLine($"Perto de vencer (< 7 dias)? {pertoDeVencer}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 2: Pode parcelar =====
        
        decimal valorCompra = 150.00m;
        int parcelas = 10;
        bool podeParcelar = valorCompra > 100 && parcelas <= 12;
        
        Console.WriteLine("=== VALIDAÇÃO DE PARCELAMENTO ===");
        Console.WriteLine($"Valor: {valorCompra:C}");
        Console.WriteLine($"Parcelas: {parcelas}x");
        Console.WriteLine($"Pode parcelar? {podeParcelar}");
        Console.WriteLine();

        // ===== DESAFIO EXTRA 3: Regra de desconto complexa =====
        
        int quantidadeComprada = 15;
        bool clienteVIP2 = false;
        bool descontoDe20 = quantidadeComprada > 10 || clienteVIP2;
        
        Console.WriteLine("=== DESCONTO DE 20% ===");
        Console.WriteLine($"Quantidade: {quantidadeComprada}");
        Console.WriteLine($"Cliente VIP: {clienteVIP2}");
        Console.WriteLine($"Tem desconto de 20%? {descontoDe20}");

        /*
         * OBSERVAÇÕES IMPORTANTES:
         * 
         * 1. Operadores Relacionais:
         *    == : igual a
         *    != : diferente de
         *    >  : maior que
         *    <  : menor que
         *    >= : maior ou igual a
         *    <= : menor ou igual a
         * 
         * 2. Operadores Lógicos:
         *    && : E (AND) - ambos devem ser true
         *    || : OU (OR) - pelo menos um deve ser true
         *    !  : NÃO (NOT) - inverte o valor
         * 
         * 3. Tabela Verdade (&&):
         *    true  && true  = true
         *    true  && false = false
         *    false && true  = false
         *    false && false = false
         * 
         * 4. Tabela Verdade (||):
         *    true  || true  = true
         *    true  || false = true
         *    false || true  = true
         *    false || false = false
         * 
         * 5. Precedência:
         *    ! (maior precedência)
         *    &&
         *    || (menor precedência)
         *    Use parênteses para clareza!
         * 
         * 6. Curto-circuito:
         *    - && para se o primeiro for false
         *    - || para se o primeiro for true
         */
    }
}
