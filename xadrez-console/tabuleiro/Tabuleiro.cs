
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        //MATRIZ de peças.
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //Metodo pra acessar a MATRIZ
        public Peca peca(int linha, int coluna)
        {
            Posicao pos = new Posicao(linha, coluna);
            validarPosicao(pos);
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            validarPosicao(pos);
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            //teste exception. Se for invalido vai cortar o método.
            validarPosicao(pos);
            return peca(pos) != null;
        }
                
        public void colocarPeca(Peca p, Posicao pos)
        {
            //test exception. duas peças não podem ocupar o mesmo local.
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe peça nessa Posição!");
            }

            //colocar a peça no tabuleiro com as corredenadas passadas no obj Posição.
            pecas[pos.linha, pos.coluna] = p;

            //Dizer à peça qual é a sua posição.
            p.posicao = pos;
        }

        //tabuleiro tem limite
        #region limite Tabuleiro
        public bool posicaoValida(Posicao pos)
        {
            // '<='  o numero passado para criar a matriz tabuleiro é inteiro e a posição do n° inteiro passado é a primeira q não existe. ex: 8 linhas, poisções de 0 a 7.
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna<0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
        #endregion


    }
}
