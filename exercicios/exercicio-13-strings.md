# Exercício 13 - Strings (Manipulação de Texto)

## 🎯 Objetivos de Aprendizagem

- Concatenar strings de diferentes formas
- Usar métodos de strings (ToUpper, ToLower, Trim, etc.)
- Buscar e substituir texto (IndexOf, Contains, Replace)
- Dividir e juntar strings (Split, Join)
- Validar e processar entradas de texto

## 📝 Cenário

O sistema da loja precisa processar nomes de produtos, formatar códigos de barras, buscar itens no catálogo, validar entradas do usuário e gerar relatórios formatados.

## 📋 Tarefas

### Tarefa 1: Concatenação de Strings

Crie informações de um produto usando diferentes formas de concatenação:

Dados:

- Nome: "Mouse"
- Marca: "Logitech"
- Modelo: "G203"
- Cor: "Preto"

Crie a descrição completa usando:

1. Operador `+`
2. `string.Concat()`
3. Interpolação de strings `$"...{variavel}..."`

Exiba as três formas.

### Tarefa 2: Formatação de Texto

Você recebeu entradas do usuário com problemas de formatação:

- Nome do produto: " TECLADO MECÂNICO "
- Código: "ABC-123-XYZ"

Faça as seguintes operações:

1. Remova espaços extras com `Trim()`
2. Converta para minúsculas com `ToLower()`
3. Converta para maiúsculas com `ToUpper()`
4. Capitalize apenas a primeira letra (primeira maiúscula, resto minúscula)
5. Obtenha o tamanho do texto com `Length`

### Tarefa 3: Buscar Texto

Você tem uma descrição de produto:

- Descrição: "Notebook Dell Inspiron 15 polegadas, 8GB RAM, SSD 256GB"

Faça as seguintes buscas:

1. Verifique se contém "Dell" usando `Contains()`
2. Encontre a posição de "RAM" usando `IndexOf()`
3. Verifique se contém "16GB" (não contém)
4. Verifique se começa com "Notebook" usando `StartsWith()`
5. Verifique se termina com "GB" usando `EndsWith()`

### Tarefa 4: Substring e Manipulação

Você tem um código de barras: "7891234567890"

1. Extraia os primeiros 3 dígitos (código do país) usando `Substring(0, 3)`
2. Extraia os 6 dígitos do meio (código do fabricante) usando `Substring(3, 6)`
3. Extraia os últimos 4 dígitos usando `Substring(9)`
4. Verifique se o código tem exatamente 13 caracteres
5. Formate o código como: "789-123456-7890"

### Tarefa 5: Replace - Substituir Texto

Você precisa corrigir nomes de produtos:

- Original: "Mouse Gaming RGB com LED azul e RGB"

1. Substitua "RGB" por "Colorido" usando `Replace()`
2. Substitua "LED azul" por "LED vermelho"
3. Remova espaços duplos (se houver)

### Tarefa 6: Split e Join

Você tem uma lista de produtos em uma string separada por vírgulas:

- Produtos: "Arroz,Feijão,Óleo,Açúcar,Macarrão"

1. Divida a string em um array usando `Split(',')`
2. Conte quantos produtos existem
3. Exiba cada produto em uma linha separada
4. Junte os produtos de volta usando `string.Join(" | ", array)`
5. Junte os produtos como lista numerada

### Tarefa 7: Validação de Entrada

Crie validações para entradas do usuário:

Entrada 1: " " (espaços em branco)
Entrada 2: "" (vazia)
Entrada 3: "Produto Válido"
Entrada 4: null (simule)

Para cada entrada, use:

1. `string.IsNullOrEmpty()` - verifica null ou vazio
2. `string.IsNullOrWhiteSpace()` - verifica null, vazio ou só espaços
3. Valide e exiba mensagem apropriada

### Tarefa 8: Sistema de Busca de Produtos

Crie um sistema de busca:

Produtos disponíveis:

- ["Mouse Gamer RGB", "Teclado Mecânico", "Monitor LED 24pol", "Webcam Full HD", "Fone Bluetooth"]

Termo de busca: "LED"

1. Busque produtos que contenham o termo (case-insensitive)
2. Exiba os produtos encontrados
3. Se não encontrar nada, exiba mensagem apropriada

## 💡 Conceitos Importantes

### Concatenação

```csharp
string nome = "João";
string sobrenome = "Silva";

// Operador +
string completo1 = nome + " " + sobrenome;

// string.Concat
string completo2 = string.Concat(nome, " ", sobrenome);

// Interpolação (recomendado)
string completo3 = $"{nome} {sobrenome}";

// StringBuilder (para muitas concatenações)
var sb = new System.Text.StringBuilder();
sb.Append(nome);
sb.Append(" ");
sb.Append(sobrenome);
string completo4 = sb.ToString();
```

### Métodos Básicos

```csharp
string texto = "  Olá Mundo  ";

int tamanho = texto.Length;              // 13 (com espaços)
string semEspacos = texto.Trim();        // "Olá Mundo"
string maiuscula = texto.ToUpper();      // "  OLÁ MUNDO  "
string minuscula = texto.ToLower();      // "  olá mundo  "
```

### Buscar Texto

```csharp
string frase = "Programação em C# é muito legal";

// Contém
bool contemCSharp = frase.Contains("C#");       // true
bool contemJava = frase.Contains("Java");       // false

// Índice da primeira ocorrência
int posicao = frase.IndexOf("muito");           // 18
int naoAchou = frase.IndexOf("Python");         // -1

// Começa com / Termina com
bool comeca = frase.StartsWith("Programação");  // true
bool termina = frase.EndsWith("legal");         // true
```

### Substring - Extrair Parte

```csharp
string codigo = "ABC-12345";

// Substring(início, quantidade)
string prefixo = codigo.Substring(0, 3);     // "ABC"
string numero = codigo.Substring(4, 5);      // "12345"

// Substring(início) - até o final
string final = codigo.Substring(4);          // "12345"
```

### Replace - Substituir

```csharp
string texto = "Gato preto, gato branco";

// Substitui todas as ocorrências
string novo = texto.Replace("gato", "cachorro");
// "Gato preto, cachorro branco" (case-sensitive!)

// Para case-insensitive, precisa usar outras abordagens
string textoNovo = texto.Replace("Gato", "Cachorro")
                        .Replace("gato", "cachorro");
```

### Split - Dividir String

```csharp
string lista = "maçã,banana,laranja";

// Dividir por vírgula
string[] frutas = lista.Split(',');
// frutas[0] = "maçã"
// frutas[1] = "banana"
// frutas[2] = "laranja"

// Dividir por múltiplos separadores
string texto = "um;dois,três|quatro";
string[] partes = texto.Split(new[] { ';', ',', '|' });
```

### Join - Juntar Array em String

```csharp
string[] palavras = { "C#", "é", "legal" };

// Juntar com espaço
string frase = string.Join(" ", palavras);  // "C# é legal"

// Juntar com separador
string csv = string.Join(",", palavras);     // "C#,é,legal"
string lista = string.Join(" | ", palavras); // "C# | é | legal"
```

### Validação

```csharp
string vazio = "";
string espacos = "   ";
string nulo = null;

// IsNullOrEmpty - verifica null OU vazio
bool teste1 = string.IsNullOrEmpty(vazio);    // true
bool teste2 = string.IsNullOrEmpty(espacos);  // false (tem espaços)
bool teste3 = string.IsNullOrEmpty(nulo);     // true

// IsNullOrWhiteSpace - verifica null, vazio OU só espaços
bool teste4 = string.IsNullOrWhiteSpace(vazio);    // true
bool teste5 = string.IsNullOrWhiteSpace(espacos);  // true (!)
bool teste6 = string.IsNullOrWhiteSpace(nulo);     // true
```

## ✅ Exemplo de Saída Esperada (Tarefa 8)

```
=== SISTEMA DE BUSCA ===
Produtos disponíveis: 5
Termo de busca: "LED"

Resultados encontrados: 1
  - Monitor LED 24pol
```

## 🎓 Desafios Extras

1. **PadLeft/PadRight**: Formate códigos com zeros à esquerda ("1" → "0001")
2. **Remove**: Remova parte de uma string usando `Remove(index, count)`
3. **ToCharArray**: Converta string para array de caracteres e inverta
4. **Format**: Use `string.Format()` para formatar texto
5. **Normalização**: Remova acentos de uma string

## 📌 Dicas

- Strings em C# são **imutáveis** - métodos retornam nova string
- `Replace`, `ToUpper`, `Trim` etc. não modificam a original
- Use interpolação `$"{var}"` em vez de concatenação com `+`
- `IndexOf()` retorna -1 se não encontrar
- `Contains`, `StartsWith`, `EndsWith` são case-sensitive
- Para case-insensitive, use `ToLower()` antes de comparar
- `string.IsNullOrWhiteSpace()` é mais seguro que `IsNullOrEmpty()`
- Para muitas concatenações, use `StringBuilder` (mais eficiente)

## 🔗 Navegação

- [← Exercício Anterior](exercicio-12-listas.md) - Listas (List<T>)
- [🏠 Voltar ao Início](../README.md)
