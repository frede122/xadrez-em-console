using System;
using Tabuleiro;
namespace Jogo_de_Xadrez_em_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3,4);
            Console.WriteLine("Posição " + P);
            Console.ReadLine();
        }
    }
}
