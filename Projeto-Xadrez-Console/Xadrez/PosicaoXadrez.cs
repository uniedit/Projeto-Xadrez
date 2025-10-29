using Projeto_Tabuleiro;

namespace Projeto_Xadrez {
    class PosicaoXadrez {

        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            this.Coluna = coluna;
            this.Linha = linha;
        }

        public Posicao ToPosicao() {
            // Internamente 'a' é um numero inteiro, assim faz o calculo continuo com o resto do alfabeto
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString() {
            return $"{Coluna}{Linha}";
        }

    }
}
