using System;

class FloydWarshall
{
    private const int INF = int.MaxValue;

    public static void ShortestPaths(int[,] graph)
    {
        int n = graph.GetLength(0);
        int[,] dist = new int[n, n];

        // Inicializar distâncias
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                    dist[i, j] = 0;
                else
                    dist[i, j] = INF;
            }
        }

        // Inicializar distâncias com base nas arestas do grafo
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (graph[i, j] != 0)
                    dist[i, j] = graph[i, j];
            }
        }

        // Aplicar o algoritmo de Floyd-Warshall
        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dist[i, k] != INF && dist[k, j] != INF && dist[i, j] > dist[i, k] + dist[k, j])
                        dist[i, j] = dist[i, k] + dist[k, j];
                }
            }
        }

        // Imprimir os resultados
        Console.WriteLine("Matriz de distâncias mínimas:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (dist[i, j] == INF)
                    Console.Write("INF\t");
                else
                    Console.Write(dist[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Exemplo de uso
    static void Main()
    {
        int[,] graph = {
            {0, 3, INF, 7},
            {8, 0, 2, INF},
            {5, INF, 0, 1},
            {2, INF, INF, 0}
        };

        ShortestPaths(graph);
    }
}
