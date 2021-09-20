using System;
using System.Globalization;

namespace Mercado2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade1, quantidade2, quantidade3, quantidade4, quantidade5, quantidade6, quantidade7;
            float precoProduto1, precoProduto2, precoProduto3, precoProduto4, precoProduto5, precoProduto6, precoProduto7, valorTotal1, valorTotal2,resultadoFinal2, troco;
            string nomeProduto1, nomeProduto2, nomeProduto3, nomeProduto4, nomeProduto5, nomeProduto6, nomeProduto7, fim;
            char S = 's';

            
            Console.WriteLine("Digite o nome do produto1");
            nomeProduto1= Console.ReadLine();
            Console.WriteLine("Digite o preço do produto1");
            precoProduto1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade do produto");
            quantidade1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não " );
            valorTotal1 = quantidade1 * precoProduto1;
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal1 = quantidade1 * precoProduto1;
                Console.WriteLine("O seu produto é: " + nomeProduto1 + " A quantidade foi: " + quantidade1 + " O preco total foi: " + precoProduto1 + "O valor total é: " + valorTotal1.ToString("F2", CultureInfo.InvariantCulture));

            }

            Console.WriteLine("Digite o nome do produto2");
            nomeProduto2 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto2");
            precoProduto2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto2");
            quantidade2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não ");
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal2 = quantidade2 * precoProduto2;
                Console.WriteLine("O seu produto é: " + nomeProduto1 + nomeProduto2 + " A quantidade foi: " + (quantidade1 + quantidade2) + " O preco total foi: " + precoProduto1 + "O valor total é: " + (valorTotal1 + valorTotal2));
                Console.ReadLine();
            }if (S != 's')
            
                
            Console.WriteLine("Digite o nome do produto3");
            nomeProduto3 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto3");
            precoProduto3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto3");
            quantidade3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome do produto4");
            nomeProduto4 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto4");
            precoProduto4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto4");
            quantidade4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto5");
            nomeProduto5 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto5");
            precoProduto5 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto5");
            quantidade5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto6");
            nomeProduto6 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto6");
            precoProduto6 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto6");
            quantidade6 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto7");
            nomeProduto7 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto7");
            precoProduto7 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto7");
            quantidade7 = int.Parse(Console.ReadLine());







            Console.ReadLine();
        }
    }
}
//.ToString("F2", CultureInfo.InvariantCulture));