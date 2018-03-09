using System;
using System.Threading;
class ThreadIdentidade
{
    /*
     * O programa executa e imprime as frases com o id de cada thread 
     * fica claro que elas são invocadas fora da ordem 
     * se a intenção fosse executar alguma coisa de forma ordenada, esse não seria um bom recurso
     * O melhor é aplicar só para o que não importar a ordem de execução.
    */
    private int id = 0;
    public ThreadIdentidade(int id)
    {
        this.id = id;
    }
    public void ApresentarThread()
    {
        Console.WriteLine("Olá mundo, eu sou o thread " + id);
    }
}
class Program
{
    static void Main()
    {
        int numThreads = 20;
        Thread[] pool = new Thread[numThreads];
        for (int i = 0; i < numThreads; i++)
        {
            ThreadIdentidade b = new ThreadIdentidade(i);
            pool[i] = new Thread(b.ApresentarThread);
        }
        for (int i = 0; i < numThreads; i++)
            pool[i].Start();

        Console.ReadKey();
    }
}