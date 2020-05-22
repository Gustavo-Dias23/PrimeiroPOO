namespace PrimeiroPOO
{
    public class Personagem
    {
        public string nome = "Batman";
        public int idade = 32; 
        public string armadura;

        public int Atacar(int forca , int potencia)
        {
            return forca * potencia;
        }
    }
}