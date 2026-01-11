# Exercício 08 - Foreach e Controle de Fluxo

## 🎯 Objetivos de Aprendizagem

- Utilizar a estrutura foreach para iterar sobre coleções
- Aplicar break para interromper loops
- Usar continue para pular iterações
- Combinar todos os conceitos aprendidos

## 📝 Cenário

Este é o exercício final! Você vai criar um sistema completo de processamento de produtos que utiliza todos os conceitos aprendidos: tipos de dados, operadores, condicionais, switch e loops. O foreach é ideal para percorrer listas de itens.

## 📋 Tarefas

### Tarefa 1: Processamento de Lista de Produtos

Crie uma lista (array) de preços de produtos:

```csharp
decimal[] precos = { 45.90m, 120.00m, 8.50m, 250.00m, 15.75m, 89.90m, 5.00m, 180.00m };
```

Use foreach para:
1. Exibir cada produto com seu índice e preço
2. Calcular o total
3. Contar quantos produtos custam mais de R$ 50,00
4. Encontrar o produto mais caro e o mais barato

### Tarefa 2: Filtro de Produtos com Continue

Use a mesma lista de preços da Tarefa 1.

Use foreach com continue para:
1. Processar apenas produtos com preço entre R$ 10,00 e R$ 100,00
2. Pular (continue) produtos fora dessa faixa
3. Calcular o total apenas dos produtos filtrados
4. Exibir quantos produtos foram processados e quantos foram ignorados

### Tarefa 3: Busca de Produto com Break

Crie uma lista de nomes de produtos:

```csharp
string[] produtos = { "Arroz", "Feijão", "Macarrão", "Óleo", "Açúcar", "Café", "Leite", "Pão" };
```

Use foreach com break para:
1. Procurar por um produto específico (ex: "Óleo")
2. Quando encontrar, exibir "Produto encontrado!" e parar a busca (break)
3. Contar quantos produtos foram verificados até encontrar
4. Se não encontrar, exibir "Produto não encontrado"

### Tarefa 4: Processamento com Múltiplas Condições

Crie arrays paralelos (mesmo índice representa o mesmo produto):

```csharp
string[] nomes = { "Notebook", "Mouse", "Teclado", "Monitor", "Webcam", "Headset" };
decimal[] precos = { 2500.00m, 45.00m, 120.00m, 800.00m, 150.00m, 200.00m };
int[] estoques = { 5, 50, 30, 8, 15, 20 };
char[] categorias = { 'E', 'E', 'E', 'E', 'E', 'E' };  // E = Eletrônicos
```

Use foreach (ou for com índice) para:
1. Listar todos os produtos com suas informações
2. Aplicar desconto de 10% para produtos com estoque > 20
3. Marcar com "⚠️ ESTOQUE BAIXO" se estoque < 10
4. Calcular o valor total do estoque (preço × quantidade)
5. Usar continue para pular produtos sem estoque

### Tarefa 5: Sistema Completo de Relatório

Crie um sistema que gera um relatório completo de vendas:

```csharp
string[] produtos = { "Produto A", "Produto B", "Produto C", "Produto D", "Produto E" };
decimal[] valores = { 150.00m, 0m, 300.00m, 75.00m, 0m };  // 0 = venda cancelada
bool[] pagamentoAprovado = { true, false, true, true, false };
```

Use foreach para:
1. Processar cada venda
2. Usar continue para pular vendas canceladas (valor = 0)
3. Usar continue para pular vendas com pagamento não aprovado
4. Calcular total de vendas aprovadas
5. Contar vendas processadas vs canceladas
6. Se o total ultrapassar R$ 500, exibir "🎉 META ATINGIDA!" e parar (break)

### Tarefa 6: Desafio Final - Sistema Integrado

Combine TODOS os conceitos aprendidos para criar um sistema completo:

```csharp
string[] produtos = { "Arroz", "Feijão", "Óleo", "Açúcar", "Café" };
decimal[] precos = { 25.00m, 8.50m, 12.00m, 6.00m, 15.00m };
int[] quantidades = { 3, 5, 2, 4, 1 };
```

Implemente:
1. **Cálculo de Subtotais**: Para cada produto, calcule preço × quantidade
2. **Desconto Progressivo** (use if/else):
   - Total < R$ 50: sem desconto
   - Total R$ 50-100: 5% desconto
   - Total > R$ 100: 10% desconto
3. **Categorização** (use switch): Baseado no total final
   - < R$ 50: "Compra Pequena"
   - R$ 50-150: "Compra Média"
   - > R$ 150: "Compra Grande"
4. **Relatório Final**: Exiba todos os produtos, subtotais, desconto, total e categoria

## 💡 Conceitos Importantes

### Foreach Básico

```csharp
string[] frutas = { "Maçã", "Banana", "Laranja" };

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
```

### Foreach com Arrays Numéricos

```csharp
decimal[] precos = { 10.50m, 25.00m, 15.75m };
decimal total = 0;

foreach (decimal preco in precos)
{
    total += preco;
}

Console.WriteLine($"Total: R$ {total}");
```

### Continue - Pular Iteração

```csharp
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int numero in numeros)
{
    if (numero % 2 == 0)  // Se for par
    {
        continue;  // Pula para a próxima iteração
    }
    
    Console.WriteLine(numero);  // Só exibe ímpares
}
// Saída: 1, 3, 5, 7, 9
```

### Break - Interromper Loop

```csharp
string[] produtos = { "Arroz", "Feijão", "Óleo", "Açúcar" };
string busca = "Óleo";
bool encontrado = false;

foreach (string produto in produtos)
{
    if (produto == busca)
    {
        encontrado = true;
        break;  // Para o loop imediatamente
    }
}

Console.WriteLine(encontrado ? "Encontrado!" : "Não encontrado");
```

### Foreach vs For

**Use Foreach quando:**
- Precisa percorrer TODOS os elementos
- Não precisa do índice
- Código mais limpo e legível
- Trabalha com coleções (arrays, listas)

**Use For quando:**
- Precisa do índice
- Precisa acessar múltiplos arrays paralelos
- Precisa controlar o incremento
- Precisa percorrer de trás para frente

### Exemplo com Índice (quando foreach não é ideal)

```csharp
string[] nomes = { "Ana", "Bruno", "Carlos" };
decimal[] precos = { 10.00m, 20.00m, 30.00m };

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{nomes[i]}: R$ {precos[i]}");
}
```

## ✅ Exemplo de Saída Esperada (Tarefa 1)

```
=== PROCESSAMENTO DE PRODUTOS ===
Produto 1: R$ 45,90
Produto 2: R$ 120,00
Produto 3: R$ 8,50
Produto 4: R$ 250,00
Produto 5: R$ 15,75
Produto 6: R$ 89,90
Produto 7: R$ 5,00
Produto 8: R$ 180,00

Total: R$ 715,05
Produtos acima de R$ 50: 3
Produto mais caro: R$ 250,00
Produto mais barato: R$ 5,00
```

## 🎓 Desafios Extras

1. **Top 3 Produtos**: Encontre os 3 produtos mais caros da lista
2. **Média Móvel**: Calcule a média dos últimos 3 produtos processados
3. **Validação de Estoque**: Pare o processamento se encontrar 3 produtos sem estoque
4. **Agrupamento**: Conte quantos produtos existem em cada faixa de preço (0-50, 51-100, 101+)
5. **Sistema de Pontos**: Cliente ganha 1 ponto a cada R$ 10 gastos, use foreach para calcular

## 📌 Dicas

- Foreach é read-only: não pode modificar o array durante a iteração
- Use `break` quando encontrar o que procura (economiza processamento)
- Use `continue` para filtrar elementos sem criar ifs aninhados
- Para trabalhar com índice no foreach, use uma variável contador:
  ```csharp
  int indice = 0;
  foreach (var item in lista)
  {
      Console.WriteLine($"Índice {indice}: {item}");
      indice++;
  }
  ```
- Combine break e continue com condições claras
- Para arrays paralelos, prefira for ao invés de foreach
- Sempre inicialize acumuladores antes do loop:
  ```csharp
  decimal total = 0;
  int contador = 0;
  decimal maior = decimal.MinValue;
  ```

## 🔗 Navegação

- [← Exercício Anterior](exercicio-07-loop-while.md) - Loop While
- [🏠 Voltar ao Início](README.md)

---

## 🎉 Parabéns!

Você completou todos os exercícios de lógica de programação com C# .NET básico! Agora você domina:

✅ Tipos de dados e variáveis  
✅ Operadores aritméticos, relacionais e lógicos  
✅ Estruturas condicionais (if/else, switch)  
✅ Estruturas de repetição (for, while, foreach)  
✅ Controle de fluxo (break, continue)

**Próximos passos**: Pratique criando seus próprios projetos, explore arrays multidimensionais, listas (List<T>) e comece a estudar Programação Orientada a Objetos (POO)!
