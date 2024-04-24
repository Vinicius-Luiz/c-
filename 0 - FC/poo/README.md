# Tipos de Dados Numéricos em C#:

## Inteiros

- int: Armazena números inteiros de -2.147.483.648 a 2.147.483.647. Ideal para quantidades discretas (ex: id de produto, idade).
- long: Armazena números inteiros maiores, de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807. Útil para valores muito grandes (ex: população de um país).
- byte: Armazena números inteiros de 0 a 255. Ideal para valores pequenos e sem sinal (ex: código de cores).
- short: Armazena números inteiros de -32.768 a 32.767. Otimizado para valores intermediários sem sinal (ex: temperaturas).

```c#
int idade = 30; // Variável 'idade' do tipo 'int' armazena 30 anos.
long populacao = 1000000000; // Variável 'populacao' do tipo 'long' armazena 1 bilhão.
byte codigoCor = 255; // Variável 'codigoCor' do tipo 'byte' armazena o valor máximo de cor (branco).
short temperatura = 20; // Variável 'temperatura' do tipo 'short' armazena 20°C.
```

## Decimais

- float: Armazena números de ponto flutuante de precisão simples (7 dígitos significativos). Ideal para valores com casas decimais (ex: preços, notas).
- double: Armazena números de ponto flutuante de precisão dupla (15 dígitos significativos). Útil para valores com alta precisão (ex: cálculos científicos).
- decimal: Armazena números decimais de alta precisão (28-29 dígitos significativos). Ideal para operações financeiras e cálculos que exigem exatidão (ex: valores monetários, taxas de juros).

```c#
float preco = 12.50f; // Variável 'preco' do tipo 'float' armazena R$ 12,50.
double distancia = 100000.00; // Variável 'distancia' do tipo 'double' armazena 100 km com alta precisão.
decimal valorFinanciamento = 234567.89m; // Variável 'valorFinanciamento' do tipo 'decimal' armazena um valor monetário preciso.
```

## Lógicos e de Texto

- bool: Armazena valores lógicos (verdadeiro ou falso). Ideal para condições e testes (ex: usuário logado, produto disponível).
- char: Armazena um único caractere Unicode (16 bits). Útil para textos curtos e individuais (ex: letra de uma palavra, tecla pressionada).
- string: Armazena sequências de caracteres, formando textos. Ideal para frases, parágrafos e dados textuais em geral (ex: nomes, descrições).
```c#
bool estaLogado = true; // Variável 'estaLogado' do tipo 'bool' indica se o usuário está logado (verdadeiro).
char letra = 'a'; // Variável 'letra' do tipo 'char' armazena o caractere 'a'.
string nomeCompleto = "João da Silva"; // Variável 'nomeCompleto' do tipo 'string' armazena o nome completo "João da Silva".
```