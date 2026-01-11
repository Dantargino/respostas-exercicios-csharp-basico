# Exercício 11 - Arrays e Matrizes

## 🎯 Objetivos de Aprendizagem

- Declarar e inicializar arrays (vetores)
- Acessar elementos por índice
- Percorrer arrays com for e foreach
- Trabalhar com arrays multidimensionais (matrizes)
- Usar propriedades Length e GetLength

## 📝 Cenário

O sistema da loja precisa trabalhar com conjuntos de dados relacionados: tabela de preços de produtos, controle de vendas diárias, estoque de múltiplos produtos e relatórios semanais.

## 📋 Tarefas

### Tarefa 1: Array de Preços

Crie um array com os preços de 5 produtos:

- R$ 12.50, R$ 8.90, R$ 25.00, R$ 15.75, R$ 30.00

Exiba:

1. Todos os preços
2. O primeiro preço (índice 0)
3. O último preço
4. Quantidade total de produtos (Length)

### Tarefa 2: Percorrer Array e Calcular Total

Use o array de preços da Tarefa 1 e:

1. Percorra com `for` e calcule o total
2. Encontre o maior preço
3. Encontre o menor preço
4. Calcule a média de preços

### Tarefa 3: Array de Nomes com Foreach

Crie um array com nomes de produtos:

- "Arroz", "Feijão", "Macarrão", "Óleo", "Açúcar"

Use `foreach` para:

1. Exibir todos os produtos numerados
2. Contar quantos produtos têm mais de 5 letras

### Tarefa 4: Buscar Produto por Índice

Crie dois arrays paralelos:

- Produtos: ["Mouse", "Teclado", "Monitor", "Webcam", "Fone"]
- Preços: [45.90, 120.00, 899.00, 250.00, 89.90]

Simule uma busca:

- Índice do produto: 2
- Exiba: "Produto: Monitor - Preço: R$ 899,00"

### Tarefa 5: Matriz de Vendas (2D)

Crie uma matriz 3x7 (3 produtos × 7 dias da semana) representando vendas diárias:

```
Produtos: Arroz, Feijão, Óleo
Dias: Dom, Seg, Ter, Qua, Qui, Sex, Sab

Vendas:
          Dom  Seg  Ter  Qua  Qui  Sex  Sab
Arroz:     10   15   12   18   20   25   30
Feijão:     8   10   14   12   16   18   22
Óleo:       5    7    6    9   10   12   15
```

Exiba a matriz formatada.

### Tarefa 6: Análise da Matriz

Usando a matriz da Tarefa 5, calcule:

1. **Total de vendas por produto** (soma de cada linha)
2. **Total de vendas por dia** (soma de cada coluna)
3. **Qual produto vendeu mais** (no total da semana)
4. **Qual dia teve mais vendas** (total de todos produtos)
5. **Total geral de vendas** (soma de tudo)

### Tarefa 7: Atualizar Valores do Array

Crie um array de quantidades em estoque:

- [100, 50, 75, 200, 30]

Simule vendas:

1. Venda de 20 unidades do produto no índice 0
2. Venda de 10 unidades do produto no índice 2
3. Reposição de 50 unidades do produto no índice 4

Exiba o estoque antes e depois das operações.

## 💡 Conceitos Importantes

### Declaração e Inicialização de Arrays

```csharp
// Forma 1: Declarar e inicializar com valores
int[] numeros = { 10, 20, 30, 40, 50 };

// Forma 2: Declarar com tamanho e inicializar depois
string[] produtos = new string[5];
produtos[0] = "Arroz";
produtos[1] = "Feijão";
// ...

// Forma 3: new com valores
decimal[] precos = new decimal[] { 12.50m, 8.90m, 25.00m };

// Forma 4: Declarar com tamanho (valores padrão: 0, null, false)
int[] valores = new int[10];  // Todos inicializados com 0
```

### Acessar Elementos

```csharp
string[] frutas = { "Maçã", "Banana", "Laranja" };

// Acessar por índice (começa em 0)
string primeira = frutas[0];     // "Maçã"
string segunda = frutas[1];      // "Banana"
string ultima = frutas[2];       // "Laranja"

// Modificar valor
frutas[1] = "Uva";

// Tamanho do array
int tamanho = frutas.Length;     // 3
```

### Percorrer com For

```csharp
int[] numeros = { 10, 20, 30, 40, 50 };

// Percorrer com for
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Índice {i}: {numeros[i]}");
}

// Calcular soma
int soma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    soma += numeros[i];
}
```

### Percorrer com Foreach

```csharp
string[] produtos = { "Arroz", "Feijão", "Óleo" };

// Foreach - mais simples, mas não tem índice
foreach (string produto in produtos)
{
    Console.WriteLine(produto);
}

// Foreach com index usando variável externa
int indice = 0;
foreach (string produto in produtos)
{
    Console.WriteLine($"{indice}: {produto}");
    indice++;
}
```

### Arrays Multidimensionais (Matrizes)

```csharp
// Matriz 3x3 (3 linhas, 3 colunas)
int[,] matriz = new int[3, 3];

// Inicializar com valores
int[,] vendas = {
    { 10, 15, 20 },  // Linha 0
    { 12, 18, 22 },  // Linha 1
    { 8,  10, 15 }   // Linha 2
};

// Acessar elementos
int valor = vendas[0, 1];  // Linha 0, Coluna 1 = 15

// Modificar
vendas[2, 2] = 25;

// Dimensões
int linhas = vendas.GetLength(0);    // 3
int colunas = vendas.GetLength(1);   // 3
```

### Percorrer Matriz (2D)

```csharp
int[,] matriz = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

// Nested loops para percorrer
for (int linha = 0; linha < matriz.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write($"{matriz[linha, coluna]} ");
    }
    Console.WriteLine();  // Nova linha
}
```

## ✅ Exemplo de Saída Esperada (Tarefa 6)

```
=== ANÁLISE DE VENDAS SEMANAIS ===

Total por Produto:
Arroz: 130 unidades
Feijão: 100 unidades
Óleo: 64 unidades

Total por Dia:
Domingo: 23 unidades
Segunda: 32 unidades
Terça: 32 unidades
Quarta: 39 unidades
Quinta: 46 unidades
Sexta: 55 unidades
Sábado: 67 unidades

Produto mais vendido: Arroz (130 unidades)
Dia com mais vendas: Sábado (67 unidades)
Total Geral: 294 unidades
```

## 🎓 Desafios Extras

1. **Ordenação**: Ordene um array de preços do menor para o maior usando `Array.Sort()`
2. **Array Reverso**: Inverta a ordem de um array usando `Array.Reverse()`
3. **Busca**: Use `Array.IndexOf()` para encontrar a posição de um elemento
4. **Cópia**: Crie uma cópia de um array usando `Array.Copy()`
5. **Matriz 3D**: Crie uma matriz 3D (4x3x7) representando vendas de 4 lojas, 3 produtos, 7 dias

## 📌 Dicas

- Arrays têm **tamanho fixo** - não podem crescer ou diminuir
- Índices começam em **0** - último índice é `Length - 1`
- Acessar índice inválido causa `IndexOutOfRangeException`
- Use `for` quando precisar do índice, `foreach` quando não precisar
- `.Length` retorna o tamanho total do array
- `.GetLength(dimensão)` retorna tamanho de uma dimensão específica (matrizes)
- Arrays são tipos de referência - cuidado ao copiar
- Para arrays dinâmicos (que podem crescer), use `List<T>` (próximo exercício)

## 🔗 Navegação

- [← Exercício Anterior](exercicio-10-enum.md) - Enum
- [Próximo Exercício →](exercicio-12-listas.md) - Listas (List<T>)
