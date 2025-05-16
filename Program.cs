double nota1, nota2, nota3, nota4;
string resultado;

Console.Clear();

ExibeBoasVindas();

nota1 = SolicitaNota(1);
nota2 = SolicitaNota(2);
nota3 = SolicitaNota(3);
nota4 = SolicitaNota(4);

if (!ValidaNotas(nota1, nota2, nota3, nota4))
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Environment.Exit(0);
}

// Console.WriteLine("1ª nota: ");
// nota1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("2ª nota: ");
// nota2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("3ª nota: ");
// nota3 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("4ª nota: ");
// nota4 = Convert.ToDouble(Console.ReadLine());

void ExibeBoasVindas()
{
    Console.WriteLine(@"
-- Média --

Digite as notas a serem calculadas:
");
}

double SolicitaNota(int ordemNota)//parametro, n variável
{
    Console.Write($"Nota {ordemNota}: ");
    return Convert.ToDouble(Console.ReadLine()); 
}

bool ValidaNotas(double N1, double N2, double N3, double N4)
{
    bool nota1Valida = ValidaNota(N1);
    bool nota2Valida = ValidaNota(N2);
    bool nota3Valida = ValidaNota(N3);
    bool nota4Valida = ValidaNota(N4);

    return nota1Valida && nota2Valida
        && nota3Valida && nota4Valida;
}

bool ValidaNota (double nota)
{
    return nota >= 0 && nota <= 10;
    //false quando houver alguma nota < 0 ou nota > 10
}

