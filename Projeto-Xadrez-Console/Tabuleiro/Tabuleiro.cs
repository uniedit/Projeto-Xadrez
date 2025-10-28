namespace Projeto_Tabuleiro {
    class Tabuleiro {

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.Linhas = linhas;
            this.Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }

        // Método que permite outras classes acessares a var _pecas, retornando as linhas e as colunas
        public Peca Peca(int linhas, int colunas) {
            return _pecas[linhas, colunas];
        }

        // Jogando a posição "p" na matriz Peca
        public void ColocarPeca(Peca p, Posicao pos) {
            // Modificando a var "_pecas" recebendo os argumentos da classe Posição
            _pecas[pos.Linha, pos.Coluna] = p;

            // Classe recebendo o argumento que o método "ColocarPeca" vai receber como "pos"
            p.Posicao = pos;
        }

    }
}
