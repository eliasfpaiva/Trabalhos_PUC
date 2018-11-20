#De Gabriela Souza
import networkx as nx
arq = open("C:/Users/Familia Paiva/Desktop/teste4.txt", "r")
texto = arq.readlines()
k = 0
entr=int(texto[0][2])
G = nx.Graph()
for line in texto:
    if(k != 0):
        linha = line.split(" ")
        if(k<=entr):
            G.add_edge(linha[0], linha[1], weight=2**int(linha[2]))
        else:
            s=linha[0]
            t=linha[1]
    k = k + 1
caminho=nx.has_path(G, s, t)
if(caminho):
    ver=''
    resto= (int(nx.dijkstra_path_length(G, s, t)))% 1000000007
    vertices=nx.dijkstra_path(G,s,t)
    print(resto) 
    print(len(vertices))
    for vertice in vertices:
        ver+=(vertice)+' '
    print(ver)
else:
    print(-1)

arq.close()