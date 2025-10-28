﻿namespace Projeto_Tabuleiro {
    class Peca {

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

    }
}
