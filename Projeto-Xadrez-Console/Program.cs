using System;
using Projeto.Tabuleiro;

namespace Projeto_Xadrez_Console {
    internal class Program {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.WriteLine("Linhas: " + tab.Linhas);
            Console.WriteLine("Colunas: " + tab.Colunas);

        }
    }
}
