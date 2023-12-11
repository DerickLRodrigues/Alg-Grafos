int [,] GrafoEsparso = Grafos.GrafoEsparso();
int [,] GrafoDenso = Grafos.GrafoDenso();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("########## DIJKSTRA ##########");
Dijkstra G = new Dijkstra();
G.dijkstra(GrafoEsparso, 0);