/* 6) Durante uma eleição, um mesário deve contar os votos.
 * O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0.
 * O programa deve contar quantos votos cada candidato recebeu, implementando while, do while e for.
 */

int votoA = 0;
int votoB = 0;
int voto = 1;

//while
while (voto != 0)
{
    Console.WriteLine("Insira seu voto (Candidato A: 1 / Candidato B: 2 / Digite 0 para encerrar): ");
    voto = Convert.ToInt32(Console.ReadLine());

    if (voto == 1) votoA++;
    else if (voto == 2) votoB++;
    else if (voto == 0)
    {
        Console.WriteLine("Votação encerrada. Total de votos: " + (votoA + votoB));
    }
    else
    {
        Console.WriteLine("Número invalido. Não há candidato vinculado a esse número.");
    }
}

//do while
do
{
    Console.WriteLine("Insira seu voto (Candidato A: 1 / Candidato B: 2 / Digite 0 para encerrar): ");
    voto = Convert.ToInt32(Console.ReadLine());

    if (voto == 1) votoA++;
    else if (voto == 2) votoB++;
    else if (voto == 0)
    {
        Console.WriteLine("Votação encerrada. Total de votos: " + (votoA + votoB));
    }
    else
    {
        Console.WriteLine("Número invalido. Não há candidato vinculado a esse número.");
    }
} while (voto != 0);


//for
for (int i = 1; voto != 0; i++)
{
    Console.WriteLine("Insira seu voto (Candidato A: 1 / Candidato B: 2 / Digite 0 para encerrar): ");
    voto = Convert.ToInt32(Console.ReadLine());

    if (voto == 1) votoA++;
    else if (voto == 2) votoB++;
    else if (voto == 0)
    {
        Console.WriteLine("Votação encerrada. Total de votos: " + (votoA + votoB));
    }
    else
    {
        Console.WriteLine("Número invalido. Não há candidato vinculado a esse número.");
    }
}

Console.WriteLine($"Contagem de votos: Candidato A = {votoA} / Candidato B = {votoB}");
if(votoA > votoB)
{
    Console.WriteLine("Candidato A venceu.");
}
else if(votoB > votoA)
{
    Console.WriteLine("Candidato B venceu.");
}
else
{
    Console.WriteLine("Empate");
}