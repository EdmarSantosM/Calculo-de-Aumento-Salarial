
public class Program
{
    static void Main(string[]arg)
    {
        Console.WriteLine();

        Console.WriteLine($"\tCalule o valor de atualização sobre o salário");
        Console.WriteLine(" ----------------------------------------------------------------- ");

        Decimal salarioAtual = 0;
        Console.Write($" Digite o valor atual do salário R$");
        salarioAtual = Convert.ToDecimal(Console.ReadLine());

        Decimal percentual = 0;
        Console.Write($" Digite o valor percentual de cálculo base para acréscimo %");
        percentual = Convert.ToDecimal(Console.ReadLine());
        

    }
}