# Exercício 10 - Enum

## 🎯 Objetivos de Aprendizagem

- Declarar e usar enumerações (enum)
- Converter entre enum e int
- Converter entre enum e string
- Usar enum em estruturas condicionais (switch)
- Entender quando usar enum vs valores literais

## 📝 Cenário

O sistema da loja precisa trabalhar com valores fixos e predefinidos como categorias de produtos, status de pedidos e formas de pagamento. Enums tornam o código mais legível, seguro e fácil de manter.

## 📋 Tarefas

### Tarefa 1: Enum de Categorias

Crie um enum para categorias de produtos:

```csharp
enum CategoriaProduto
{
    Alimentos,
    Bebidas,
    Eletronicos,
    Livros,
    Limpeza,
    Higiene
}
```

Declare uma variável do tipo `CategoriaProduto`, atribua o valor `Eletronicos` e exiba:

- O nome da categoria
- O valor numérico (int) da categoria

### Tarefa 2: Enum com Valores Personalizados

Crie um enum para status de pedido com valores específicos:

```csharp
enum StatusPedido
{
    Pendente = 1,
    EmProcessamento = 2,
    EmTransporte = 3,
    Entregue = 4,
    Cancelado = 9
}
```

Crie um pedido com status `EmTransporte` e exiba:

- Status atual
- Código numérico do status

### Tarefa 3: Enum em Switch

Use o enum `CategoriaProduto` em uma estrutura switch para determinar características:

- Produto: "Notebook"
- Categoria: `CategoriaProduto.Eletronicos`

Para cada categoria, exiba:

- **Alimentos**: Validade curta, requer cuidado
- **Bebidas**: Validade média
- **Eletrônicos**: Garantia de 1 ano
- **Livros**: Sem validade
- **Limpeza**: Validade longa
- **Higiene**: Validade média

### Tarefa 4: Conversão Enum ↔ Int

Trabalhe com conversões entre enum e int:

1. Converta `StatusPedido.Entregue` para int
2. Converta o número `2` para `StatusPedido`
3. Verifique se um número (ex: 5) é um valor válido do enum

### Tarefa 5: Conversão Enum ↔ String

Trabalhe com conversões entre enum e string:

1. Converta `CategoriaProduto.Livros` para string
2. Converta a string "Bebidas" para `CategoriaProduto` usando `Enum.Parse()`
3. Use `Enum.TryParse()` para converter "Eletronicos" de forma segura
4. Tente converter uma string inválida ("Invalido") e trate o erro

### Tarefa 6: Sistema de Descontos por Categoria

Crie um enum `FormaPagamento`:

```csharp
enum FormaPagamento
{
    Dinheiro,
    PIX,
    Debito,
    Credito
}
```

Implemente um sistema que:

1. Recebe categoria do produto e forma de pagamento
2. Usa switch expression para determinar desconto por forma de pagamento:
   - Dinheiro: 10%
   - PIX: 5%
   - Débito: 0%
   - Crédito: 0% (mas +5% de acréscimo)
3. Calcula o preço final

Dados de teste:

- Produto: "Mouse Gamer"
- Categoria: `Eletronicos`
- Preço: R$ 150,00
- Forma de pagamento: `PIX`

### Tarefa 7: Listar Todos os Valores de um Enum

Use `Enum.GetValues()` para listar todas as categorias de produtos disponíveis.

## 💡 Conceitos Importantes

### Declaração de Enum

```csharp
// Enum simples (valores automáticos: 0, 1, 2, ...)
enum DiaSemana
{
    Domingo,    // 0
    Segunda,    // 1
    Terca,      // 2
    Quarta,     // 3
    Quinta,     // 4
    Sexta,      // 5
    Sabado      // 6
}

// Enum com valores personalizados
enum Prioridade
{
    Baixa = 1,
    Media = 5,
    Alta = 10
}
```

### Usando Enum

```csharp
// Declarar e usar
DiaSemana hoje = DiaSemana.Sexta;
Console.WriteLine(hoje);  // Sexta

// Em condicionais
if (hoje == DiaSemana.Sabado || hoje == DiaSemana.Domingo)
{
    Console.WriteLine("Fim de semana!");
}
```

### Enum em Switch

```csharp
DiaSemana dia = DiaSemana.Segunda;

switch (dia)
{
    case DiaSemana.Segunda:
    case DiaSemana.Terca:
    case DiaSemana.Quarta:
    case DiaSemana.Quinta:
    case DiaSemana.Sexta:
        Console.WriteLine("Dia útil");
        break;
    case DiaSemana.Sabado:
    case DiaSemana.Domingo:
        Console.WriteLine("Fim de semana");
        break;
}

// Ou com switch expression
string tipo = dia switch
{
    DiaSemana.Sabado or DiaSemana.Domingo => "Fim de semana",
    _ => "Dia útil"
};
```

### Conversão Enum ↔ Int

```csharp
// Enum → int (casting)
DiaSemana dia = DiaSemana.Quarta;
int numeroDia = (int)dia;
Console.WriteLine(numeroDia);  // 3

// int → Enum (casting)
int numero = 5;
DiaSemana diaConvertido = (DiaSemana)numero;
Console.WriteLine(diaConvertido);  // Sexta
```

### Conversão Enum ↔ String

```csharp
// Enum → string
DiaSemana dia = DiaSemana.Sabado;
string texto = dia.ToString();
Console.WriteLine(texto);  // "Sabado"

// String → Enum (Parse - lança exceção se inválido)
string entrada = "Domingo";
DiaSemana diaParseado = (DiaSemana)Enum.Parse(typeof(DiaSemana), entrada);

// String → Enum (TryParse - mais seguro)
string entrada2 = "Segunda";
if (Enum.TryParse<DiaSemana>(entrada2, out DiaSemana diaSeguro))
{
    Console.WriteLine($"Conversão OK: {diaSeguro}");
}
```

### Enum.GetValues - Listar Todos os Valores

```csharp
// Obter todos os valores do enum
foreach (DiaSemana dia in Enum.GetValues(typeof(DiaSemana)))
{
    Console.WriteLine($"{dia} = {(int)dia}");
}
```

### Enum.IsDefined - Verificar se Valor é Válido

```csharp
int numero = 10;
bool existe = Enum.IsDefined(typeof(DiaSemana), numero);
Console.WriteLine(existe);  // false (DiaSemana só vai até 6)
```

## ✅ Exemplo de Saída Esperada (Tarefa 6)

```
=== SISTEMA DE DESCONTOS ===
Produto: Mouse Gamer
Categoria: Eletronicos
Preço Original: R$ 150,00
Forma de Pagamento: PIX
Desconto: 5%
Valor do Desconto: R$ 7,50
Preço Final: R$ 142,50
```

## 🎓 Desafios Extras

1. **Enum com Flags**: Use `[Flags]` para criar enum de permissões (Leitura, Escrita, Execução)
2. **Validação**: Crie uma função que valida se uma string pode ser convertida para o enum
3. **Menu Dinâmico**: Crie um menu que lista todas as opções de um enum automaticamente
4. **Prioridade**: Crie enum `Prioridade` e ordene produtos por prioridade

## 📌 Dicas

- Enums começam em 0 por padrão, mas você pode definir valores personalizados
- Use `PascalCase` para nomes de enum e seus valores
- Enums são fortemente tipados - mais seguros que strings ou ints "mágicos"
- `Enum.Parse()` é case-sensitive por padrão, use overload para ignorar case
- TryParse é preferível a Parse para entrada do usuário
- Enums podem ser convertidos para int e vice-versa com casting
- Use `typeof(EnumName)` quando precisar referenciar o tipo do enum

## 🔗 Navegação

- [← Exercício Anterior](exercicio-09-conversao-tipos.md) - Conversão de Tipos
- [Próximo Exercício →](exercicio-11-arrays-matrizes.md) - Arrays e Matrizes
