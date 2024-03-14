// Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.
//A. Desenvolver o algoritmo de ordenação (Bubble Sort);

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

Console.WriteLine("\n\n- - - - - - - - - - - - - - - - - - -");
Console.WriteLine("\nLista dos mesmos numeros ordenados: ");


// ordena os numeros aleatorios por bubble sort
bool troca = false;

do
{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        if (vetor[i] > vetor[i + 1])
        {
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
        }
    }

} while (troca == true);

// ordena os numeros aleatorios por bubble sort porem executa mais vezes que o necessario
/*
for (int i = 0; i < vetor.Length - 1; i++)
{
    for (int j = 0; j < vetor.Length - i - 1; j++)
    {
        if (vetor[j] > vetor[j + 1])
        {
            int temporario = vetor[j];
            vetor[j] = vetor[j + 1];
            vetor[j + 1] = temporario;
        }
    }
}
*/


// imprime na tela os numeros ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " - ");
}