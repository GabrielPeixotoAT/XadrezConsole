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

        public void SetPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}