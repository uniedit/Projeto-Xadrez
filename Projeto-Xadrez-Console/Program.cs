using System;
using Projeto_Xadrez;
using Projeto_Tabuleiro;
using Projeto_Tabuleiro.Exceptions;

namespace Projeto_Xadrez_Console {
    internal class Program {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());

        }
    }
}
