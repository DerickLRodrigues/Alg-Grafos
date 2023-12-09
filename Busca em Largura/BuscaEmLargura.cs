using System;
using System.Collections.Generic;

class Grafo
{
    public int V; // numero de vertices
    public List<int>[] adj; // listas de adjacencias

    public Grafo(int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; ++i)
            adj[i] = new List<int>();
    }

    public void adcAresta(int v, int w)
    {
        adj[v].Add(w);
    }
}

class PriPesquisa
{
    private bool[] visitado;
    private int[] pai;
    private List<int> ordemFinal;

    public PriPesquisa()
    {
        ordemFinal = new List<int>();
    }

    public void BEL(Grafo graf, int raiz)
    {
        visitado = new bool[graf.V];
        pai = new int[graf.V];

        Queue<int> fila = new Queue<int>();
        visitado[raiz] = true;
        fila.Enqueue(raiz);

        Console.WriteLine("Iniciando busca em largura (BEL) a partir do vértice " + raiz);

        while (fila.Count != 0)
        {
            int vertice = fila.Dequeue();
            Console.Write("Visitando vértice: " + vertice + " ");

            foreach (int vizinho in graf.adj[vertice])
            {
                if (!visitado[vizinho])
                {
                    visitado[vizinho] = true;
                    pai[vizinho] = vertice;
                    fila.Enqueue(vizinho);
                    Console.WriteLine("Enfileirando vértice " + vizinho + " (pai: " + vertice + ")");
                }
            }

            ordemFinal.Add(vertice);
        }

        Console.WriteLine("\nOrdem final da busca em largura:");
        foreach (var vertice in ordemFinal)
        {
            Console.Write(vertice + " ");
        }
    }
}

class Program {

    public static void preencherEsparso(Grafo graf)
    {
        graf.adcAresta(0, 1);
        graf.adcAresta(0, 4);
        graf.adcAresta(0, 9);
        graf.adcAresta(0, 8);
        graf.adcAresta(1, 9);
        graf.adcAresta(1, 4);
        graf.adcAresta(2, 7);
        graf.adcAresta(2, 5);
        graf.adcAresta(2, 8);
        graf.adcAresta(2, 3);
        graf.adcAresta(3, 2);
        graf.adcAresta(3, 8);
        graf.adcAresta(3, 4);
        graf.adcAresta(4, 8);
        graf.adcAresta(4, 9);
        graf.adcAresta(5, 8);
        graf.adcAresta(5, 7);
        graf.adcAresta(5, 6);
        graf.adcAresta(5, 2);
        graf.adcAresta(6, 5);
        graf.adcAresta(7, 2);
        graf.adcAresta(7, 5);
        graf.adcAresta(7, 8);
        graf.adcAresta(8, 0);
        graf.adcAresta(8, 2);
        graf.adcAresta(8, 3);
        graf.adcAresta(8, 4);
        graf.adcAresta(8, 5);
        graf.adcAresta(9, 0);
        graf.adcAresta(9, 1);
        graf.adcAresta(9, 4);
    }


    public static void preencherDenso(Grafo graf)
    {
        graf.adcAresta(0, 1);
        graf.adcAresta(1, 0);

        graf.adcAresta(0, 2);
        graf.adcAresta(2, 0);

        graf.adcAresta(0, 3);
        graf.adcAresta(3, 0);

        graf.adcAresta(0, 4);
        graf.adcAresta(4, 0);

        graf.adcAresta(0, 5);
        graf.adcAresta(5, 0);

        graf.adcAresta(0, 6);
        graf.adcAresta(6, 0);

        graf.adcAresta(0, 7);
        graf.adcAresta(7, 0);

        graf.adcAresta(0, 8);
        graf.adcAresta(8, 0);

        graf.adcAresta(0, 9);
        graf.adcAresta(9, 0);

        graf.adcAresta(1, 2);
        graf.adcAresta(2, 1);

        graf.adcAresta(1, 3);
        graf.adcAresta(3, 1);

        graf.adcAresta(1, 4);
        graf.adcAresta(4, 1);

        graf.adcAresta(1, 5);
        graf.adcAresta(5, 1);

        graf.adcAresta(1, 6);
        graf.adcAresta(6, 1);

        graf.adcAresta(1, 7);
        graf.adcAresta(7, 1);

        graf.adcAresta(1, 8);
        graf.adcAresta(8, 1);

        graf.adcAresta(1, 9);
        graf.adcAresta(9, 1);

        graf.adcAresta(2, 5);
        graf.adcAresta(5, 2);

        graf.adcAresta(2, 6);
        graf.adcAresta(6, 2);

        graf.adcAresta(2, 8);
        graf.adcAresta(8, 2);

        graf.adcAresta(2, 9);
        graf.adcAresta(9, 2);

        graf.adcAresta(2, 4);
        graf.adcAresta(4, 2);

        graf.adcAresta(2, 3);
        graf.adcAresta(3, 2);

        graf.adcAresta(3, 5);
        graf.adcAresta(5, 3);

        graf.adcAresta(3, 6);
        graf.adcAresta(6, 3);

        graf.adcAresta(3, 7);
        graf.adcAresta(7, 3);

        graf.adcAresta(3, 8);
        graf.adcAresta(8, 3);

        graf.adcAresta(3, 9);
        graf.adcAresta(9, 3);

        graf.adcAresta(3, 4);
        graf.adcAresta(4, 3);

        graf.adcAresta(4, 5);
        graf.adcAresta(5, 4);

        graf.adcAresta(4, 6);
        graf.adcAresta(6, 4);

        graf.adcAresta(4, 7);
        graf.adcAresta(7, 4);

        graf.adcAresta(4, 8);
        graf.adcAresta(8, 4);

        graf.adcAresta(4, 9);
        graf.adcAresta(9, 4);

        graf.adcAresta(5, 9);
        graf.adcAresta(9, 5);

        graf.adcAresta(5, 6);
        graf.adcAresta(6, 5);

        graf.adcAresta(6, 9);
        graf.adcAresta(9, 6);

        graf.adcAresta(6, 7);
        graf.adcAresta(7, 6);

        graf.adcAresta(7, 8);
        graf.adcAresta(8, 7);

        graf.adcAresta(8, 9);
        graf.adcAresta(9, 8);
    }

    public static void Main (string[] args) {
    Grafo graf = new Grafo(10); //qtd vertice
    preencherEsparso(graf);

    PriPesquisa bfs = new PriPesquisa();
    Console.WriteLine("BEL resultado:");
    bfs.BEL(graf, 0);   // numero de raiz de inicio
  }
}
