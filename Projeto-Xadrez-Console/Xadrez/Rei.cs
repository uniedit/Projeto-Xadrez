using Projeto_Tabuleiro;

namespace Projeto_Xadrez {
    class Rei : Peca {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { 
        }

        public override string ToString() {
            return "R";
        }

    }
}
