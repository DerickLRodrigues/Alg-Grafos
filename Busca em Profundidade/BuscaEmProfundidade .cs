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
    private List<int> ordemFinal;

    public PriPesquisa()
    {
        ordemFinal = new List<int>();
    }

    public void BEP(Grafo graf, int verticeInicio)
    {
        visitado = new bool[graf.V];
        Console.WriteLine("Iniciando busca em profundidade (BEP) a partir do vértice " + verticeInicio);
        BEPU(graf, verticeInicio);

        Console.WriteLine("\nOrdem final da busca em profundidade:");
        foreach (var vertice in ordemFinal)
        {
            Console.Write(vertice + " ");
        }
    }

    private void BEPU(Grafo graf, int vertice)
    {
        visitado[vertice] = true;
        Console.Write("Visitando vértice: " + vertice + " ");
        ordemFinal.Add(vertice);

        foreach (int vizinho in graf.adj[vertice])
        {
            if (!visitado[vizinho])
            {
                Console.WriteLine("Explorando vizinho " + vizinho + " do vértice " + vertice);
                BEPU(graf, vizinho);
            }
        }
    }
}

class Program
{

  public static void preencherEsparso(Grafo graf){
    graf.adcAresta(0, 1);
    graf.adcAresta(0, 4);
    graf.adcAresta(0, 9);
    graf.adcAresta(0, 8);
    graf.adcAresta(0, 7);
    graf.adcAresta(1, 4);
    graf.adcAresta(1, 9);
    graf.adcAresta(2, 5);
    graf.adcAresta(2, 7);
    graf.adcAresta(2, 8);
    graf.adcAresta(2, 3);
    graf.adcAresta(3, 8);
    graf.adcAresta(3, 4);
    graf.adcAresta(4, 8);
    graf.adcAresta(4, 9);
    graf.adcAresta(9, 5);
    graf.adcAresta(5, 8);
    graf.adcAresta(5, 6);
    graf.adcAresta(5, 7);
    graf.adcAresta(7, 8); 
  }

  public static void preencherDenso(Grafo graf){
    graf.adcAresta(0, 1);
    graf.adcAresta(0, 2);
    graf.adcAresta(0, 3);
    graf.adcAresta(0, 4);
    graf.adcAresta(0, 5);
    graf.adcAresta(0, 6);
    graf.adcAresta(0, 7);
    graf.adcAresta(0, 8);
    graf.adcAresta(0, 9);
    graf.adcAresta(1, 2);
    graf.adcAresta(1, 3);
    graf.adcAresta(1, 4);
    graf.adcAresta(1, 5);
    graf.adcAresta(1, 6);
    graf.adcAresta(1, 7);
    graf.adcAresta(1, 8);
    graf.adcAresta(1, 9);
    graf.adcAresta(2, 5);
    graf.adcAresta(2, 6);
    graf.adcAresta(2, 8); 
    graf.adcAresta(2, 9);
    graf.adcAresta(2, 4);
    graf.adcAresta(2, 3); //23

    graf.adcAresta(3, 5);
    graf.adcAresta(3, 6);
    graf.adcAresta(3, 7); 
    graf.adcAresta(3, 8);
    graf.adcAresta(3, 9);
    graf.adcAresta(3, 4);//29

    graf.adcAresta(4, 5);
    graf.adcAresta(4, 6);
    graf.adcAresta(4, 7); 
    graf.adcAresta(4, 8);
    graf.adcAresta(4, 9);//34

    graf.adcAresta(5, 9);
    graf.adcAresta(5, 6);//36

    graf.adcAresta(6, 9);
    graf.adcAresta(6, 7);
    graf.adcAresta(7, 8);
    graf.adcAresta(8, 9);

  }
  
    public static void Main(string[] args)
    {
        Grafo graf = new Grafo(10); //qtd vertice
      graf.adcAresta(0, 1);
      graf.adcAresta(0, 2);
      graf.adcAresta(1, 3);
      graf.adcAresta(2, 4);
      graf.adcAresta(3, 4);
      graf.adcAresta(3, 5);

        PriPesquisa bep = new PriPesquisa();
        Console.WriteLine("BEP resultado:");
        bep.BEP(graf, 0); // número do vértice inicial
    }
}
