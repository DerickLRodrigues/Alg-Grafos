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

    public void BEL(Grafo graf, int raiz)
    {
        visitado = new bool[graf.V];
        pai = new int[graf.V];

        Queue<int> fila = new Queue<int>();
        visitado[raiz] = true;
        fila.Enqueue(raiz);

        while (fila.Count != 0)
        {
            int vertice = fila.Dequeue();
            Console.Write(vertice + " ");

            foreach (int vizinho in graf.adj[vertice])
            {
                if (!visitado[vizinho])
                {
                    visitado[vizinho] = true;
                    pai[vizinho] = vertice;
                    fila.Enqueue(vizinho);
                }
            }
        }
    }
}


class Program {
  public static void Main (string[] args) {
    Grafo graf = new Grafo(5); //qtd vertice
    graf.adcAresta(0, 1);
    graf.adcAresta(0, 2);
    graf.adcAresta(1, 2);
    graf.adcAresta(1, 3);
    graf.adcAresta(2, 3);
    graf.adcAresta(2, 4);
    graf.adcAresta(3, 4);
    graf.adcAresta(4,1);
    graf.adcAresta(4, 2);


    PriPesquisa bfs = new PriPesquisa();
    Console.WriteLine("BEL resultado:");
    bfs.BEL(graf, 2);   // numero de raiz de inicio
  }
}