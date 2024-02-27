using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pacman
{
    internal class Player
    {
        public char playerchar;
        public int pX;
        public int pY;
        public Player(char pcharacter, int px, int py)
        {
            this.playerchar = pcharacter;
            this.pX = px;
            this.pY = py;
        }
        public void moveplayerright(char[,] board)
        {
            if (board[pY, pX + 1] == ' ')
            {
                board[pY, pX] = ' ';
                pX++;
                board[pY, pX] = playerchar;
            }
        }
        public void moveplayerleft(char[,] board)
        {
            if ((board[pY, pX - 1]) == ' ')
            {
                board[pY, pX] = ' ';
                pX--;
                board[pY, pX] = playerchar;
            }
        }
        public void removebullet(char[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j <37; j++)
                {
                    if (board[i, j] == 'o')
                    {
                        board[i, j] = ' ';
                    }
                }
            }
        }

        public void createFire(char[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 37; j++)
                {
                    if (board[i, j] == playerchar)
                    {
                        if (board[i-1, j ] != '#')
                        {
                            board[i-2, j ] = 'o';
                           
                           
                         




                        }
                    }
                }
            }
        }
    }
}

