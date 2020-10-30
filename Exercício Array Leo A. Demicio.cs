using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace Exercício_Array___Classe_Leo_A._Demicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de quantos objetos serão analisados.
            Console.WriteLine("Digite o número de produtos a serem analisados: ");
            int n = int.Parse(Console.ReadLine());

            // criação de um vetor.
            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                // declaração de variáveis "nome" e "preço" por objeto citado anteriormente.
                Console.Write("Digite o nome do produto: ");
                Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double media;
            media += vetor[n] / 3;


            Console.WriteLine("A média dos preços dos produtos é: " + media);
            Console.ReadKey();

            // o programa não roda, devido a um erro que eu não sei resolver, mas em meu ver, a ideia do código esta certa.
            // o professor Ovídio dizia que melhor do que decorar padrões, é entender o que esta sendo feito no código.
            // a meu ver, o código está certo, ao menos em sua (código) lógica, mas ele não roda por causa de um erro,
            // que na minha opinião é bobo, mas que eu não sei resolver.
            // PS: eu tentei copiar o código de exemplo para ver no que dava, mas não rodou, peo contrário, deu vários erros,
            // por isso, eu tive de improvisar, e acabou ficando assim...
        }
    }
}
