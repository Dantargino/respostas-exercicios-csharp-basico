# Exercício 06 - Loop For

## 🎯 Objetivos de Aprendizagem

- Utilizar a estrutura de repetição for
- Trabalhar com diferentes incrementos e decrementos
- Processar múltiplos itens
- Combinar loops com estruturas condicionais

## 📝 Cenário

O sistema da loja precisa processar múltiplos produtos, gerar relatórios, calcular totais e realizar operações em lote. O loop for é ideal para quando sabemos quantas vezes precisamos repetir uma operação.

## 📋 Tarefas

### Tarefa 1: Processamento de Múltiplos Produtos

Crie um programa que processa 5 produtos em uma venda:

Para cada produto (use valores de exemplo):
- Produto 1: R$ 50,00
- Produto 2: R$ 120,00
- Produto 3: R$ 80,00
- Produto 4: R$ 200,00
- Produto 5: R$ 45,00

Use um loop for para:
1. Exibir cada produto com seu número
2. Calcular o total da venda
3. Exibir o total ao final

### Tarefa 2: Relatório de Estoque

Crie um relatório de 10 produtos com estoque baixo:

Para cada produto (i de 1 a 10):
- Código: PROD00X (onde X é o número)
- Estoque atual: 15 - i (diminui a cada produto)
- Estoque mínimo: 10

Use for para:
1. Listar todos os produtos
2. Marcar com "⚠️ ALERTA" se estoque < mínimo
3. Contar quantos produtos estão em alerta

### Tarefa 3: Cálculo de Parcelas

Crie um sistema que exibe o plano de parcelamento:

- Valor total: R$ 1.200,00
- Número de parcelas: 6
- Taxa de juros por parcela: 2%

Use for para:
1. Calcular o valor de cada parcela (com juros compostos)
2. Exibir o número da parcela, valor e data de vencimento
3. Calcular o total pago ao final

**Fórmula**: Cada parcela = (Valor total / parcelas) * (1 + taxa)^parcela

### Tarefa 4: Contagem Regressiva de Promoção

Crie uma contagem regressiva para uma promoção:

- Dias até o fim da promoção: 10

Use for decrescente para:
1. Exibir "Faltam X dias para o fim da promoção"
2. Quando chegar a 3 dias, adicionar "⚠️ ÚLTIMOS DIAS!"
3. No último dia, exibir "🔥 ÚLTIMO DIA DE PROMOÇÃO!"

### Tarefa 5: Processamento com Condições

Crie um sistema que processa 20 vendas e gera estatísticas:

Para cada venda (use valores aleatórios ou fixos):
- Vendas ímpares: valores entre R$ 50 e R$ 150
- Vendas pares: valores entre R$ 200 e R$ 500

Use for para calcular:
1. Total de vendas
2. Quantidade de vendas acima de R$ 300
3. Média de valor das vendas
4. Maior e menor venda

## 💡 Conceitos Importantes

### Loop For Básico

```csharp
// Estrutura: for (inicialização; condição; incremento)
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteração {i}");
}
// Saída: Iteração 1, Iteração 2, ..., Iteração 5
```

### For Decrescente

```csharp
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine($"Contagem: {i}");
}
// Saída: 10, 9, 8, ..., 1
```

### For com Incremento Diferente

```csharp
// Incremento de 2 em 2
for (int i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i);
}
// Saída: 0, 2, 4, 6, 8, 10

// Incremento de 5 em 5
for (int i = 5; i <= 50; i += 5)
{
    Console.WriteLine(i);
}
// Saída: 5, 10, 15, ..., 50
```

### For com Acumulador

```csharp
decimal total = 0;

for (int i = 1; i <= 5; i++)
{
    decimal valor = i * 10;
    total += valor;
    Console.WriteLine($"Item {i}: R$ {valor}");
}

Console.WriteLine($"Total: R$ {total}");
```

### For com Condições

```csharp
int contador = 0;

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)  // Se for par
    {
        Console.WriteLine($"{i} é par");
        contador++;
    }
}

Console.WriteLine($"Total de números pares: {contador}");
```

### For Aninhado (Nested)

```csharp
// Útil para tabelas ou matrizes
for (int linha = 1; linha <= 3; linha++)
{
    for (int coluna = 1; coluna <= 4; coluna++)
    {
        Console.Write($"[{linha},{coluna}] ");
    }
    Console.WriteLine();  // Nova linha
}
```

## ✅ Exemplo de Saída Esperada (Tarefa 1)

```
=== PROCESSAMENTO DE VENDA ===
Produto 1: R$ 50,00
Produto 2: R$ 120,00
Produto 3: R$ 80,00
Produto 4: R$ 200,00
Produto 5: R$ 45,00
----------------------------
Total da Venda: R$ 495,00
```

## 🎓 Desafios Extras

1. **Tabuada**: Crie a tabuada de um número (ex: tabuada do 7)
2. **Números Primos**: Liste os primeiros 10 números primos
3. **Fibonacci**: Gere os primeiros 15 números da sequência de Fibonacci
4. **Padrão de Estrelas**: Use for aninhado para criar um triângulo:
   ```
   *
   **
   ***
   ****
   *****
   ```
5. **Desconto Progressivo**: A cada 5 produtos vendidos, aumente o desconto em 5% (máximo 25%)

## 📌 Dicas

- Use nomes descritivos para a variável de controle: `for (int produto = 1; ...)`
- Cuidado com o operador de comparação: `<` vs `<=`
- Para calcular médias, divida o total pela quantidade ao final do loop
- Use variáveis acumuladoras fora do loop para guardar totais
- Para encontrar maior/menor valor:
  ```csharp
  decimal maior = decimal.MinValue;
  decimal menor = decimal.MaxValue;
  
  for (int i = 0; i < 10; i++)
  {
      if (valor > maior) maior = valor;
      if (valor < menor) menor = valor;
  }
  ```
- Evite modificar a variável de controle dentro do loop (pode causar bugs)

## 🔗 Navegação

- [← Exercício Anterior](exercicio-05-switch.md) - Switch e Switch Expression
- [Próximo Exercício →](exercicio-07-loop-while.md) - Loop While
