using System;
using tabuleiro;
using xadrez;

namespace Jogo_de_Xadrez_em_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                Tela.imprimirTabuleiro(tab);
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.ReadLine();
        }
    }
}
