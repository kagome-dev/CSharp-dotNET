/* Você foi contratado por uma empresa beneficente, que recebe doações de pessoas físicas e jurídicas para ajudar comunidades carentes. Algumas dessas doações são anônimas, e outras são registradas com os dados do doador. Além disso, as doações são depositadas em dois tipos de contas: corrente ou poupança. Recentemente, uma doação anônima no valor de R$500 foi feita para a conta poupança da empresa.

Crie um programa que:

Declare uma variável para armazenar o valor recebido da doação.
Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
Declare uma variável para indicar o tipo de conta onde o valor foi depositado:
Use P para conta poupança.
Use C para conta corrente
Saída esperada:

Valor recebido: R$500 
Doação anônima: True 
Tipo de conta: P */

float valorRecebidoDoacao = 500.00f;
bool tipoDeDoacao = True;
char tipoDeConta = 'P';

Console.WriteLine("Valor recebido: R$" + valorRecebidoDoacao);
Console.WriteLine("Doação anônima: " + tipoDeDoacao);
Console.WriteLine("Tipo de conta: " + tipoDeConta);
