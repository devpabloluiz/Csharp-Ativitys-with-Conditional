
public class Program
{
  static void Main(string[] args)
  {
    int mes;

    Console.Write("Digite o número do mês: ");
    mes = int.Parse(Console.ReadLine());

    switch(mes)
    {
        case 1:
        Console.Write("Janeiro");
        break;

        case 2:
        Console.Write("Fevereiro");
        break;

        case 3:
        Console.Write("Março");
        break;

        case 4:
        Console.Write("Abril");
        break;

        case 5:
        Console.Write("Maio");
        break;

        case 6:
        Console.Write("Junho");
        break;

        case 7:
        Console.Write("Julho");
        break;

        case 8:
        Console.Write("Agosto");
        break;

        case 9:
        Console.Write("Setembro");
        break;

        case 10:
        Console.Write("Outubro");
        break;

        case 11:
        Console.Write("Novembro");
        break;

        case 12:
        Console.Write("Dezembro");
        break;    
        default:
        Console.Write("Mês inválido!");
        break;      
    }
  }
}