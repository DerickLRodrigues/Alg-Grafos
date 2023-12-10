using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkerson
{

    class Grafo
    {
        private int V; // Número de vértices
        private int[,] grafo; // Matriz de adjacência com capacidades

        public Grafo(int v)
        {
            V = v;
            grafo = new int[V, V];
        }

        public void adcAresta(int u, int v, int capd)
        {
            grafo[u, v] = capd;
        }


        public bool BEP(int s, int t, int[] pai)
        {
            bool[] visitado = new bool[V];
            Queue<int> queue = new Queue<int>();

            visitado[s] = true;
            queue.Enqueue(s);

            while (queue.Count > 0)
            {
                int u = queue.Dequeue();

                for (int v = 0; v < V; v++)
                {
                    if (!visitado[v] && grafo[u, v] > 0)
                    {
                        pai[v] = u;
                        visitado[v] = true;
                        queue.Enqueue(v);
                    }
                }
            }

            return visitado[t];
        }

        // Executa o algoritmo Ford-Fulkerson e exibe informações intermediárias
        public int FFA(int fonte, int final)
        {
            int[] pai = new int[V];
            int maxFlow = 0;

            while (BEP(fonte, final, pai))
            {
                int PF = int.MaxValue;

                for (int v = final; v != fonte; v = pai[v])
                {
                    int u = pai[v];
                    PF = Math.Min(PF, grafo[u, v]);
                }

                for (int v = final; v != fonte; v = pai[v])
                {
                    int u = pai[v];
                    grafo[u, v] -= PF;
                    grafo[v, u] += PF;
                }

                Console.Write("Arestas escolhidas: ");
                for (int v = final; v != fonte; v = pai[v])
                {
                    int u = pai[v];
                    Console.Write($"({u} -> {v}) ");
                }

                maxFlow += PF;


                Console.WriteLine($"Caminho encontrado. Fluxo máximo atual: {maxFlow}");
            }

            return maxFlow;
        }
    }

    class Program
    {
        static void preencherEsparso(Grafo graf)
        {

            graf.adcAresta(0, 1, 5);
            graf.adcAresta(0, 2, 4);
            graf.adcAresta(0, 3, 7);
            graf.adcAresta(1, 5, 1);
            graf.adcAresta(1, 4, 2);
            graf.adcAresta(2, 6, 4);
            graf.adcAresta(2, 4, 4);
            graf.adcAresta(3, 6, 2);
            graf.adcAresta(3, 5, 3);
            graf.adcAresta(3, 2, 4);
            graf.adcAresta(4, 7, 2);
            graf.adcAresta(4, 8, 3);
            graf.adcAresta(5, 9, 5);
            graf.adcAresta(5, 7, 2);
            graf.adcAresta(5, 8, 4);
            graf.adcAresta(6, 7, 3);
            graf.adcAresta(6, 8, 2);
            graf.adcAresta(7, 9, 1);
            graf.adcAresta(8, 9, 7);


        }

        static void preencherDenso(Grafo graf)
        {

            graf.adcAresta(0, 1, 5);
            graf.adcAresta(0, 2, 4);
            graf.adcAresta(0, 3, 7);
            graf.adcAresta(1, 5, 1);
            graf.adcAresta(1, 4, 2);
            graf.adcAresta(2, 6, 4);
            graf.adcAresta(2, 4, 4);
            graf.adcAresta(3, 6, 2);
            graf.adcAresta(3, 5, 3);
            graf.adcAresta(3, 2, 4);
            graf.adcAresta(4, 7, 2);
            graf.adcAresta(4, 8, 3);
            graf.adcAresta(5, 9, 5);
            graf.adcAresta(5, 7, 2);
            graf.adcAresta(5, 8, 4);
            graf.adcAresta(6, 7, 3);
            graf.adcAresta(6, 8, 2);
            graf.adcAresta(7, 9, 1);
            graf.adcAresta(8, 9, 7);
            graf.adcAresta(1, 6, 2);
            graf.adcAresta(1, 7, 1);
            graf.adcAresta(1, 9, 1);
            graf.adcAresta(1, 2, 2);
            graf.adcAresta(1, 5, 1);
            graf.adcAresta(1, 4, 2);
            graf.adcAresta(2, 5, 2);
            graf.adcAresta(2, 7, 2);
            graf.adcAresta(2, 8, 2);
            graf.adcAresta(2, 3, 1);
            graf.adcAresta(3, 8, 2);
            graf.adcAresta(3, 4, 2);
            graf.adcAresta(4, 6, 2);
            graf.adcAresta(6, 5, 2);
            graf.adcAresta(7, 8, 2);
            graf.adcAresta(4, 9, 2);



        }

        public static void Main(string[] args)
        {
            Grafo graf = new Grafo(10);

            preencherDenso(graf);

            int fonte = 0;
            int final = 9;

            int maxFlow = graf.FFA(fonte, final);

            Console.WriteLine($"Fluxo máximo da fonte {fonte} para o final {final}: {maxFlow}");
            Console.ReadLine();
        }
    }
}
