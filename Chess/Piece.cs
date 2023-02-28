using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Piece
    {
        private int x;
        private int y;

        public int XCoordinate
        {
            get { return x; }
            set { x = value; }
        }

        public int YCoordinate
        {
            get { return y; }
            set { y = value; }
        }

        private int[,] attack = new int[16, 16];
        private int[,] move = new int[16, 16];

        public int[,] AttackRange
        {
            get { return attack; }
            set { attack = value; }
        }
        public int[,] MoveRange
        {
            get { return move; }
            set { move = value; }
        }

        private char display;

        public char DisplaySymbol
        {
            get { return display; }
            set { display = value; }
        }

        private bool team;

        public bool Team
        {
            get { return team; }
            set { team = value; }
        }

        public void SetColour()
        {
            if (Team == true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
    }
}
