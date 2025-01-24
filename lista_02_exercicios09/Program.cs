/* 9) Um cliente deseja saber o total de suas compras em um supermercado.
 * O aluno deve solicitar que o usuario insira o valor de cada compra até que ele digite 0.
 * A soma dos valores das compras deve ser implementada usando as tres estruturs de repetição
 * */

double valor = 0;
int quantidadeCompras = 0;
double compras = 0;
double valorTotal = 0;

//while
while (valorTotal == 0)
{
    Console.WriteLine("Digite o valor da compra:");
    valor = Convert.ToDouble(Console.ReadLine());

    if (valor != 0)
    {
        quantidadeCompras++;
        compras += valor;
    }
    else
    {
        valorTotal = compras;
    }
}

//do while
do
{
    Console.WriteLine("Digite o valor da compra:");
    valor = Convert.ToDouble(Console.ReadLine());

    if (valor != 0)
    {
        quantidadeCompras++;
        compras += valor;
    }
    else
    {
        valorTotal = compras;
    }
} while (valorTotal == 0);

//for
for (int i = 0; valorTotal==0; i++)
{
    Console.WriteLine("Digite o valor da compra:");
    valor = Convert.ToDouble(Console.ReadLine());

    if (valor != 0)
    {
        quantidadeCompras++;
        compras += valor;
    }
    else
    {
        valorTotal = compras;
    }
}

Console.WriteLine($"Você gastou um total de {valorTotal}. Você fez compras {quantidadeCompras} vezes.");