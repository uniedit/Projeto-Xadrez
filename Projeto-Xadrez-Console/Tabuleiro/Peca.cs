namespace Projeto_Tabuleiro {
    // Como tem pelo menos 1 método abstrato, logo a classe é abstrata
    abstract class Peca {

        public Posicao Posicao { get; set; }
        public Tabuleiro Tab { get; protected set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.Posicao = null;
            this.Tab = tab;
            this.Cor = cor;
            this.QteMovimentos = 0;
        }

        public void IncrementarQteMovimentos() {
            QteMovimentos++;
        }

        public bool ExisteMovimentosPossiveis() {
            bool[,] mat = MovimentosPossiveis();
            for (int c = 0; c < Tab.Linhas; c++) {
                for (int l = 0; l < Tab.Colunas; l++) {
                    if (mat[c,l]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos) {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        // Método abstrato devido a que qualquer peça tem movimentos possiveis diferentes um dos outros
        public abstract bool[,] MovimentosPossiveis();

    }
}
