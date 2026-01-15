Console.WriteLine("===== Tarefa 1: Cadastro de Produto =====");
Console.WriteLine();

string nomeProduto = "Arroz Integral";
decimal precoProduto = 12.50m;
int quantidadeEstoque = 150;
double pesoProduto = 1.5; 
bool emPromocao = true;
char categoriaProduto = 'A';
DateTime dataValidadeProduto = new (2026, 06, 15);

Console.WriteLine("===== Tarefa 2: Exibição dos Dados =====");
Console.WriteLine();
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço: {precoProduto:C}");
Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque} unidades.");
Console.WriteLine($"Peso: {pesoProduto} kg");
Console.WriteLine($"Em promoção: {(emPromocao ? "Sim" : "Não")}");
Console.WriteLine($"Categoria: {categoriaProduto}");
Console.WriteLine($"Data de validade: {dataValidadeProduto:d}");
Console.WriteLine();

Console.WriteLine("===== Tarefa 3: Uso de var =====");

var nomeProdutoVar = "Feijão Preto";
var precoProdutoVar = 10.99m;
var quantidadeEstoqueVar = 100;
var pesoProdutoVar = 1.0; 
var emPromocaoVar = false;
var categoriaProdutoVar = 'A';
var dataValidadeProdutoVar = new DateTime(2026, 04, 28);

Console.WriteLine();
Console.WriteLine($"Produto: {nomeProdutoVar}");
Console.WriteLine($"Preço: {precoProdutoVar:C}");
Console.WriteLine($"Quantidade em estoque: {quantidadeEstoqueVar} unidades.");
Console.WriteLine($"Peso: {pesoProdutoVar} kg");
Console.WriteLine($"Em promoção: {(emPromocaoVar ? "Sim" : "Não")}");
Console.WriteLine($"Categoria: {categoriaProdutoVar}");
Console.WriteLine($"Data de validade: {dataValidadeProdutoVar:d}");
Console.WriteLine();

Console.WriteLine("===== Desafios Extras =====");

Console.WriteLine();
Console.WriteLine("===== Cálculo de quantos dias faltam para o produto vencer =====");
TimeSpan tempoRestante = dataValidadeProduto - DateTime.Now;
Console.WriteLine($"Faltam {tempoRestante.Days} dias para o produto '{nomeProduto}' vencer.");
TimeSpan tempoRestanteVar = dataValidadeProdutoVar - DateTime.Now;
Console.WriteLine($"Faltam {tempoRestanteVar.Days} dias para o produto '{nomeProdutoVar}' vencer.");
Console.WriteLine();

Console.WriteLine("===== Exiba a data de validade em formato diferente =====");
Console.WriteLine($"Data de validade: {dataValidadeProduto:dd 'de' MMMM 'de' yyyy}");
Console.WriteLine($"Data de validade: {dataValidadeProdutoVar:dd 'de' MMMM 'de' yyyy}");

