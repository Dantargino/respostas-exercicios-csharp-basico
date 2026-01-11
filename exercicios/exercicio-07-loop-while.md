# Exercício 07 - Loop While

## 🎯 Objetivos de Aprendizagem

- Utilizar a estrutura de repetição while
- Entender a diferença entre for e while
- Trabalhar com condições de parada
- Implementar loops baseados em eventos

## 📝 Cenário

O sistema da loja precisa de funcionalidades onde não sabemos exatamente quantas vezes o loop vai executar: sistema de caixa que processa vendas até o operador encerrar, validação de entrada até o usuário digitar corretamente, e processamento de estoque até atingir uma condição.

## 📋 Tarefas

### Tarefa 1: Sistema de Caixa Simples

Simule um sistema de caixa que processa vendas até o operador digitar 0:

```
Valores de exemplo das vendas:
Venda 1: R$ 150,00
Venda 2: R$ 80,00
Venda 3: R$ 220,00
Venda 4: R$ 95,00
Venda 5: 0 (encerra)
```

Use while para:
1. Processar cada venda
2. Acumular o total
3. Contar quantas vendas foram realizadas
4. Exibir o resumo ao final

**Dica**: Simule a entrada do usuário com variáveis predefinidas ou use `Console.ReadLine()`.

### Tarefa 2: Validação de Senha

Crie um sistema de login que pede a senha até o usuário acertar (máximo 3 tentativas):

- Senha correta: "loja2026"
- Tentativas permitidas: 3

Simule tentativas:
1. Tentativa 1: "senha123" (errada)
2. Tentativa 2: "loja2025" (errada)
3. Tentativa 3: "loja2026" (correta)

Use while para:
1. Verificar a senha
2. Contar tentativas
3. Bloquear após 3 tentativas erradas
4. Exibir mensagem apropriada

### Tarefa 3: Reabastecimento de Estoque

Crie um sistema que simula o reabastecimento de estoque:

- Produto: "Água Mineral"
- Estoque inicial: 45
- Estoque desejado: 100
- Quantidade por caixa: 12

Use while para:
1. Adicionar caixas até atingir ou ultrapassar o estoque desejado
2. Contar quantas caixas foram necessárias
3. Exibir o estoque final
4. Calcular se houve excedente

### Tarefa 4: Processamento de Vendas com Meta

Crie um sistema que processa vendas até atingir a meta diária:

- Meta diária: R$ 5.000,00
- Vendas (processar até atingir meta):
  - R$ 850,00
  - R$ 1.200,00
  - R$ 650,00
  - R$ 980,00
  - R$ 1.500,00
  - R$ 420,00

Use while para:
1. Processar vendas até atingir a meta
2. Contar quantas vendas foram necessárias
3. Exibir se ultrapassou a meta e por quanto
4. Calcular o valor médio por venda

### Tarefa 5: Menu Interativo

Crie um menu que executa até o usuário escolher "Sair":

```
Menu:
1 - Consultar Estoque
2 - Registrar Venda
3 - Emitir Relatório
0 - Sair
```

Simule escolhas:
1. Escolha 1: Exibe "Consultando estoque..."
2. Escolha 2: Exibe "Registrando venda..."
3. Escolha 3: Exibe "Emitindo relatório..."
4. Escolha 0: Encerra

Use while para manter o menu ativo até escolher 0.

## 💡 Conceitos Importantes

### While Básico

```csharp
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine($"Contagem: {contador}");
    contador++;  // IMPORTANTE: incrementar para evitar loop infinito
}
```

### While com Condição Complexa

```csharp
decimal total = 0;
decimal meta = 1000;
int vendas = 0;

while (total < meta && vendas < 10)
{
    decimal venda = 150;  // Simular venda
    total += venda;
    vendas++;
}
```

### While com Flag (Bandeira)

```csharp
bool continuar = true;
int tentativas = 0;

while (continuar)
{
    tentativas++;
    
    if (tentativas >= 3)
    {
        continuar = false;  // Para o loop
    }
}
```

### While True com Break

```csharp
while (true)
{
    Console.WriteLine("Digite 0 para sair:");
    int valor = int.Parse(Console.ReadLine());
    
    if (valor == 0)
    {
        break;  // Sai do loop
    }
    
    // Processar valor
}
```

### Do-While (executa pelo menos uma vez)

```csharp
int numero;

do
{
    Console.WriteLine("Digite um número positivo:");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);
```

### For vs While

**Use For quando:**
- Sabe quantas iterações serão necessárias
- Tem um contador definido
- Exemplo: processar 10 produtos

**Use While quando:**
- Não sabe quantas iterações serão necessárias
- Depende de uma condição que pode mudar
- Exemplo: processar até o usuário digitar "sair"

## ✅ Exemplo de Saída Esperada (Tarefa 1)

```
=== SISTEMA DE CAIXA ===
Venda 1: R$ 150,00
Venda 2: R$ 80,00
Venda 3: R$ 220,00
Venda 4: R$ 95,00
Encerrando caixa...

=== RESUMO DO CAIXA ===
Total de Vendas: 4
Valor Total: R$ 545,00
Ticket Médio: R$ 136,25
```

## 🎓 Desafios Extras

1. **Jogo de Adivinhação**: Crie um jogo onde o sistema "pensa" em um número e o usuário tenta adivinhar
2. **Validação de CPF**: Peça um CPF até o usuário digitar um com 11 dígitos
3. **Contador de Notas**: Simule um caixa eletrônico que calcula quantas notas de cada valor são necessárias
4. **Fila de Atendimento**: Simule uma fila onde clientes são atendidos até a fila esvaziar
5. **Desconto Progressivo**: A cada R$ 500 em vendas, aumente o desconto em 5%

## 📌 Dicas

- **SEMPRE** garanta que a condição do while eventualmente se torne falsa (evite loops infinitos)
- Inicialize variáveis de controle antes do while
- Use `while (true)` com `break` quando a condição de saída é complexa
- Para simular entrada do usuário em exercícios, use arrays:
  ```csharp
  decimal[] vendas = { 150, 80, 220, 95, 0 };
  int indice = 0;
  
  while (vendas[indice] != 0)
  {
      // Processar vendas[indice]
      indice++;
  }
  ```
- Cuidado com condições que nunca se tornam verdadeiras/falsas
- Use variáveis booleanas para tornar condições mais legíveis:
  ```csharp
  bool metaAtingida = total >= meta;
  bool limiteAtingido = vendas >= 10;
  
  while (!metaAtingida && !limiteAtingido)
  {
      // código
  }
  ```

## 🔗 Navegação

- [← Exercício Anterior](exercicio-06-loop-for.md) - Loop For
- [Próximo Exercício →](exercicio-08-foreach-controle-fluxo.md) - Foreach e Controle de Fluxo
