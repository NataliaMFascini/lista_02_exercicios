/* 8) Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia.
 * O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0.
 * O programa deve calcular o total de minutos atendidos.
 * */

int chamadas = 0;
int minutos = 0;
int minutosTotal = 0;
int mediaMinutos = 0;

//while
while (mediaMinutos == 0)
{
    Console.WriteLine("Digite a duração da chamada:");
    minutos = Convert.ToInt32(Console.ReadLine());

    if (minutos != 0)
    {
        chamadas++;
        minutosTotal += minutos;
    }
    else
    {
        mediaMinutos = minutosTotal / chamadas;
    }
}

//do while
do
{
    Console.WriteLine("Digite a duração da chamada:");
    minutos = Convert.ToInt32(Console.ReadLine());

    if (minutos != 0)
    {
        chamadas++;
        minutosTotal += minutos;
    }
    else
    {
        mediaMinutos = minutosTotal / chamadas;
    }
} while (mediaMinutos == 0);

//for
for (int i = 0; mediaMinutos == 0; i++)
{
    Console.WriteLine("Digite a duração da chamada:");
    minutos = Convert.ToInt32(Console.ReadLine());

    if (minutos != 0)
    {
        chamadas++;
        minutosTotal += minutos;
    }
    else
    {
        mediaMinutos = minutosTotal / chamadas;
    }
}

Console.WriteLine($"Você atendeu {chamadas} chamada(s). Duração total: {minutosTotal} minutos / Média por chamada: {mediaMinutos} minutos.");