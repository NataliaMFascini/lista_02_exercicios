/*10) Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia.
 * O aluno deve padir ao usuario para inserir o valor das passagens vendidas até que ele digite um valor negativo.
 * O total de passagens vendidas deve ser calculado e apresentado utilizando while, do while e for.
 * */

int passagens = 0;
int passagensTotal = 0;
int valor = 5;
int valorTotal = 0;

//while
while (valorTotal == 0)
{
    Console.WriteLine("Digite a quantidade de passagens (Valor da passagem: R$ 5,00): ");
    passagens = Convert.ToInt32(Console.ReadLine());

    if (passagens >= 0)
    {
        passagensTotal += passagens;
    }
    else
    {
        valorTotal = passagensTotal * valor;
    }
}

//do while
do
{
    Console.WriteLine("Digite a quantidade de passagens (Valor da passagem: R$ 5,00): ");
    passagens = Convert.ToInt32(Console.ReadLine());

    if (passagens >= 0)
    {
        passagensTotal += passagens;
    }
    else
    {
        valorTotal = passagensTotal * valor;
    }
} while (valorTotal == 0);

//for
for (int i = 0; valorTotal == 0; i++)
{
    Console.WriteLine("Digite a quantidade de passagens (Valor da passagem: R$ 5,00): ");
    passagens = Convert.ToInt32(Console.ReadLine());

    if (passagens >= 0)
    {
        passagensTotal += passagens;
    }
    else
    {
        valorTotal = passagensTotal * valor;
    }
}

Console.WriteLine($"Foram vendidas {passagensTotal} passagens. Rendimento de R$ {valorTotal}.");