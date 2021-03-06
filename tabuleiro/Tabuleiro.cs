namespace XadrezConsole.tabuleiro
{
    class Tabuleiro
    {
        public int linhas {get; set;}
        public int colunas {get; set;}
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca GetPeca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return GetPeca(pos) != null;
        }

        public void SetPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroExeption("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca RmPeca(Posicao pos)
        {
            if (GetPeca(pos) == null)
            {
                return null;
            }
            Peca aux = GetPeca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos) 
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroExeption("Posição Inválida!");
            }
        }
    }
}