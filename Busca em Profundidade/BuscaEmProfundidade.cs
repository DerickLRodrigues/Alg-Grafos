using System;
using System.Collections.Generic;

class Grafo
{
    private int vertices;              // Numero de vertice
    private List<int>[] adjList; // Lista de adjancoias

    public Grafo(int v)
    {
        vertices = v;
        adjList = new List<int>[v];
        for (int i = 0; i < v; i++)
            adjList[i] = new List<int>();
    }

    public void adcAresta(int v, int w)
    {
        adjList[v].Add(w);
    }

    private void BEPU(int v, bool[] visitados)
    {
        visitados[v] = true;
        Console.Write(v + " ");

        foreach (int vizinho in adjList[v])
        {
            if (!visitados[vizinho])
                BEPU(vizinho, visitados);
        }
    }

    public void BEP(int VerticeInicio)
    {
        bool[] visitados = new bool[vertices];
        BEPU(VerticeInicio, visitados);
    }
}

class Program
{
    static void Main()
    {
        Grafo graf = new Grafo(6); //qtd vert
        graf.adcAresta(0, 1);
        graf.adcAresta(0, 2);
        graf.adcAresta(1, 3);
        graf.adcAresta(2, 4);
        graf.adcAresta(3, 4);
        graf.adcAresta(3, 5);

        Console.WriteLine("Busca em profundidade:");
        graf.BEP(0); //vertice inicial 
    }
}