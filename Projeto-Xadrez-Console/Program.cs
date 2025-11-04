using System;
using Projeto_Xadrez;
using Projeto_Tabuleiro;
using Projeto_Tabuleiro.Exceptions;

namespace Projeto_Xadrez_Console {
    internal class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.ImprimirTabuleiro(partida.Tab);
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
