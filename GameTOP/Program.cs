﻿using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(
                new Jogador3(),
                new Jogador2()
            );
            jogo.IniciarJogo();
        }
    }
}
