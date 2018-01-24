
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        //MATRIZ DE PEÇAS: armazena posições de peças ou vazias. INSERIR uma peça é passar sua posição.
        private Peca[,] pecas;

        //CONSTRUTOR
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        

        #region RETORNA PEÇA DA MATRIZ
        //RETORNA peça da matriz na posição [POS]

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
        #endregion


        //INSERIR peça no tabuleiro
        public void colocarPeca(Peca p, Posicao pos)
        {
            //1. VÊ SE A POSIÇÃO EXISTE E SE JÁ EXISTE PEÇA NO TABULEIRO NESSA POSIÇÃO; 2. MATRIZ INSERI PEÇA'P' ; 3. 'P' RECEBE POSIÇÃO. 
            //test exception. duas peças não podem ocupar o mesmo local.
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe peça nessa Posição!");
            }

            //INSERIR a peça 'p' no tabuleiro com as corredenadas passadas no obj Posição.
            pecas[pos.linha, pos.coluna] = p;

            //Dizer à peça 'p' qual é a sua posição.
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null) {
                return null;
            }

            //se existe peça, pega, passa pro 'aux'. ex: Rei, Torre...
            Peca aux = peca(pos);
            //zera peça e posição no tabuleiro.
            aux.posicao = null;            
            pecas[pos.linha, pos.coluna] = null;

            return aux;
        }
        
        #region Validações Peça e Tabuleiro
        //VALIDAÇÃO: limite do tabuleiro

        public bool existePeca(Posicao pos)
        {
            //teste exception. Se for invalido vai cortar o método.
            validarPosicao(pos);
            return peca(pos) != null;
        }
        
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }

        public bool posicaoValida(Posicao pos)
        {
            //VERIFICA LIMITE DO TABULEIRO
            // '<='  o numero passado para criar a matriz tabuleiro é inteiro e a posição do n° inteiro passado é a primeira q não existe. ex: 8 linhas, poisções de 0 a 7.
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region comentarios extra
        //**acho q o metodo  #posiçãoValida poderia estar dentro do #validarPosição

        #endregion
    }
}
