using System;
using System.Globalization;

namespace Mercado2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade1, quantidade2, quantidade3, quantidade4, quantidade5, quantidade6, quantidade7;
            float precoProduto1, precoProduto2, precoProduto3, precoProduto4, precoProduto5, precoProduto6, precoProduto7, valorTotal1, valorTotal2, valorTotal3, valorTotal4, valorTotal5, valorTotal6, valorTotal7, troco1, troco2,
                    troco3, troco4, troco5, troco6, troco7, dinheiro1, dinheiro2, dinheiro3, dinheiro4, dinheiro5, dinheiro6, dinheiro7, v2, v3, v4, v5, v6, v7, r2, r3, r4, r5, r6, r7;
            string nomeProduto1, nomeProduto2, nomeProduto3, nomeProduto4, nomeProduto5, nomeProduto6, nomeProduto7;
            char S = 's';

            
            Console.WriteLine("Digite o nome do produto1");
            nomeProduto1= Console.ReadLine();
            Console.WriteLine("Digite o preço do produto1");
            precoProduto1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade do produto");
            quantidade1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não " );
            valorTotal1 = quantidade1 * precoProduto1;
            Console.WriteLine("O valor da sua compra está dando R$ " + valorTotal1);
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal1 = quantidade1 * precoProduto1;
                Console.WriteLine("Digite a quantidade de dinheiro entregue pelo cliente!");
                dinheiro1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                troco1 = dinheiro1 - valorTotal1;
                Console.WriteLine("O seu produto é: " + nomeProduto1 + " A quantidade foi: " + quantidade1 + " O preco total foi: R$ " + precoProduto1.ToString("F1", CultureInfo.InvariantCulture) + "O valor total é R$ " + valorTotal1.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Confira o seu troco R$ " + troco1.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }
            
            Console.WriteLine("Digite o nome do produto2");
            nomeProduto2 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto2");
            precoProduto2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto2");
            quantidade2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não ");
            valorTotal2 = quantidade2 * precoProduto2;
            r2 = (valorTotal1 + valorTotal2);
            Console.WriteLine("O valor da sua compra está dando R$ " + r2.ToString("F2", CultureInfo.InvariantCulture));
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal2 = quantidade2 * precoProduto2;
                Console.WriteLine("Digite a quantidade de dinheiro entregue pelo cliente!");
                dinheiro2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                v2 = valorTotal1 + valorTotal2;
                troco2 = dinheiro2 - v2;
                Console.WriteLine("Os seus produtos são: " + nomeProduto1 + (", ") + nomeProduto2 + " A quantidade foi: " + (quantidade1 + quantidade2) + " O preco do produto foi R$ "  + precoProduto2.ToString("F1", CultureInfo.InvariantCulture) + "O valor total é R$ " + v2.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Confira o seu troco R$ " + troco2.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }
            
            Console.WriteLine("Digite o nome do produto3");
            nomeProduto3 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto3");
            precoProduto3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto3");
            quantidade3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não ");
            valorTotal3 = quantidade3 * precoProduto3;
            r3 = (valorTotal1 + valorTotal2 + valorTotal3);
            Console.WriteLine("O valor da sua compra está dando R$ " + r3.ToString("F2", CultureInfo.InvariantCulture));
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal3 = quantidade3 * precoProduto3;
                Console.WriteLine("Digite a quantidade de dinheiro entregue pelo cliente!");
                dinheiro3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                v3 = valorTotal1 + valorTotal2 + valorTotal3;
                troco3 = dinheiro3 -  (valorTotal1 + valorTotal2 + valorTotal3);
                Console.WriteLine("Os seus produtos são: " + nomeProduto1 + (", ") +  nomeProduto2 + (", ")+  nomeProduto3 + " A quantidade foi: " + (quantidade1 + quantidade2 + quantidade3) + " O preco total foi: "  + precoProduto3.ToString("F1", CultureInfo.InvariantCulture) + "O valor total é: " + v3.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Confira o seu troco R$ " + troco3.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }

            Console.WriteLine("Digite o nome do produto4");
            nomeProduto4 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto4");
            precoProduto4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto4");
            quantidade4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não ");
            valorTotal4 = quantidade4 * precoProduto4;
            r4 = (valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4);
            Console.WriteLine("O valor da sua compra está dando R$ " + r4.ToString("F2", CultureInfo.InvariantCulture));
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal4 = quantidade4 * precoProduto4;
                Console.WriteLine("Digite a quantidade de dinheiro entregue pelo cliente!");
                dinheiro4 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                v4 = valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4;
                troco4 = dinheiro4 - v4;
                Console.WriteLine("Os seus produtos são: " + nomeProduto1 + (", ") + nomeProduto2 + (", ") + nomeProduto3 + (", ") + nomeProduto4 + " A quantidade foi: " + (quantidade1 + quantidade2 + quantidade3 + quantidade4) + " O preco do produto foi: " + precoProduto4.ToString("F1", CultureInfo.InvariantCulture) + "O valor total é R$ " + v4.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Confira o seu troco R$ " + troco4.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }

            Console.WriteLine("Digite o nome do produto5");
            nomeProduto5 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto5");
            precoProduto5 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto5");
            quantidade5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não ");
            valorTotal5 = quantidade5 * precoProduto5;
            r5 = (valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4 + valorTotal5);
            Console.WriteLine("O valor da sua compra está dando R$ " + r5.ToString("F2", CultureInfo.InvariantCulture));
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal5 = quantidade5 * precoProduto5;
                Console.WriteLine("Digite a quantidade de dinheiro entregue pelo cliente!");
                dinheiro5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                v5 = valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4 + valorTotal5;
                troco5 = dinheiro5 - v5;
                Console.WriteLine("Os seus produtos são: "  + nomeProduto1 +(", ") + nomeProduto2+ (", ") + nomeProduto3 +(", ") + nomeProduto4 + (", ") + nomeProduto5 + " A quantidade foi: " + (quantidade1 + quantidade2 + quantidade3 + quantidade4 + quantidade5) + " O preco do produto foi: " + precoProduto5.ToString("F1", CultureInfo.InvariantCulture) + "O valor total é R$ " + v5.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Confira o seu troco R$ " + troco5.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }

            Console.WriteLine("Digite o nome do produto6");
            nomeProduto6 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto6");
            precoProduto6 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto6");
            quantidade6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Todos os produtos já foram registrados? Digite s para sim e n para não ");
            valorTotal6 = quantidade6 * precoProduto6;
            r6 = (valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4 + valorTotal5 + valorTotal6);
            Console.WriteLine("O valor da sua compra está dando R$ " + r6.ToString("F2", CultureInfo.InvariantCulture));
            S = char.Parse(Console.ReadLine());
            while (S == 's')
            {
                valorTotal6  = quantidade6 * precoProduto6;
                Console.WriteLine("Digite a quantidade de dinheiro entregue pelo cliente!");
                dinheiro6 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                v6 = valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4 + valorTotal5 + valorTotal6;
                troco6 = dinheiro6 - v6;
                Console.WriteLine("Os seus produtos são: " + nomeProduto1 + (", ") + nomeProduto2 + (", ") + nomeProduto3 + (", ") + nomeProduto4 + (", ") + nomeProduto5 + (", ") + nomeProduto6 +  " A quantidade foi: " + (quantidade1 + quantidade2 + quantidade3 + quantidade4 + quantidade5 + quantidade6) + " O preco do produto foi: " + precoProduto6.ToString("F1", CultureInfo.InvariantCulture) + "O valor total é R$ " + v6.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Confira o seu troco R$ " + troco6.ToString("F2", CultureInfo.InvariantCulture));
                Console.ReadLine();
            }

            Console.WriteLine("Digite o nome do produto7");
            nomeProduto7 = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto7");
            precoProduto7 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto7");
            quantidade7 = int.Parse(Console.ReadLine());
            valorTotal7 = quantidade7 * precoProduto7;
            r7 = (valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4 + valorTotal5 + valorTotal6 + valorTotal7);
            Console.WriteLine("O valor da sua compra está dando R$ " + r7.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Digite a quantidade de dinheiro entregue pelo cliente!");
            dinheiro7 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            v7 = valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4 + valorTotal5 + valorTotal6 + valorTotal7;
            troco7 = dinheiro7 - v7;
            Console.WriteLine("O seu produto é: " + nomeProduto1 + (", ") + nomeProduto2 + (", ")+ nomeProduto3 + (", ") + nomeProduto4 + (", ") + nomeProduto5 + (", ") + nomeProduto6+ (", ") + nomeProduto7 + (", ") + " A quantidade foi: " + (quantidade1 + quantidade2 + quantidade3 + quantidade4 + quantidade5 + quantidade6 + quantidade7) + "O valor total é R$ " + v7.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Confira o seu troco R$ " + troco7.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
            
            /*troco7 = dinheiro7 - v7;
            v7 = valorTotal1 + valorTotal2 + valorTotal3 + valorTotal4 + valorTotal5 + valorTotal6 + valorTotal7;
            Console.WriteLine("O valor total da sua compra foi R$ " + v7 + "E troco foi R$ " + troco7);*/







            //Console.ReadLine();
        }
    }
}
//.ToString("F2", CultureInfo.InvariantCulture));
