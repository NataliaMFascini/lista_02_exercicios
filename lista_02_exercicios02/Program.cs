/*2) Um usuário quer calcular suas despesas mensais.
 * O exercicio consiste em solicitar ao usuário que insira suas despesas até que ele digite um valor negativo, sinalizando o fim da entrada.
 */

int despesas = 0;
int pare = 0;

//while
while(pare >= 0)
{
    Console.WriteLine("Digite a despesa: ");
    int gastos = Convert.ToInt32(Console.ReadLine());
    pare = gastos;
    despesas += gastos;
}


//do while
do
{
    Console.WriteLine("Digite a despesa: ");
    int gastos = Convert.ToInt32(Console.ReadLine());
    pare = gastos;
    despesas += gastos;
}while(pare >= 0);

//for
for (int conta =0; conta >= 0; conta--)
{
    Console.WriteLine("Digite a despesa: ");
    int gastos = Convert.ToInt32(Console.ReadLine());
    conta = gastos;
    despesas += gastos;
}

Console.WriteLine($"O valor das despesas é R$ {despesas}.");