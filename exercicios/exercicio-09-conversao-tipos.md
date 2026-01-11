# Exercício 09 - Conversão de Tipos (Casting e Parsing)

## 🎯 Objetivos de Aprendizagem

- Entender conversão implícita vs explícita (casting)
- Usar Parse e TryParse para converter strings
- Trabalhar com a classe Convert
- Converter entre int, double e decimal
- Tratar erros de conversão com segurança

## 📝 Cenário

O sistema da loja precisa processar entrada de dados do usuário (que sempre vem como string) e converter para os tipos apropriados. Além disso, é necessário realizar conversões entre diferentes tipos numéricos para cálculos precisos.

## 📋 Tarefas

### Tarefa 1: Parse - Convertendo Entrada do Usuário

Simule a entrada de dados do usuário (como strings) e converta para os tipos corretos:

- Entrada do usuário (strings):
  - Nome do produto: "Chocolate Amargo"
  - Preço: "15.90"
  - Quantidade: "50"
  - Peso em kg: "0.2"

Use `int.Parse()`, `decimal.Parse()` e `double.Parse()` para converter e exibir os dados processados.

### Tarefa 2: TryParse - Conversão Segura

Melhore o sistema anterior usando `TryParse` para validar entradas:

- Entradas válidas:

  - Quantidade: "100"
  - Preço: "25.50"

- Entradas inválidas (para testar):
  - Quantidade inválida: "abc"
  - Preço inválido: "xyz"

Use `int.TryParse()` e `decimal.TryParse()` para validar. Se a conversão falhar, exiba mensagem de erro apropriada.

### Tarefa 3: Casting Explícito

Você tem valores em diferentes tipos e precisa convertê-los:

- Preço original (double): 29.99
- Desconto percentual (int): 15
- Quantidade vendida (double): 10.5

Realize as seguintes conversões:

1. Converta o preço de `double` para `decimal` (para cálculo financeiro preciso)
2. Converta quantidade vendida de `double` para `int` (arredondar para baixo)
3. Mostre a diferença entre conversão implícita e explícita

### Tarefa 4: Classe Convert

Use a classe `Convert` para realizar conversões diversas:

- Preço como string: "199.90"
- Quantidade como string: "5"
- Produto em promoção: "true"

Use:

- `Convert.ToDecimal()`
- `Convert.ToInt32()`
- `Convert.ToBoolean()`
- `Convert.ToString()` para converter números de volta para string

### Tarefa 5: Sistema Completo de Processamento

Crie um sistema que:

1. Receba dados do produto como strings:

   - Nome: "Notebook Gamer"
   - Preço: "3500.00"
   - Quantidade: "3"
   - Desconto (%): "10"

2. Converta usando Parse/TryParse apropriados

3. Calcule:

   - Subtotal (preço × quantidade)
   - Valor do desconto
   - Total final

4. Use casting para converter o total de `decimal` para `double` para exibição

5. Exiba relatório formatado

## 💡 Conceitos Importantes

### Conversão Implícita vs Explícita

```csharp
// Conversão implícita (automática) - de tipo menor para maior
int numInt = 100;
double numDouble = numInt;  // OK - int → double (implícito)

// Conversão explícita (casting) - de tipo maior para menor
double preco = 29.99;
int precoInteiro = (int)preco;  // Necessário casting - perde decimais
Console.WriteLine(precoInteiro);  // 29
```

### Parse - String para Número

```csharp
string textoPreco = "15.90";
string textoQuantidade = "50";

decimal preco = decimal.Parse(textoPreco);
int quantidade = int.Parse(textoQuantidade);

// CUIDADO: Parse lança exceção se a conversão falhar!
// string invalido = "abc";
// int numero = int.Parse(invalido);  // ❌ ERRO em tempo de execução
```

### TryParse - Conversão Segura

```csharp
string entrada = "123";
int numero;

// TryParse retorna true se conseguiu converter, false caso contrário
if (int.TryParse(entrada, out numero))
{
    Console.WriteLine($"Conversão bem-sucedida: {numero}");
}
else
{
    Console.WriteLine("Conversão falhou!");
}

// C# 7.0+ - declaração inline
if (int.TryParse(entrada, out int resultado))
{
    Console.WriteLine($"Número: {resultado}");
}
```

### Classe Convert

```csharp
// Convert oferece vários métodos de conversão
string texto = "100";

int numeroInt = Convert.ToInt32(texto);
double numeroDouble = Convert.ToDouble(texto);
decimal numeroDecimal = Convert.ToDecimal(texto);

// Convert também funciona entre tipos numéricos
double valor = 29.99;
int valorInteiro = Convert.ToInt32(valor);  // Arredonda (30)
int valorCasting = (int)valor;              // Trunca (29)
```

### Casting Entre Tipos Numéricos

```csharp
// double → decimal (explícito)
double valorDouble = 99.99;
decimal valorDecimal = (decimal)valorDouble;

// decimal → int (explícito - perde decimais)
decimal preco = 29.99m;
int precoSemCentavos = (int)preco;  // 29

// int → double (implícito)
int quantidade = 10;
double quantidadeDouble = quantidade;  // OK
```

### ToString - Número para String

```csharp
int quantidade = 100;
decimal preco = 29.99m;

string textoQuantidade = quantidade.ToString();
string textoPreco = preco.ToString();
string textoPrecoFormatado = preco.ToString("C");  // R$ 29,99
```

## ✅ Exemplo de Saída Esperada (Tarefa 2)

```
=== VALIDAÇÃO DE ENTRADA ===

Testando entrada válida:
Quantidade: "100"
✅ Conversão bem-sucedida! Quantidade: 100

Preço: "25.50"
✅ Conversão bem-sucedida! Preço: R$ 25,50

Testando entrada inválida:
Quantidade: "abc"
❌ Erro: Quantidade inválida!

Preço: "xyz"
❌ Erro: Preço inválido!
```

## 🎓 Desafios Extras

1. **Conversão de Data**: Converta string "15/06/2026" para DateTime usando Parse e TryParse
2. **Arredondamento**: Compare `(int)29.9` vs `Convert.ToInt32(29.9)` vs `Math.Round(29.9)`
3. **Conversão Hexadecimal**: Use `Convert.ToInt32("FF", 16)` para converter hexadecimal
4. **Validação Completa**: Crie uma função que valida e converte múltiplas entradas de uma vez

## 📌 Dicas

- **Use TryParse** quando processar entrada do usuário (sempre pode ser inválida)
- **Use Parse** apenas quando tem certeza que o valor é válido
- **Casting `(int)`** trunca (corta) decimais: `(int)29.9 = 29`
- **Convert.ToInt32()** arredonda: `Convert.ToInt32(29.9) = 30`
- Para valores monetários, sempre use `decimal` em vez de `double`
- `out` keyword permite que um método retorne múltiplos valores
- Parse e Convert lançam exceções se a conversão falhar
- TryParse retorna `false` se falhar (mais seguro)

## 🔗 Navegação

- [← Exercício Anterior](exercicio-08-foreach-controle-fluxo.md) - Foreach e Controle de Fluxo
- [Próximo Exercício →](exercicio-10-enum.md) - Enum
