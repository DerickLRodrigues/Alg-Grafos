// using System;
// using System.Collections.Generic;

// class FlorestaCaminhos
// {
//     private const int INF = int.MaxValue;

//     public static void menorCaminho(int[,] grafo, int inicio)
//     {
//         int n = grafo.GetLength(0);
//         List<List<int>> floresta = new List<List<int>>();

//         for (int i = 0; i < n; i++)
//         {
//             floresta.Add(new List<int>());
//         }
//         for (int i = 0; i < n; i++)
//         {
//             if (i != inicio)
//             {
//                 List<int> caminho = Dijkstra(grafo, inicio, i);
//                 floresta[i] = caminho;
//             }
//         }
//         Console
//             .WriteLine("Floresta de Caminhos Ótimos a partir do vértice " +
//             inicio +
//             ":");

//         for (int i = 0; i < n; i++)
//         {
//             if (i != inicio)
//             {
//                 Console.Write($"Caminho até o vértice {i}: ");
//                 if (floresta[i].Count == 0)
//                 {
//                     Console.WriteLine("Não alcançável.");
//                 }
//                 else
//                 {
//                     foreach (var vertice in floresta[i])
//                     {
//                         Console.Write(vertice + " ");
//                     }
//                     Console.WriteLine();
//                 }
//             }
//         }
//     }

//     private static List<int> Dijkstra(int[,] grafo, int inicio, int destino)
//     {
//         int n = grafo.GetLength(0);
//         int[] tam = new int[n];
//         bool[] verificado = new bool[n];
//         int[] parent = new int[n];
//         List<int> caminho = new List<int>();

//         for (int i = 0; i < n; i++)
//         {
//             tam[i] = INF;
//             verificado[i] = false;
//         }

//         tam[inicio] = 0;

//         for (int count = 0; count < n - 1; count++)
//         {
//             int u = menorVertice(tam, verificado);
//             verificado[u] = true;

//             for (int v = 0; v < n; v++)
//             {
//                 if (
//                     !verificado[v] &&
//                     grafo[u, v] != 0 &&
//                     tam[u] != INF &&
//                     tam[u] + grafo[u, v] < tam[v]
//                 )
//                 {
//                     tam[v] = tam[u] + grafo[u, v];
//                     parent[v] = u;
//                 }
//             }
//         }

//         int atual = destino;
//         while (atual != inicio)
//         {
//             caminho.Insert(0, atual);
//             atual = parent[atual];
//         }

//         caminho.Insert(0, inicio);

//         return caminho;
//     }

//     private static int menorVertice(int[] tam, bool[] verificado)
//     {
//         int minE = INF;
//         int refen = -1;

//         for (int v = 0; v < tam.Length; v++)
//         {
//             if (!verificado[v] && tam[v] <= minE)
//             {
//                 minE = tam[v];
//                 refen = v;
//             }
//         }

//         return refen;
//     }

//     static void Main()
//     {
//         int[,] grafoEsparso =
//         {
//             { 0, 11, 17, 29, 0, 0, 0, 0, 0, 0 },
//             { 0, 0, 18, 0, 18, 0, 0, 0, 0, 0 },
//             { 0, 0, 0, 14, 0, 0, 0, 0, 0, 0 },
//             { 0, 0, 0, 0, 0, 0, 16, 0, 0, 0 },
//             { 0, 0, 0, 0, 0, 0, 0, 21, 0, 0 },
//             { 0, 29, 23, 28, 15, 0, 0, 26, 12, 0 },
//             { 0, 0, 0, 0, 0, 12, 0, 0, 0, 21 },
//             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 19 },
//             { 0, 0, 0, 0, 0, 0, 17, 22, 0, 29 },
//             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
//         };

//         int verticeInicio = 0;

//         Console.WriteLine("Inicio grafo esparso:");
//         menorCaminho (grafoEsparso, verticeInicio);
//         Console.WriteLine("Fim grafo esparso:");

//         Console.WriteLine("");
//         Console.WriteLine("");
//         Console.WriteLine("");

//         int[,] grafoDenso =
//         {
//             { 0, 11, 0, 0, 0, 0, 15, 11, 0, 27 },
//             { 22, 0, 27, 0, 0, 0, 28, 0, 0, 30 },
//             { 0, 0, 0, 19, 0, 0, 0, 27, 0, 0 },
//             { 0, 0, 15, 0, 15, 24, 0, 26, 0, 0 },
//             { 0, 0, 0, 12, 0, 0, 0, 23, 12, 0 },
//             { 0, 19, 0, 0, 0, 0, 24, 29, 14, 27 },
//             { 14, 0, 26, 0, 12, 0, 0, 0, 30, 0 },
//             { 0, 0, 16, 0, 20, 0, 10, 0, 19, 25 },
//             { 0, 15, 0, 11, 0, 0, 30, 0, 0, 30 },
//             { 19, 15, 0, 26, 0, 0, 19, 0, 29, 0 }
//         };

//         verticeInicio = 0;

//         Console.WriteLine("Inicio grafo denso:");
//         menorCaminho (grafoDenso, verticeInicio);
//         Console.WriteLine("Fim grafo denso:");
//     }
// }
