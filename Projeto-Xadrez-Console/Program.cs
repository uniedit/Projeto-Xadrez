using System;
using Projeto_Xadrez;
using Projeto_Tabuleiro;
using Projeto_Tabuleiro.Exceptions;

namespace Projeto_Xadrez_Console {
    internal class Program {
        static void Main(string[] args) {

            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada) {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);

                }

                Tela.ImprimirTabuleiro(partida.Tab);
            } catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
