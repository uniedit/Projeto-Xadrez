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

                    try {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    } catch (TabuleiroException err) {
                        Console.WriteLine();
                        Console.Write($"ERRO: {err.Message} ");
                        Console.ReadLine();
                    }
                }

                Console.Clear();
                Tela.ImprimirPartida(partida);

            } catch (TabuleiroException err) {
                Console.WriteLine();
                Console.Write($"ERRO: {err.Message} ");
                Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}
