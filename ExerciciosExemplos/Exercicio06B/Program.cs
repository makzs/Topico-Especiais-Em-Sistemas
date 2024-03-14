// Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.
//B. Utilizar uma função em C# para ordenação;


namespace Exercicio06B;

class Program
{
    // indicação de que vai rodar em um terminal
    static void Main(string[] args)
    {
        // criar vetor de 100 posicoes
        int[] vetor = new int[100];

        // Cria um objeto random
        Random aleatorio = new Random();

        // preencher o vetor com valores aleatorios
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aleatorio.Next(100);

        }

        Console.WriteLine("Lista de numeros aleatorios: ");

        // imprimir vetor
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " - ");
        }

        Console.WriteLine("\n\nLista de numeros ordenados: ");

        // ordenar vetor com uma função
        Array.Sort(vetor);

        // imprimir vetor
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " - ");
        }

    }
}
