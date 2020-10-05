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
            char pLetter = t.ChooseLetter();
            bool val = true;
            while (val)
            {
                if (!(pLetter.Equals('X') || pLetter.Equals('O')))
                {
                    pLetter = t.ChooseLetter();
                }
                else
                {
                    val = false;
                }
            }
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
                board[i] = ' ';
            }
        }

        public char ChooseLetter()
        {
            Console.WriteLine("Choose a letter among X and O");
            char pLetter = Convert.ToChar(Console.ReadLine());
                return pLetter;
        }
    }



}
