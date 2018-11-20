import networkx as nx
from networkx.algorithms.flow import edmonds_karp

def func(G, v1, v2, capacidade):
    G.add_edge(v1, v2, capacity=capacidade)
    return G

arq = open("C:/Users/Familia Paiva/Desktop/teste.txt", "r")
texto = arq.readlines()

k = 0
G = nx.DiGraph()
for line in texto:
    if(k != 0):
        linha = line.split(" ")
        G = func(G, linha[0], linha[1], int(linha[2]))
    k = k + 1
        
fluxo_max = nx.maximum_flow_value(G, 'A', 'Z', flow_func = edmonds_karp)
print(fluxo_max)
arq.close()