using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }
        //Chuta
        public string Chuta()
        {
            return $"{_Nome} está chutando";
        }
        //Corre
        public string Corre()
        {
            return $"{_Nome} está Correndo";
        }

        //Passe
        public string Passa()
        {
            return $"{_Nome} está passando";
        }
    }
}