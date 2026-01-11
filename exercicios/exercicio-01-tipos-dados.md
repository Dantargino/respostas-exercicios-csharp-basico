# Exercício 01 - Tipos de Dados e Variáveis

## 🎯 Objetivos de Aprendizagem

- Conhecer os tipos de dados primitivos do C# (int, double, decimal, bool, char)
- Trabalhar com string e DateTime
- Declarar e inicializar variáveis
- Entender a diferença entre var e tipo explícito

## 📝 Cenário

Você está desenvolvendo um sistema para uma loja e precisa criar o cadastro básico de um produto. O sistema deve armazenar informações como nome, preço, quantidade em estoque, se está em promoção, categoria (primeira letra) e data de validade.

## 📋 Tarefas

### Tarefa 1: Cadastro de Produto

Crie um programa que declare variáveis para armazenar as seguintes informações de um produto:

1. **Nome do produto** (string) - Ex: "Arroz Integral"
2. **Preço unitário** (decimal) - Ex: 12.50
3. **Quantidade em estoque** (int) - Ex: 150
4. **Peso em kg** (double) - Ex: 1.5
5. **Está em promoção?** (bool) - Ex: true
6. **Categoria** (char) - Ex: 'A' (Alimentos)
7. **Data de validade** (DateTime) - Ex: 15/06/2026

### Tarefa 2: Exibição dos Dados

Após declarar e inicializar as variáveis, exiba todas as informações do produto no console de forma organizada.

### Tarefa 3: Uso de var

Crie um segundo produto utilizando a palavra-chave `var` para declarar as variáveis e compare com a primeira abordagem.

## 💡 Conceitos Importantes

### Tipos de Dados Primitivos

```csharp
int quantidade = 100;           // Número inteiro
double peso = 1.5;              // Número decimal (ponto flutuante)
decimal preco = 12.50m;         // Número decimal (precisão financeira)
bool emPromocao = true;         // Verdadeiro ou falso
char categoria = 'A';           // Um único caractere
```

### String e DateTime

```csharp
string nome = "Produto";
DateTime dataValidade = new DateTime(2026, 6, 15);
// ou
DateTime dataValidade = DateTime.Parse("15/06/2026");
```

### var vs Tipo Explícito

```csharp
// Tipo explícito
int quantidade = 100;

// var (tipo inferido pelo compilador)
var quantidade = 100;  // O compilador infere que é int
```

## ✅ Exemplo de Saída Esperada

```
=== CADASTRO DE PRODUTO ===
Nome: Arroz Integral
Preço: R$ 12,50
Quantidade em Estoque: 150 unidades
Peso: 1,5 kg
Em Promoção: Sim
Categoria: A
Data de Validade: 15/06/2026
```

## 🎓 Desafios Extras

1. Adicione mais um produto com informações diferentes
2. Calcule quantos dias faltam para o produto vencer (use `DateTime.Now`)
3. Exiba a data de validade em formato diferente (ex: "15 de junho de 2026")

## 📌 Dicas

- Use `m` ou `M` após números decimais para indicar o tipo `decimal` (ex: 12.50m)
- Para exibir valores booleanos como "Sim/Não", use operador ternário: `emPromocao ? "Sim" : "Não"`
- Para formatar datas: `dataValidade.ToString("dd/MM/yyyy")`
- Para formatar moeda: `preco.ToString("C")`

## 🔗 Próximo Exercício

No [Exercício 02](exercicio-02-operadores-aritmeticos.md), você aprenderá a realizar cálculos com os dados do produto usando operadores aritméticos!
