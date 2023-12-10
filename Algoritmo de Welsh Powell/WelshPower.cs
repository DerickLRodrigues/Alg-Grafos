using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelshPower
{

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

        public void adc(int v, int w)
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

        public static void preencherEsparso(Grafo graf)
        {
            graf.adc(0, 1);
            graf.adc(0, 4);
            graf.adc(0, 9);
            graf.adc(0, 8);
            graf.adc(0, 7);
            graf.adc(1, 4);
            graf.adc(1, 9);
            graf.adc(2, 5);
            graf.adc(2, 7);
            graf.adc(2, 8);
            graf.adc(2, 3);
            graf.adc(3, 8);
            graf.adc(3, 4);
            graf.adc(4, 8);
            graf.adc(4, 9);
            graf.adc(9, 5);
            graf.adc(5, 8);
            graf.adc(5, 6);
            graf.adc(5, 7);
            graf.adc(7, 8);
        }

        public static void preencherDenso(Grafo graf)
        {
            graf.adc(0, 1);
            graf.adc(0, 2);
            graf.adc(0, 3);
            graf.adc(0, 4);
            graf.adc(0, 5);
            graf.adc(0, 6);
            graf.adc(0, 7);
            graf.adc(0, 8);
            graf.adc(0, 9);
            graf.adc(1, 2);
            graf.adc(1, 3);
            graf.adc(1, 4);
            graf.adc(1, 5);
            graf.adc(1, 6);
            graf.adc(1, 7);
            graf.adc(1, 8);
            graf.adc(1, 9);
            graf.adc(2, 5);
            graf.adc(2, 6);
            graf.adc(2, 8);
            graf.adc(2, 9);
            graf.adc(2, 4);
            graf.adc(2, 3); //23

            graf.adc(3, 5);
            graf.adc(3, 6);
            graf.adc(3, 7);
            graf.adc(3, 8);
            graf.adc(3, 9);
            graf.adc(3, 4);//29

            graf.adc(4, 5);
            graf.adc(4, 6);
            graf.adc(4, 7);
            graf.adc(4, 8);
            graf.adc(4, 9);//34

            graf.adc(5, 9);
            graf.adc(5, 6);//36

            graf.adc(6, 9);
            graf.adc(6, 7);
            graf.adc(7, 8);
            graf.adc(8, 9);

        }

        static void Main(string[] args)
        {

            Grafo graf = new Grafo(10);
            preencherDenso(graf);
            graf.ColorirGrafo();
            Console.ReadLine();

        }
    }
}
