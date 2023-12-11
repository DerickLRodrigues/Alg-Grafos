class Dijkstra {
  //Uma função utilitária para encontrar o vértice com
  //o valor de distância mínima, dado um conjunto de vértices
  //não incluídos ainda na árvore de caminho mais curto
    static int V = 10;
    static string rotuloVertices = "ABCDEFGHIJ";
    int minDistance(int[] dist, bool[] sptSet)
    {
        // Inicialize o valor mínimo
        int min = int.MaxValue, min_index = -1;

        for (int v = 0; v < V; v++)
            if (sptSet[v] == false && dist[v] <= min) {
                min = dist[v];
                min_index = v;
            }

        return min_index;
    }

    //Uma função utilitária para printar o array de distâncias construído
    void printSolution(int[] dist, int n)
    {
        Console.ResetColor();
        Console.WriteLine("Resultado final: ");
        Console.Write("Vértice     Distância " + "da origem\n");
        for (int i = 0; i < V; i++) {
          Console.Write(rotuloVertices[i] + " \t\t\t " + dist[i] + "\n");
        }

    }

    //Função que implementa o algoritmo de caminho mais
    //curto dado um vértice de origem (Dijkstra) para um
    //grafo representado usando matriz de adjacências. 
    public void dijkstra(int[, ] graph, int src)
    {
        Console.ResetColor();
        //Array que manterá a distância mais curta
        //da origem até os outros vértices
        int[] dist = new int[V];

        //sptSet[i] será verdadeiro se o vértice "i" está
        //incluído na árvore de caminho mais curto ou se o 
        //caminho mais curto da origem até "i" estiver finalizado
        bool[] sptSet = new bool[V];

        //Inicializa todas as distâncias como INFINITO
        //e stpSet[] como falso
        for (int i = 0; i < V; i++) {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        //Distância do vértice de origem
        //para ele mesmo é sempre 0
        dist[src] = 0; 

        //Encontra o caminho mais curto para todos os vértices
        for (int count = 0; count < V - 1; count++) {
            //Escolha o vértice de distância mínima
            //do conjunto de vértices ainda não
            //processado. u é sempre igual a
            //src na primeira iteração.
            int u = minDistance(dist, sptSet);

            //Marque o vértice escolhido como processado
            sptSet[u] = true;
            Console.WriteLine($"{rotuloVertices[u]} é marcado como processado.");

            // Atualize o valor dist dos vértices adjacentes do vértice escolhido.
            for (int v = 0; v < V; v++) {
                //Atualize dist[v] somente se não está em sptSet, há
                //uma aresta de u para v, e peso total do caminho de
                //origem até v através de u é menor que o valor atual de dist[v]
                if (!sptSet[v] 
                    && graph[u, v] != 0 
                    && dist[u] != int.MaxValue 
                    && dist[u] + graph[u, v] < dist[v]) {
                dist[v] = dist[u] + graph[u, v];
                Console.WriteLine($"{rotuloVertices[v]} tem distância {dist[v]}");
                }
            }
        }

        //Mostre o array de distâncias construído
        printSolution(dist, V);
    }
}