using Projeto_Tabuleiro;

namespace Projeto_Xadrez {
    class Cavalo : Peca {

        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "C";
        }

        private bool PodeMover(Posicao pos) {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(pos.Linha - 2, pos.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(pos.Linha - 2, pos.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(pos.Linha - 1, pos.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(pos.Linha + 1, pos.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(pos.Linha + 2, pos.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(pos.Linha + 2, pos.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(pos.Linha + 1, pos.Coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }

    }
}
