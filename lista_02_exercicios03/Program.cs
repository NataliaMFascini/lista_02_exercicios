/*3) Uma escola deseja saber quantos alunos foram aprovados em uma disciplina.
 * O aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao digitar -1, encerrará a entrada.
 * Em seguida, deve contar quantos alunos tiverm nota maior ou igual a 6, utilizando as três estruturas de repetição.
 */

int alunos = 0;
double encerrar = 0;
double nota = 0;

//while
while (encerrar != -1)
{
    Console.WriteLine("Digite a nota dos alunos:");
    nota = Convert.ToInt32(Console.ReadLine());

    if (nota >= 0 && nota <= 10 || nota == -1)
    {
        if (nota >= 6)
        {
            alunos++;
        }
    }
    else
    {
        Console.WriteLine("Valor incorreto");
    }

    encerrar = nota;
}

//do while
do
{
    Console.WriteLine("Digite a nota dos alunos:");
    nota = Convert.ToInt32(Console.ReadLine());

    if (nota >= 0 && nota <= 10 || nota == -1)
    {
        if (nota >= 6)
        {
            alunos++;
        }
    }
    else
    {
        Console.WriteLine("Valor incorreto");
    }

    encerrar = nota;
} while (encerrar != -1);

//for
for (encerrar = 0; encerrar != -1; encerrar = nota)
{
    Console.WriteLine("Digite a nota dos alunos:");
    nota = Convert.ToInt32(Console.ReadLine());

    encerrar = nota;

    if (nota >= 0 && nota <= 10 || nota == -1)
    {
        if (nota >= 6)
        {
            alunos++;
        }
    }
    else
    {
        Console.WriteLine("Valor incorreto");
    }
}

Console.WriteLine($"A quantidade de alunos aprovados é {alunos}");
