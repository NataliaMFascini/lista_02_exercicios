/*5) Um gerente de loja quer saber quantos produtos estão em estoque. 
 * O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0.
 * Depois disso, o programa deve calcular a quantidade total de produtos em estoque.
 */

int recebido;
int vendido;
int total = 0;
int estoque = 0;

//while
while (total == 0)
{
    Console.WriteLine("Digite quantos produtos foram recebidos (Digite 0 para sair): ");
    recebido = Convert.ToInt32(Console.ReadLine());

    if (recebido != 0)
    {
        estoque += recebido;
    }

    Console.WriteLine("Digite quantos procutos foram vendidos (Digite 0 para sair): ");
    vendido = Convert.ToInt32(Console.ReadLine());

    if (vendido != 0)
    {
        estoque -= vendido;
    }
    if (recebido == 0 && vendido == 0)
    {
        total = estoque;
    }
}

//do while
do
{
    Console.WriteLine("Digite quantos produtos foram recebidos (Digite 0 para sair): ");
    recebido = Convert.ToInt32(Console.ReadLine());

    if (recebido != 0)
    {
        estoque += recebido;
    }

    Console.WriteLine("Digite quantos procutos foram vendidos (Digite 0 para sair): ");
    vendido = Convert.ToInt32(Console.ReadLine());

    if (vendido != 0)
    {
        estoque -= vendido;
    }
    if (recebido == 0 && vendido == 0)
    {
        total = estoque;
    }
} while (total == 0);

//for
for (int i = 0; total == 0; i++)
{
    Console.WriteLine("Digite quantos produtos foram recebidos (Digite 0 para sair): ");
    recebido = Convert.ToInt32(Console.ReadLine());

    if (recebido != 0)
    {
        estoque += recebido;
    }

    Console.WriteLine("Digite quantos procutos foram vendidos (Digite 0 para sair): ");
    vendido = Convert.ToInt32(Console.ReadLine());

    if (vendido != 0)
    {
        estoque -= vendido;
    }
    if (recebido == 0 && vendido == 0)
    {
        total = estoque;
    }
}

Console.WriteLine($"A quantidade total em estoque é de {total}.");