using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello, Welcome to TicTacToeGame");
=======
            Console.WriteLine("Hello Welcome to TictacToe Game");
            TicTacToe t = new TicTacToe();
            t.CreateBoard();
>>>>>>> CreateBoard_UC1
        }
    }

    class TicTacToe
    {
        public void CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < 10; i++)
            {
                board[i] = Convert.ToChar(0);
            }
        }
    }



}
