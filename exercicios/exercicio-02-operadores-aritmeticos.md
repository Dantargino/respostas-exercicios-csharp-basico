# Exercício 02 - Operadores Aritméticos

## 🎯 Objetivos de Aprendizagem

- Utilizar operadores aritméticos: +, -, *, /, %
- Realizar cálculos com diferentes tipos numéricos
- Aplicar operações matemáticas em cenários práticos

## 📝 Cenário

Agora que você já sabe cadastrar produtos, precisa implementar o sistema de vendas da loja. O sistema deve calcular subtotais, aplicar descontos, calcular o total da compra, o troco e dividir o valor em parcelas.

## 📋 Tarefas

### Tarefa 1: Cálculo de Venda Simples

Crie um programa que:

1. Declare as variáveis do produto (reutilize o conhecimento do Exercício 01):
   - Nome: "Notebook"
   - Preço unitário: R$ 2.500,00
   - Quantidade comprada: 2

2. Calcule e exiba:
   - **Subtotal** (preço × quantidade)
   - **Valor do desconto** (10% do subtotal)
   - **Total a pagar** (subtotal - desconto)

### Tarefa 2: Cálculo de Troco

Continuando o programa anterior:

1. Declare uma variável para o valor pago pelo cliente: R$ 5.000,00
2. Calcule e exiba o **troco** (valor pago - total a pagar)

### Tarefa 3: Divisão em Parcelas

Agora adicione:

1. Número de parcelas: 3
2. Calcule e exiba:
   - **Valor de cada parcela** (total a pagar ÷ número de parcelas)
   - **Resto da divisão** (use o operador %)

### Tarefa 4: Múltiplos Produtos

Crie um cenário com 3 produtos diferentes:

- Produto 1: Mouse - R$ 45,00 - Quantidade: 5
- Produto 2: Teclado - R$ 120,00 - Quantidade: 3
- Produto 3: Monitor - R$ 800,00 - Quantidade: 2

Calcule:
- Subtotal de cada produto
- Total geral da compra
- Desconto de 15% sobre o total geral
- Valor final a pagar

## 💡 Conceitos Importantes

### Operadores Aritméticos

```csharp
int a = 10, b = 3;

int soma = a + b;           // 13
int subtracao = a - b;      // 7
int multiplicacao = a * b;  // 30
int divisao = a / b;        // 3 (divisão inteira)
int resto = a % b;          // 1 (resto da divisão)

double divisaoReal = (double)a / b;  // 3.333... (divisão real)
```

### Cuidados com Divisão

```csharp
// Divisão entre inteiros resulta em inteiro
int resultado1 = 10 / 3;        // 3

// Para obter resultado decimal, pelo menos um operando deve ser decimal
double resultado2 = 10.0 / 3;   // 3.333...
decimal resultado3 = 10m / 3m;  // 3.333...
```

### Operador Módulo (%)

```csharp
// Útil para verificar se um número é par/ímpar
int numero = 10;
int resto = numero % 2;  // 0 (par)

// Útil para distribuir valores
int total = 100;
int parcelas = 3;
int valorParcela = total / parcelas;  // 33
int centavosRestantes = total % parcelas;  // 1
```

## ✅ Exemplo de Saída Esperada (Tarefa 1)

```
=== CÁLCULO DE VENDA ===
Produto: Notebook
Preço Unitário: R$ 2.500,00
Quantidade: 2

Subtotal: R$ 5.000,00
Desconto (10%): R$ 500,00
Total a Pagar: R$ 4.500,00
```

## 🎓 Desafios Extras

1. Calcule quanto o cliente economizou com o desconto em porcentagem
2. Adicione uma taxa de entrega de R$ 50,00 ao total
3. Calcule o valor médio por produto (total ÷ quantidade total de itens)
4. Implemente um sistema de cashback: cliente recebe 5% do valor total de volta

## 📌 Dicas

- Use `decimal` para valores monetários para evitar erros de arredondamento
- Para calcular porcentagem: `valor * (percentual / 100)`
- Cuidado com divisão por zero - sempre valide antes
- Use parênteses para controlar a ordem das operações: `(a + b) * c`

## 🔗 Navegação

- [← Exercício Anterior](exercicio-01-tipos-dados.md) - Tipos de Dados e Variáveis
- [Próximo Exercício →](exercicio-03-operadores-relacionais-logicos.md) - Operadores Relacionais e Lógicos
