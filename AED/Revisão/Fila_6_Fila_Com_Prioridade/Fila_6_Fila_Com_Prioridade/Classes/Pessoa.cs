namespace Filas.Classes
{
    public class Pessoa
    {
        public int idade;

        public Pessoa(int idade) { this.idade = idade; }
        
        public override string ToString()
        {
            return "" + idade;
        }
    }
}