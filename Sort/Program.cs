using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = EncherOVetor(50);

            Console.WriteLine("Array antes de ordenar:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            int temporario;

            for (int j = 0; j <= vetor.Length - 2; j++)
            {
                for (int i = 0; i <= vetor.Length - 2; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        temporario = vetor[i + 1];
                        vetor[i + 1] = vetor[i];
                        vetor[i] = temporario;
                    }
                }
            }

            Console.WriteLine("\nArray depois de ordenado:");

            foreach (int i in vetor)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }


        public static int[] EncherOVetor(int tamanhoDoArray)
        {
            int[] vetorCheio = new int[tamanhoDoArray];
            Random rnd = new Random();

            for (int i = 0; i < tamanhoDoArray; i++)
            {

                vetorCheio[i] = rnd.Next(1, 100);
            }

            return vetorCheio;
        }

    }
}
