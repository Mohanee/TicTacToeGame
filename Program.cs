using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello, Welcome to TicTacToeGame");
            TicTacToe t = new TicTacToe();
            t.CreateBoard();
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
