using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {
        private char[,] board = new char[8, 8];

        public char[,] ChessBoard
        {
            get { return board; }
            set { board = value; }
        }

        private List<Piece> pieces;

        public List<Piece> Pieces
        {
            get { return pieces; }
            set { pieces = value; }
        }

        public void Draw()
        {
            for (int i = 0; i < Pieces.Count(); i++)
            {
                Pieces[i].SetColour();
                Console.SetCursorPosition(Pieces[i].XCoordinate, Pieces[i].YCoordinate);
                Console.Write(Pieces[i].DisplaySymbol);
            }
        }

    }
}
