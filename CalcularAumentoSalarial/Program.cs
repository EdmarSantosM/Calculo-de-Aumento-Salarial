
public class Program
{
    static void Main(string[]arg)
    {
        Console.WriteLine();

        Console.WriteLine($"\tCalule o valor de atualização sobre o salário");
        Console.WriteLine(" ----------------------------------------------------------------- ");

        Decimal salarioAtual = 0; // Variavél
        Console.Write($" Digite o valor atual do salário R$");
        salarioAtual = Convert.ToDecimal(Console.ReadLine()); // ReadLine  recebe  o valor  em formato string

        Decimal percentual = 0; // Variavél
        Console.Write($" Digite o valor percentual de cálculo base para acréscimo %");
        percentual = Convert.ToDecimal(Console.ReadLine()); // Convert.ToDecimal   converte de  string  para valor decimal

            // criando  cálculo
            salarioAtual = (salarioAtual + (salarioAtual *(percentual/100)));

            // exibição de  resultado
            Console.WriteLine(" ----------------------------------------------------------------- ");
            Console.WriteLine($" O salário atualizado é de 'R${salarioAtual}'");
            Console.WriteLine(" ----------------------------------------------------------------- ");

            Console.ReadKey();
            

    }
}