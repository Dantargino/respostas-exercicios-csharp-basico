Console.WriteLine("===== Tarefa 1: Cálculo de Venda Simples =====");
Console.WriteLine();

string nomeProduto = "Notebook";
decimal precoUnitario = 2500.00m;
int quantidadeComprada = 2;

decimal subtotal = precoUnitario * quantidadeComprada;
decimal descontoCompra = 0.1m;
decimal valorDesconto = subtotal * descontoCompra;
decimal totalAPagar = subtotal - valorDesconto;

Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço Unitário: {precoUnitario:C}");
Console.WriteLine($"Quantidade Comprada: {quantidadeComprada} unidades.");
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Desconto ({descontoCompra:P0}): {valorDesconto:C}");
Console.WriteLine($"Total a Pagar: {totalAPagar:C}");
Console.WriteLine();

Console.WriteLine("===== Tarefa 2: Cálculo de Troco =====");
Console.WriteLine();

decimal valorPago = 5000.00m;
decimal troco = valorPago - totalAPagar;
Console.WriteLine($"Valor Pago: {valorPago:C}");
Console.WriteLine($"Troco: {troco:C}");
Console.WriteLine();

Console.WriteLine("===== Tarefa 3: Divisão em Parcelas =====");
Console.WriteLine();

int numeroParcelas = 3;
decimal valorParcela = totalAPagar / numeroParcelas;
decimal restoDivisao = totalAPagar % numeroParcelas;

Console.WriteLine($"Número de Parcelas: {numeroParcelas}");
Console.WriteLine($"Valor de Cada Parcela: {valorParcela:C}");
Console.WriteLine($"Resto da Divisão: {restoDivisao:C}");
Console.WriteLine();

Console.WriteLine("===== Tarefa 4: Múltiplos Produtos =====");
Console.WriteLine();

string nomeProduto1 = "Mouse";
decimal precoProduto1 = 45.00m;
int quantidadeProduto1 = 5;
string nomeProduto2 = "Teclado";
decimal precoProduto2 = 120.00m;
int quantidadeProduto2 = 3;
string nomeProduto3 = "Monitor";
decimal precoProduto3 = 800.00m;
int quantidadeProduto3 = 2;

decimal subtotalProduto1 = precoProduto1 * quantidadeProduto1;
decimal subtotalProduto2 = precoProduto2 * quantidadeProduto2;
decimal subtotalProduto3 = precoProduto3 * quantidadeProduto3;
decimal totalCompra = subtotalProduto1 + subtotalProduto2 + subtotalProduto3;
decimal porcentagemDescontoCompra = 0.15m;
decimal valorDescontoCompra = totalCompra * porcentagemDescontoCompra;
decimal totalFinalCompra = totalCompra - valorDescontoCompra;

Console.WriteLine($"Valor total do produto {nomeProduto1}: {subtotalProduto1:C}");
Console.WriteLine($"Valor total do produto {nomeProduto2}: {subtotalProduto2:C}");
Console.WriteLine($"Valor total do produto {nomeProduto3}: {subtotalProduto3:C}");
Console.WriteLine($"Total da Compra: {totalCompra:C}");
Console.WriteLine($"Desconto (15%): {valorDescontoCompra:C}");
Console.WriteLine($"Total Final da Compra: {totalFinalCompra:C}");
Console.WriteLine();

Console.WriteLine("===== Desafios Extras =====");
Console.WriteLine();

Console.WriteLine("===== Cálculo de quanto o cliente economizou com o desconto em porcentagem =====");
Console.WriteLine();

decimal valorTotalDescontoCompra = valorDesconto + valorDescontoCompra;
decimal porcentagemTotalDesconto = valorTotalDescontoCompra / (subtotal + totalCompra);
Console.WriteLine($"O cliente economizou {valorTotalDescontoCompra:C} com os descontos.\nO porcentual total de desconto foi de {porcentagemTotalDesconto:P}.");

Console.WriteLine();
Console.WriteLine("===== Adicione uma taxa de entrega de R$ 50,00 ao total =====");
Console.WriteLine();

decimal taxaEntrega = 50.00m;
decimal valorTotalProdutos = totalAPagar + totalFinalCompra;
decimal totalComEntrega = valorTotalProdutos + taxaEntrega;

Console.WriteLine($"Valor da compra do produto '{nomeProduto}': {totalAPagar:C}");
Console.WriteLine($"Valor da compra dos produtos '{nomeProduto1}', '{nomeProduto2}', e '{nomeProduto3}': {totalFinalCompra:C}");
Console.WriteLine($"Valor total dos produtos: {valorTotalProdutos:C}");
Console.WriteLine($"Total com taxa de entrega: {totalComEntrega:C}");
Console.WriteLine();

Console.WriteLine("===== Cálculo do valor médio por produto =====");
Console.WriteLine();

int quantidadeTotalProdutos = quantidadeComprada + quantidadeProduto1 + quantidadeProduto2 + quantidadeProduto3;
decimal valorMedioPorProduto = valorTotalProdutos / quantidadeTotalProdutos;
Console.WriteLine($"O valor médio por produto na compra foi de: {valorMedioPorProduto:C}");
Console.WriteLine();

Console.WriteLine("===== Implemente um sistema de cashback: cliente recebe 5% do valor total de volta =====");
Console.WriteLine();

decimal percentualCashback = 0.05m;
decimal valorCashback = valorTotalProdutos * percentualCashback;

Console.WriteLine($"O cliente recebeu um cashback de: {valorCashback:C} (equivalente a {percentualCashback:P} do valor total da compra).");
Console.WriteLine();

