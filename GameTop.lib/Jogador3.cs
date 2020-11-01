using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Pelé esta chutando";
        }

        public string Corre()
        {
            return "Pelé esta correndo";
        }

        public string Passa()
        {
            return "Pelé esta passando";
        }
    }
}