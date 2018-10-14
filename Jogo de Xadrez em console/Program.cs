using System;
using tabuleiro;
namespace Jogo_de_Xadrez_em_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
