# Exercício 04 - Estruturas Condicionais (if/else)

## 🎯 Objetivos de Aprendizagem

- Utilizar estruturas if, else if e else
- Criar condições simples e compostas
- Implementar lógica de decisão em programas
- Combinar operadores relacionais e lógicos com estruturas condicionais

## 📝 Cenário

O sistema da loja precisa tomar decisões automáticas baseadas em diferentes condições: aplicar descontos progressivos, categorizar clientes, validar vendas e alertar sobre situações especiais.

## 📋 Tarefas

### Tarefa 1: Sistema de Descontos Progressivos

Crie um programa que calcule o desconto baseado no valor da compra:

- Valor da compra: R$ 350,00

Regras de desconto:
- Compras acima de R$ 500,00: 20% de desconto
- Compras entre R$ 300,00 e R$ 500,00: 15% de desconto
- Compras entre R$ 100,00 e R$ 299,99: 10% de desconto
- Compras abaixo de R$ 100,00: sem desconto

Calcule e exiba:
- Valor original
- Percentual de desconto aplicado
- Valor do desconto
- Valor final

### Tarefa 2: Categorização de Cliente

Crie um sistema que categoriza clientes baseado em seus gastos totais:

- Nome do cliente: "Maria Silva"
- Total gasto no mês: R$ 2.800,00
- É cliente há mais de 1 ano: true

Categorias:
- **Diamante**: Gasto > R$ 5.000,00
- **Ouro**: Gasto entre R$ 2.000,00 e R$ 5.000,00 E cliente há mais de 1 ano
- **Prata**: Gasto entre R$ 1.000,00 e R$ 1.999,99
- **Bronze**: Gasto abaixo de R$ 1.000,00

Exiba a categoria do cliente e os benefícios:
- Diamante: 25% de desconto + frete grátis
- Ouro: 15% de desconto + frete grátis
- Prata: 10% de desconto
- Bronze: 5% de desconto

### Tarefa 3: Validação de Venda com Múltiplas Condições

Crie um sistema de validação de venda:

- Produto: "Smart TV 50 polegadas"
- Preço: R$ 2.200,00
- Estoque: 3
- Quantidade solicitada: 2
- Cliente tem limite de crédito: true
- Limite disponível: R$ 3.000,00
- Forma de pagamento: "credito" (pode ser "dinheiro", "debito", "credito", "pix")

Valide a venda verificando:

1. Se há estoque suficiente
2. Se a forma de pagamento é válida
3. Se pagamento é crédito, verificar se o limite é suficiente
4. Se todas as condições forem atendidas, aprovar a venda
5. Caso contrário, informar o motivo da recusa

### Tarefa 4: Alerta de Estoque

Crie um sistema de alerta para gerenciamento de estoque:

- Produto: "Arroz 5kg"
- Quantidade em estoque: 15
- Estoque mínimo: 20
- Estoque máximo: 100
- Dias até próxima entrega: 3

Implemente alertas:

- **CRÍTICO**: Estoque abaixo do mínimo E próxima entrega em mais de 5 dias
- **ATENÇÃO**: Estoque abaixo do mínimo E próxima entrega em até 5 dias
- **NORMAL**: Estoque entre mínimo e máximo
- **EXCESSO**: Estoque acima do máximo

Exiba o status e a ação recomendada.

## 💡 Conceitos Importantes

### Estrutura if/else Básica

```csharp
int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}
```

### Estrutura if/else if/else

```csharp
decimal valor = 250.00m;

if (valor >= 500)
{
    Console.WriteLine("Desconto de 20%");
}
else if (valor >= 300)
{
    Console.WriteLine("Desconto de 15%");
}
else if (valor >= 100)
{
    Console.WriteLine("Desconto de 10%");
}
else
{
    Console.WriteLine("Sem desconto");
}
```

### Condições Compostas

```csharp
int estoque = 50;
bool urgente = true;

if (estoque > 0 && estoque < 20)
{
    Console.WriteLine("Estoque baixo");
}
else if (estoque == 0 || urgente)
{
    Console.WriteLine("Reabastecer imediatamente");
}
```

### If sem Chaves (uma linha)

```csharp
// Apenas para comandos simples de uma linha
if (estoque > 0)
    Console.WriteLine("Disponível");
else
    Console.WriteLine("Indisponível");

// Recomendado usar chaves sempre para evitar erros
```

### Operador Ternário (alternativa ao if/else simples)

```csharp
int estoque = 10;
string status = (estoque > 0) ? "Disponível" : "Indisponível";
```

## ✅ Exemplo de Saída Esperada (Tarefa 1)

```
=== SISTEMA DE DESCONTOS ===
Valor Original: R$ 350,00
Desconto Aplicado: 15%
Valor do Desconto: R$ 52,50
Valor Final: R$ 297,50
```

## 🎓 Desafios Extras

1. **Frete Grátis**: Adicione uma condição que dá frete grátis para compras acima de R$ 200,00
2. **Desconto Especial**: Se o cliente comprar em dia de aniversário (use DateTime), adicione 5% extra
3. **Validação de Idade**: Crie um sistema que valida se o cliente pode comprar bebidas alcoólicas (>= 18 anos)
4. **Parcelamento**: Implemente regras de parcelamento:
   - Até R$ 100: apenas à vista
   - R$ 100 a R$ 500: até 3x sem juros
   - Acima de R$ 500: até 6x sem juros

## 📌 Dicas

- Use chaves `{}` mesmo para blocos de uma linha - evita erros futuros
- Ordene as condições da mais específica para a mais genérica
- Evite ifs aninhados demais (mais de 3 níveis) - dificulta leitura
- Use variáveis booleanas para tornar condições mais legíveis:
  ```csharp
  bool temEstoque = quantidade > 0;
  bool precoValido = preco > 0;
  
  if (temEstoque && precoValido)
  {
      // código
  }
  ```
- Para comparar strings, considere usar `.Equals()` com opções de case-insensitive:
  ```csharp
  if (formaPagamento.Equals("credito", StringComparison.OrdinalIgnoreCase))
  ```

## 🔗 Navegação

- [← Exercício Anterior](exercicio-03-operadores-relacionais-logicos.md) - Operadores Relacionais e Lógicos
- [Próximo Exercício →](exercicio-05-switch.md) - Switch e Switch Expression
