using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to TictacToe Game");
            TicTacToe t = new TicTacToe();
            t.CreateBoard();
            char pLetter = t.ChooseLetter();
            char cLetter='X';
            if(pLetter.Equals('X'))
            {
                cLetter = 'O';
            }
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

        public char ChooseLetter()
        {
            Console.WriteLine("Choose a letter among X and O");
            char pLetter = Convert.ToChar(Console.Read());

            return pLetter;
        }
    }



}
