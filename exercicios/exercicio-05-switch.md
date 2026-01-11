# Exercício 05 - Switch e Switch Expression

## 🎯 Objetivos de Aprendizagem

- Utilizar a estrutura switch tradicional
- Conhecer switch expression (C# 8.0+)
- Escolher entre if/else e switch
- Trabalhar com múltiplos casos

## 📝 Cenário

O sistema da loja precisa de funcionalidades que envolvem seleção entre múltiplas opções: menu de operações, categorização de produtos, cálculo de impostos por categoria e definição de prazos de entrega.

## 📋 Tarefas

### Tarefa 1: Menu de Operações

Crie um menu para o sistema da loja:

- Opção escolhida: 3

Menu:
1. Cadastrar produto
2. Consultar estoque
3. Realizar venda
4. Emitir relatório
5. Sair

Use switch para exibir a operação selecionada e uma mensagem descritiva.

### Tarefa 2: Categorização de Produtos

Crie um sistema que define características baseadas na categoria do produto:

- Código da categoria: 'E'

Categorias:
- 'A' - Alimentos: Validade curta, requer refrigeração
- 'B' - Bebidas: Validade média, armazenamento normal
- 'E' - Eletrônicos: Sem validade, requer cuidado especial
- 'L' - Limpeza: Validade longa, armazenamento normal
- 'H' - Higiene: Validade média, armazenamento normal

Use switch tradicional para exibir as características.

### Tarefa 3: Cálculo de Imposto por Categoria (Switch Expression)

Implemente um sistema que calcula a alíquota de imposto baseada na categoria:

- Produto: "Notebook"
- Categoria: "Eletrônicos"
- Preço: R$ 3.000,00

Alíquotas:
- Alimentos: 5%
- Bebidas: 15%
- Eletrônicos: 25%
- Livros: 0%
- Outros: 18%

Use **switch expression** para determinar a alíquota e calcule o valor do imposto.

### Tarefa 4: Prazo de Entrega por Região

Crie um sistema que define o prazo de entrega baseado na região:

- Região: "Sul"

Prazos:
- Norte: 10 dias úteis
- Nordeste: 8 dias úteis
- Centro-Oeste: 7 dias úteis
- Sudeste: 3 dias úteis
- Sul: 5 dias úteis

Use switch expression e exiba:
- Região
- Prazo de entrega
- Data estimada de entrega (use DateTime.Now.AddDays)

### Tarefa 5: Sistema Combinado

Crie um sistema que combina categoria e forma de pagamento:

- Categoria: "Eletrônicos"
- Forma de pagamento: "credito"
- Valor: R$ 2.000,00

Regras:
1. Use switch para determinar o imposto por categoria (Tarefa 3)
2. Use switch para determinar acréscimo/desconto por forma de pagamento:
   - "dinheiro": -10% (desconto)
   - "pix": -5% (desconto)
   - "debito": 0%
   - "credito": +5% (acréscimo)

Calcule e exiba o valor final.

## 💡 Conceitos Importantes

### Switch Tradicional

```csharp
int opcao = 2;

switch (opcao)
{
    case 1:
        Console.WriteLine("Opção 1 selecionada");
        break;
    case 2:
        Console.WriteLine("Opção 2 selecionada");
        break;
    case 3:
        Console.WriteLine("Opção 3 selecionada");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
```

### Switch com Múltiplos Casos

```csharp
char categoria = 'A';

switch (categoria)
{
    case 'A':
    case 'B':
    case 'C':
        Console.WriteLine("Categoria básica");
        break;
    case 'D':
    case 'E':
        Console.WriteLine("Categoria premium");
        break;
    default:
        Console.WriteLine("Categoria desconhecida");
        break;
}
```

### Switch Expression (C# 8.0+)

```csharp
string categoria = "Eletrônicos";

decimal aliquota = categoria switch
{
    "Alimentos" => 0.05m,
    "Bebidas" => 0.15m,
    "Eletrônicos" => 0.25m,
    "Livros" => 0.00m,
    _ => 0.18m  // default
};

Console.WriteLine($"Alíquota: {aliquota * 100}%");
```

### Switch Expression com Variável

```csharp
string regiao = "Sudeste";

string mensagem = regiao switch
{
    "Norte" => "Entrega em 10 dias",
    "Nordeste" => "Entrega em 8 dias",
    "Sudeste" => "Entrega em 3 dias",
    "Sul" => "Entrega em 5 dias",
    "Centro-Oeste" => "Entrega em 7 dias",
    _ => "Região não atendida"
};

Console.WriteLine(mensagem);
```

### Quando Usar Switch vs If/Else

**Use Switch quando:**
- Comparar uma variável com múltiplos valores específicos
- Valores são constantes (números, strings, chars)
- Código fica mais legível que vários if/else

**Use If/Else quando:**
- Condições complexas (ranges, múltiplas variáveis)
- Operadores relacionais (>, <, >=, <=)
- Condições compostas com && ou ||

## ✅ Exemplo de Saída Esperada (Tarefa 3)

```
=== CÁLCULO DE IMPOSTO ===
Produto: Notebook
Categoria: Eletrônicos
Preço: R$ 3.000,00
Alíquota: 25%
Valor do Imposto: R$ 750,00
Preço Final: R$ 3.750,00
```

## 🎓 Desafios Extras

1. **Dia da Semana**: Crie um switch que recebe um número (1-7) e retorna o dia da semana
2. **Conversão de Mês**: Receba um número (1-12) e retorne o nome do mês
3. **Classificação de Idade**: Use switch expression com ranges:
   - 0-12: Criança
   - 13-17: Adolescente
   - 18-59: Adulto
   - 60+: Idoso
4. **Calculadora**: Crie uma calculadora que recebe operador (+, -, *, /) e dois números

## 📌 Dicas

- Sempre inclua `break` no switch tradicional (exceto quando quer fall-through intencional)
- Use `default` para tratar casos não previstos
- Switch expression é mais conciso e retorna um valor diretamente
- No switch expression, use `_` para o caso default
- Switch expression não precisa de `break`
- Para strings, o switch é case-sensitive
- Considere usar `ToLower()` ou `ToUpper()` para comparações de string:
  ```csharp
  string opcao = input.ToLower();
  switch (opcao) { ... }
  ```

## 🔗 Navegação

- [← Exercício Anterior](exercicio-04-estruturas-condicionais.md) - Estruturas Condicionais
- [Próximo Exercício →](exercicio-06-loop-for.md) - Loop For
