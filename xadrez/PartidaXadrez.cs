using XadrezConsole.tabuleiro;

namespace XadrezConsole.xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro tab {get; private set;}
        private int turno;
        private Cor jogadorAutal;
        public bool terminada {get; private set;}

        public PartidaXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAutal = Cor.Branco;
            terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RmPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = tab.RmPeca(destino);
            tab.SetPeca(p, destino);
        }

        private void ColocarPecas()
        {
            tab.SetPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c', 1).toPosicao());
            tab.SetPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c', 2).toPosicao());
            tab.SetPeca(new Rei(tab, Cor.Branco), new PosicaoXadrez('d', 1).toPosicao());

            tab.SetPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('a', 7).toPosicao());
            tab.SetPeca(new Rei(tab, Cor.Preto), new PosicaoXadrez('e', 8).toPosicao());
            
        }
    }
}