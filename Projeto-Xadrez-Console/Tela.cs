using System;
using Projeto_Tabuleiro;

namespace Projeto_Xadrez_Console {
    class Tela {

        public static void ImprimirTabuleiro(Tabuleiro tab) {
            Console.WriteLine("    A B C D E F G H");
            CorConsole("   -----------------");
            Console.WriteLine();

            for (int l = 0; l < tab.Linhas; l++) {
                Console.Write(8 - l);
                CorConsole(" | ");
                for (int c = 0; c < tab.Colunas; c++) {
                    if (tab.Peca(l, c) == null) {
                        if (c == 7) {
                            Console.Write("-");
                        } else {
                            Console.Write("- ");
                        }
                    } else {
                        ImprimirPeca(tab.Peca(l, c));
                    }

                }
                CorConsole(" | ");
                Console.Write(8 - l);
                Console.WriteLine();
            }
            CorConsole("   -----------------");
            Console.WriteLine("");
            Console.WriteLine("    A B C D E F G H");
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca.Cor == Cor.Branca) {
                Console.Write(peca + " ");
            } else {
                CorConsole($"{peca} ");
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
