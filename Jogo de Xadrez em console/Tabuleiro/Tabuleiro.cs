﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;
        public Tabuleiro(int linhas, int colunas)
        {
            this.colunas = colunas;
            this.linhas = linhas;
            pecas = new Peca[linhas, colunas];

        }
    }
}
