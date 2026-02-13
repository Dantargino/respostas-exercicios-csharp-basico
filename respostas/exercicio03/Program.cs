Console.WriteLine("===== Tarefa 1: Validação de Estoque =====");
Console.WriteLine();

string nomeProduto = "Leite Integral";
int quantidadeEstoque = 50;
int quantidadeSolicitada = 30;
int estoqueMinimo = 20;

bool quantidadeDisponivel = quantidadeSolicitada <= quantidadeEstoque;

bool estoqueBaixo = quantidadeEstoque < estoqueMinimo;

Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Estoque inicial: {quantidadeEstoque}");
Console.WriteLine($"Quantidade solicitada: {quantidadeSolicitada}");
Console.WriteLine($"Estoque mínimo: {estoqueMinimo}");
Console.WriteLine($"Estoque disponível: {(quantidadeDisponivel ? "Sim" : "Não")}");
Console.WriteLine($"Estoque baixo: {(estoqueBaixo ? "Sim" : "Não")}");

int estoqueAposVenda = quantidadeEstoque - quantidadeSolicitada;
bool ficaraAbaixoMinimo = estoqueAposVenda < estoqueMinimo;

Console.WriteLine();
Console.WriteLine($"Quantidade em estoque após venda: {estoqueAposVenda}");
Console.WriteLine($"Estoque abaixo do mínimo: {(ficaraAbaixoMinimo ? "Sim" : "Não")}");
Console.WriteLine();

Console.WriteLine("===== Tarefa 2: Verificação de Promoção =====");
Console.WriteLine();

string novoNomeProduto = "Chocolate";
decimal novoPrecoProduto = 8.50m;
int novaQuantidadeEstoque = 100;
bool novoProdutoEmPromocao = false; 
DateTime dataValidade = new DateTime(2026, 03, 10);
DateTime dataAtual = DateTime.Now;

TimeSpan validadeProduto = dataValidade - dataAtual;

if (novoPrecoProduto <= 10.00m && novaQuantidadeEstoque > 50 && validadeProduto.Days > 30)
    novoProdutoEmPromocao = true;

Console.WriteLine($"Produto: {novoNomeProduto}");
Console.WriteLine($"Valor do produto: {novoPrecoProduto:C}");
Console.WriteLine($"Estoque inicial: {novaQuantidadeEstoque}");
Console.WriteLine($"Produto em promoção? {(novoProdutoEmPromocao ? "Sim" : "Não")}");
Console.WriteLine($"Quantidade dias até vencer: {validadeProduto.Days}");
Console.WriteLine();