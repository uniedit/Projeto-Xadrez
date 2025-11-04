using Projeto_Tabuleiro.Exceptions;

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

        // Não entendi a sobrecarga
        public Peca Peca(Posicao pos) {
            return _pecas[pos.Linha, pos.Coluna];
        }

        // Metodo que verifica determina posição usando o metodo "ValidarPosicao" para lançar uma excessão caso seja falso
        public bool ExistePeca(Posicao pos) {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        // Jogando a posição "p" na matriz Peca
        public void ColocarPeca(Peca p, Posicao pos) {
            if (ExistePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição!!");
            }
            // Modificando a var "_pecas" recebendo os argumentos da classe Posição
            _pecas[pos.Linha, pos.Coluna] = p;

            // Classe recebendo o argumento que o método "ColocarPeca" vai receber como "pos"
            p.Posicao = pos;
        }

        // Método para remover a peça na posição informada
        public Peca RetirarPeca(Posicao pos) {
            // Caso seja null, só retorna null
            if(Peca(pos) == null) {
                return null;
            }
            // Caso passe, ele remove na pos.linha e pos.coluna
            Peca aux = Peca(pos);
            _pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        // Verificação de posição caso saia do numero de linhas ou colunas do Tabuleiro
        public bool PosicaoValida(Posicao pos) {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas) {
                return false;
            } 
            return true;
        }

        // Exception personalizada para detectar posições invalidas
        public void ValidarPosicao(Posicao pos) {
            if (!PosicaoValida(pos)) {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    
    }
}
