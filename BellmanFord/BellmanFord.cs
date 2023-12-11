class BellmanFord
{
    public void bellmanFord(int[,] graph, int vertices, int source)
    {
		Console.ResetColor();
        int[] distance = new int[vertices];
        
        // Inicializa a distância de todos os vértices como infinito, exceto o vértice de origem
        for (int i = 0; i < vertices; ++i)
            distance[i] = int.MaxValue;
        distance[source] = 0;

        // Relaxa as arestas repetidamente para encontrar a menor distância
        for (int i = 0; i < vertices - 1; ++i)
        {
            for (int u = 0; u < vertices; ++u)
            {
                for (int v = 0; v < vertices; ++v)
                {
                    if (graph[u, v] != 0 && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];
                    }
                }
            }
        }

        // Verifica ciclos negativos
        for (int u = 0; u < vertices; ++u)
        {
            for (int v = 0; v < vertices; ++v)
            {
                if (graph[u, v] != 0 && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                {
                    Console.WriteLine("O grafo contém um ciclo negativo!");
                    return;
                }
            }
        }

        // Imprime as distâncias mínimas
        Console.WriteLine("Distâncias mínimas do vértice {0}:", source);
        for (int i = 0; i < vertices; ++i)
        {
            Console.WriteLine("Para o vértice {0}: {1}", i, distance[i]);
        }
    }
}
