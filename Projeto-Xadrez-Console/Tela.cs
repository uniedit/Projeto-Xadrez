using System;
using Projeto_Xadrez;
using Projeto_Tabuleiro;
using System.Collections.Generic;

namespace Projeto_Xadrez_Console {
    class Tela {

        public static void ImprimirPartida(PartidaDeXadrez partida) {
            ImprimirTabuleiro(partida.Tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine($"Turno: {partida.Turno}");
            Console.WriteLine($"Aguardando jogada: {partida.JogadorAtual}");
            if (partida.Xeque) {
                Console.WriteLine("Xeque!");
            }
        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partida) {
            Console.WriteLine("Peças capturadas:");
            Console.Write("Brancas: ");
            ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");

            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto) {
            Console.Write("[");
            foreach (Peca x in conjunto) {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab) {
            Console.WriteLine("    A B C D E F G H");
            CorConsole("   -----------------");
            Console.WriteLine();

            for (int l = 0; l < tab.Linhas; l++) {
                Console.Write(8 - l);
                CorConsole(" | ");
                for (int c = 0; c < tab.Colunas; c++) {
                    ImprimirPeca(tab.Peca(l, c), c);
                }

                // De algum modo fazer essa verificação faz funcionar. Não sei o motivo.
                if (tab.Peca(l, 7) != null) {
                    CorConsole("| ");
                } else {
                    CorConsole(" | ");
                }

                Console.Write(8 - l);
                Console.WriteLine();
            }
            CorConsole("   -----------------");
            Console.WriteLine("");
            Console.WriteLine("    A B C D E F G H");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) {
            Console.WriteLine("    A B C D E F G H");
            CorConsole("   -----------------");
            Console.WriteLine();

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;


            for (int l = 0; l < tab.Linhas; l++) {
                Console.Write(8 - l);
                CorConsole(" | ");
                for (int c = 0; c < tab.Colunas; c++) {
                    if (posicoesPossiveis[l, c] == true) {
                        Console.BackgroundColor = fundoAlterado;
                    } else {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.Peca(l, c), c);
                    Console.BackgroundColor = fundoOriginal;
                }

                // De algum modo fazer essa verificação faz funcionar. Não sei o motivo.
                if (tab.Peca(l, 7) != null) {
                    CorConsole("| ");
                } else {
                    CorConsole(" | ");
                }

                Console.Write(8 - l);
                Console.WriteLine();
            }
            CorConsole("   -----------------");
            Console.WriteLine("");
            Console.WriteLine("    A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca, int c) {

            if (peca == null) {
                if (c == 7) {
                    Console.Write("-");
                } else {
                    Console.Write("-");
                    Console.Write(" ");
                }
            } else {
                if (peca.Cor == Cor.Branca) {
                    Console.Write(peca + " ");
                } else {
                    CorConsole($"{peca} ");
                }
            }
        }

        private static ConsoleColor Aux;

        public static void CorConsole(string message) {
            Aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ForegroundColor = Aux;
        }

    }
}
