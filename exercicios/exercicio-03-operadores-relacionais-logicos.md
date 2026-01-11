# Exercício 03 - Operadores Relacionais e Lógicos

## 🎯 Objetivos de Aprendizagem

- Utilizar operadores relacionais: ==, !=, >, <, >=, <=
- Aplicar operadores lógicos: &&, ||, !
- Combinar operadores para criar expressões lógicas complexas
- Validar dados e condições

## 📝 Cenário

O sistema da loja precisa validar informações de produtos e vendas. Você deve verificar condições como estoque disponível, produtos vencidos, elegibilidade para promoções e validação de compras.

## 📋 Tarefas

### Tarefa 1: Validação de Estoque

Crie um programa que declare as seguintes variáveis:

- Produto: "Leite Integral"
- Quantidade em estoque: 50
- Quantidade solicitada: 30
- Estoque mínimo: 20

Crie expressões booleanas para verificar:

1. Se a quantidade solicitada está disponível (solicitada <= estoque)
2. Se o estoque está abaixo do mínimo (estoque < estoque mínimo)
3. Se após a venda o estoque ficará abaixo do mínimo
4. Exiba o resultado de cada verificação

### Tarefa 2: Verificação de Promoção

Declare variáveis para um produto:

- Nome: "Chocolate"
- Preço: R$ 8,50
- Quantidade em estoque: 100
- Data de validade: 10/02/2026
- Data atual: (use DateTime.Now)

Verifique se o produto está elegível para promoção. Um produto entra em promoção se:

- O preço é menor ou igual a R$ 10,00 **E**
- A quantidade em estoque é maior que 50 **E**
- Faltam mais de 30 dias para vencer

### Tarefa 3: Validação de Compra

Crie um sistema de validação de compra com:

- Valor total da compra: R$ 250,00
- Valor pago: R$ 300,00
- Cliente é VIP: true
- Tem cupom de desconto: false

Verifique:

1. Se o pagamento é suficiente (pago >= total)
2. Se o cliente tem direito a desconto extra (é VIP **OU** tem cupom)
3. Se o cliente **NÃO** é VIP (use operador !)
4. Se o cliente é VIP **E** tem cupom (desconto especial)

### Tarefa 4: Validação Complexa

Crie um cenário com múltiplas condições:

- Produto: "Notebook Gamer"
- Preço: R$ 4.500,00
- Estoque: 5
- Quantidade solicitada: 2
- Cliente tem crédito: true
- Limite de crédito: R$ 5.000,00
- É Black Friday: true

Verifique se a venda pode ser realizada. A venda é aprovada se:

- Há estoque suficiente **E**
- (Cliente tem crédito **E** limite é suficiente) **OU** é Black Friday

## 💡 Conceitos Importantes

### Operadores Relacionais

```csharp
int a = 10, b = 20;

bool igual = (a == b);           // false
bool diferente = (a != b);       // true
bool maior = (a > b);            // false
bool menor = (a < b);            // true
bool maiorIgual = (a >= 10);     // true
bool menorIgual = (b <= 20);     // true
```

### Operadores Lógicos

```csharp
bool temEstoque = true;
bool precoOk = true;
bool clienteVIP = false;

// E lógico (&&) - ambos devem ser verdadeiros
bool podeVender = temEstoque && precoOk;  // true

// OU lógico (||) - pelo menos um deve ser verdadeiro
bool temDesconto = clienteVIP || precoOk;  // true

// NÃO lógico (!) - inverte o valor
bool naoEhVIP = !clienteVIP;  // true
```

### Combinando Operadores

```csharp
int estoque = 50;
int minimo = 20;
int solicitado = 30;
bool urgente = true;

// Expressão complexa
bool podeVender = (estoque >= solicitado) && 
                  ((estoque - solicitado) >= minimo || urgente);
```

### Comparando Datas

```csharp
DateTime dataValidade = new DateTime(2026, 6, 15);
DateTime hoje = DateTime.Now;

bool vencido = dataValidade < hoje;
bool venceEm30Dias = (dataValidade - hoje).TotalDays <= 30;
```

## ✅ Exemplo de Saída Esperada (Tarefa 1)

```
=== VALIDAÇÃO DE ESTOQUE ===
Produto: Leite Integral
Estoque Atual: 50
Quantidade Solicitada: 30
Estoque Mínimo: 20

Quantidade disponível? True
Estoque abaixo do mínimo? False
Estoque ficará abaixo do mínimo após venda? False
```

## 🎓 Desafios Extras

1. Crie uma validação para verificar se um produto está "perto de vencer" (menos de 7 dias)
2. Verifique se um cliente pode parcelar (valor > R$ 100 E quantidade de parcelas <= 12)
3. Implemente uma regra: "Desconto de 20% se comprar mais de 10 unidades OU se for cliente VIP"
4. Valide se um CPF tem 11 dígitos (use `.Length` em string)

## 📌 Dicas

- Use parênteses para deixar as expressões mais claras: `(a && b) || c`
- Operador `&&` tem precedência sobre `||`
- Para comparar strings: `string1 == string2` (case-sensitive)
- Para calcular dias entre datas: `(data1 - data2).TotalDays`
- Evite comparar `bool` com `== true`, use diretamente: `if (condicao)` ao invés de `if (condicao == true)`

## 🔗 Navegação

- [← Exercício Anterior](exercicio-02-operadores-aritmeticos.md) - Operadores Aritméticos
- [Próximo Exercício →](exercicio-04-estruturas-condicionais.md) - Estruturas Condicionais
