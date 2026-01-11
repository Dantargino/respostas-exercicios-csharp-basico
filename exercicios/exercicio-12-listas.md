# Exercício 12 - Listas (List<T>)

## 🎯 Objetivos de Aprendizagem

- Criar e inicializar listas (List<T>)
- Adicionar e remover elementos
- Buscar elementos (Contains, IndexOf)
- Percorrer listas
- Entender a diferença entre List<T> e arrays

## 📝 Cenário

O sistema da loja precisa de coleções dinâmicas que podem crescer e diminuir conforme necessário: carrinho de compras, lista de produtos em estoque, histórico de vendas e gerenciamento de pedidos.

## 📋 Tarefas

### Tarefa 1: Criar Carrinho de Compras

Crie um `List<string>` para simular um carrinho de compras:

1. Adicione 3 produtos: "Arroz", "Feijão", "Óleo"
2. Exiba todos os produtos do carrinho
3. Exiba a quantidade de itens no carrinho (Count)

### Tarefa 2: Adicionar e Remover Produtos

Use o carrinho da Tarefa 1 e:

1. Adicione mais 2 produtos: "Açúcar", "Macarrão"
2. Remova "Óleo" usando `Remove()`
3. Adicione "Café" no início da lista usando `Insert(0, item)`
4. Remova o último item usando `RemoveAt(Count - 1)`
5. Exiba o carrinho final

### Tarefa 3: Buscar Produtos

Crie uma lista de produtos disponíveis:

- ["Mouse", "Teclado", "Monitor", "Webcam", "Fone", "Mousepad"]

Faça as seguintes buscas:

1. Verifique se "Monitor" está na lista usando `Contains()`
2. Encontre o índice de "Webcam" usando `IndexOf()`
3. Tente encontrar "Impressora" (não existe) e trate adequadamente

### Tarefa 4: Lista de Preços

Crie um `List<decimal>` com preços:

- [12.50, 8.90, 25.00, 15.75, 30.00]

1. Calcule o total de todos os preços
2. Encontre o maior preço
3. Encontre o menor preço
4. Adicione 20% em todos os preços (percorra e atualize)
5. Exiba a lista atualizada

### Tarefa 5: Limpar e Refazer Lista

Crie uma lista de produtos:

- ["Produto A", "Produto B", "Produto C"]

1. Exiba a lista original
2. Limpe a lista usando `Clear()`
3. Verifique se está vazia
4. Adicione novos produtos: ["Novo 1", "Novo 2", "Novo 3", "Novo 4"]
5. Exiba a nova lista

### Tarefa 6: Sistema de Pedidos

Crie um sistema que gerencia pedidos usando `List<string>`:

1. Crie lista de pedidos pendentes
2. Adicione 5 pedidos: "Pedido #001", "Pedido #002", etc.
3. "Processe" o primeiro pedido (remova da lista)
4. Adicione um novo pedido "Pedido #006"
5. Exiba quantos pedidos estão pendentes
6. Liste todos os pedidos pendentes

### Tarefa 7: Combinar Arrays e Listas

Você tem um array de produtos vendidos hoje:

- string[] vendasHoje = { "Arroz", "Feijão", "Arroz", "Óleo", "Açúcar" }

1. Converta o array para uma lista usando `new List<string>(array)`
2. Conte quantas vezes "Arroz" aparece na lista
3. Remova todas as ocorrências de "Arroz"
4. Adicione "Macarrão" 3 vezes
5. Exiba relatório final

## 💡 Conceitos Importantes

### Criar e Inicializar List

```csharp
// Forma 1: Lista vazia
List<string> produtos = new List<string>();

// Forma 2: Com valores iniciais
List<int> numeros = new List<int> { 10, 20, 30, 40 };

// Forma 3: A partir de array
string[] array = { "A", "B", "C" };
List<string> lista = new List<string>(array);

// Forma 4: Com capacidade inicial (otimização)
List<decimal> precos = new List<decimal>(100);  // Capacidade para 100 itens
```

### Adicionar Elementos

```csharp
List<string> frutas = new List<string>();

// Adicionar no final
frutas.Add("Maçã");
frutas.Add("Banana");

// Adicionar vários de uma vez
frutas.AddRange(new[] { "Laranja", "Uva" });

// Inserir em posição específica
frutas.Insert(0, "Morango");  // Insere no início
```

### Remover Elementos

```csharp
List<string> itens = new List<string> { "A", "B", "C", "D" };

// Remover por valor (remove primeira ocorrência)
itens.Remove("B");

// Remover por índice
itens.RemoveAt(0);  // Remove primeiro item

// Remover último item
itens.RemoveAt(itens.Count - 1);

// Limpar toda a lista
itens.Clear();
```

### Buscar e Verificar

```csharp
List<string> produtos = new List<string> { "Mouse", "Teclado", "Monitor" };

// Verificar se contém
bool temMouse = produtos.Contains("Mouse");  // true
bool temImpressora = produtos.Contains("Impressora");  // false

// Encontrar índice
int indice = produtos.IndexOf("Teclado");  // 1
int naoExiste = produtos.IndexOf("Webcam");  // -1 (não encontrado)

// Quantidade de elementos
int quantidade = produtos.Count;
```

### Percorrer Lista

```csharp
List<string> nomes = new List<string> { "Ana", "Bruno", "Carlos" };

// Foreach
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

// For (com índice)
for (int i = 0; i < nomes.Count; i++)
{
    Console.WriteLine($"{i}: {nomes[i]}");
}

// Acessar por índice
string primeiro = nomes[0];
string ultimo = nomes[nomes.Count - 1];
```

### Modificar Elementos

```csharp
List<int> numeros = new List<int> { 10, 20, 30 };

// Modificar por índice
numeros[1] = 25;  // Troca 20 por 25

// Atualizar todos os valores
for (int i = 0; i < numeros.Count; i++)
{
    numeros[i] *= 2;  // Dobra todos os valores
}
```

### List vs Array

| Característica | Array             | List<T>              |
| -------------- | ----------------- | -------------------- |
| Tamanho        | Fixo              | Dinâmico             |
| Adicionar item | ❌ Não pode       | ✅ Add()             |
| Remover item   | ❌ Não pode       | ✅ Remove()          |
| Sintaxe        | `int[]`           | `List<int>`          |
| Performance    | Mais rápido       | Levemente mais lento |
| Uso            | Tamanho conhecido | Tamanho variável     |

## ✅ Exemplo de Saída Esperada (Tarefa 6)

```
=== SISTEMA DE PEDIDOS ===

Adicionando 5 pedidos...
Pedidos pendentes: 5

Processando Pedido #001...
Adicionando Pedido #006...

Pedidos pendentes atuais: 5

Lista de Pedidos:
  1. Pedido #002
  2. Pedido #003
  3. Pedido #004
  4. Pedido #005
  5. Pedido #006
```

## 🎓 Desafios Extras

1. **Sort**: Use `lista.Sort()` para ordenar uma lista de preços
2. **Reverse**: Use `lista.Reverse()` para inverter a ordem
3. **Find**: Use `lista.Find(x => x.StartsWith("A"))` para buscar primeiro item que começa com "A"
4. **RemoveAll**: Use `lista.RemoveAll(x => x.Contains("tmp"))` para remover todos que contêm "tmp"
5. **Distinct**: Remova duplicatas convertendo para HashSet e depois de volta para List

## 📌 Dicas

- Use `List<T>` quando não souber o tamanho final da coleção
- `Count` retorna quantidade de elementos (diferente de `Length` de arrays)
- `Add()` adiciona no final, `Insert()` adiciona em posição específica
- `Remove()` remove primeira ocorrência, `RemoveAt()` remove por índice
- `IndexOf()` retorna -1 se não encontrar o elemento
- `Contains()` é mais rápido que verificar `IndexOf() >= 0`
- Lista é mais lenta que array, mas muito mais flexível
- Use `new List<T>(capacity)` se souber tamanho aproximado (otimização)

## 🔗 Navegação

- [← Exercício Anterior](exercicio-11-arrays-matrizes.md) - Arrays e Matrizes
- [Próximo Exercício →](exercicio-13-strings.md) - Strings
