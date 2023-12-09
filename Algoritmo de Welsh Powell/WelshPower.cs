using System;
using System.Collections.Generic;

class Grafo
{
    private int numVertices;
    private List<int>[] adjacencias;

    public Grafo(int v)
    {
        numVertices = v;
        adjacencias = new List<int>[v];
        for (int i = 0; i < v; ++i)
        {
            adjacencias[i] = new List<int>();
        }
    }

    public void adcAresta(int v, int w)
    {
        adjacencias[v].Add(w);
        adjacencias[w].Add(v);
    }

    public void ColorirGrafo()
    {
        int[] cores = new int[numVertices];
        bool[] disponivel = new bool[numVertices];

        for (int i = 0; i < numVertices; i++)
        {
            cores[i] = -1;
            disponivel[i] = true;
        }

        cores[0] = 0;

        for (int u = 1; u < numVertices; u++)
        {
            Console.WriteLine($"Verificando vértice {u}");

            foreach (var v in adjacencias[u])
            {
                if (cores[v] != -1)
                {
                    disponivel[cores[v]] = false;
                }
            }

            int cor;
            for (cor = 0; cor < numVertices; cor++)
            {
                if (disponivel[cor])
                {
                    break;
                }
            }

            cores[u] = cor;

            for (int i = 0; i < numVertices; i++)
            {
                disponivel[i] = true;
            }

            Console.WriteLine($"Atribuindo cor {cor} ao vértice {u}");
        }

        Console.WriteLine("\nAtribuição final de cores dos vértices:");
        for (int i = 0; i < numVertices; i++)
        {
            Console.WriteLine($"Vértice {i}: Cor {cores[i]}");
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
  
    static void Main()
    {
        Grafo graf = new Grafo(10);
         preencherEsparso(graf);
        graf.ColorirGrafo();
      
    }
}
