int [,] GrafoEsparsoComArestaNegativa = Grafos.GrafoEsparsoComArestaNegativa();
int [,] GrafoEsparsoComCicloNegativo = Grafos.GrafoEsparsoComCicloNegativo();
int [,] GrafoDensoComArestaNegativa = Grafos.GrafoDensoComArestaNegativa();
int [,] GrafoDensoComCicloNegativo = Grafos.GrafoDensoComCicloNegativo();
var V = 10;

Console.WriteLine("\n########## BELLMAN-FORD ##########");
BellmanFord H = new BellmanFord();
H.bellmanFord(GrafoDensoComCicloNegativo, V, 0);