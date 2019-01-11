using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[,] tictactoeboard = new char[3, 3];
        static int[,] verifyboard = new int[3, 3];
        static int turn = 0;
        static int row = 0;
        static int column = 0;
        static int player = 0;
        static int win = 0;
        static void Main(string[] args)
        {
            resetboard(tictactoeboard);
            int answer = 0;
            while (answer != 2)
            {
                //menuuuuuuuu
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Play tic-tac-toe");
                Console.WriteLine("** 2. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    win = 0;
                    resetboard(tictactoeboard);
                    Console.Clear();
                    Console.Write("Do you want a brief desciption on how to play tic-tac-toe? y or n: ");
                    char YorN = char.Parse(Console.ReadLine());
                    //check if they inputed and uppercase letter
                    if (YorN == 'Y')
                    {
                        YorN = 'y';
                    }
                    if (YorN == 'N')
                    {
                        YorN = 'n';
                    }
                    if (YorN == 'y')
                    {
                        //spit out breif description
                        Console.WriteLine("The goal of tic tac toe is to get three is a row before your opponent does.");
                        Console.WriteLine("The person who goes first will be an X and the other person will be an O.");
                        Console.WriteLine("To pick which spot you want you will type first which column and press enter, then you will pick which row");
                    }
                    player = 0;
                    turn = 0;
                    while (turn != 9 && win != 3 && win != 15)
                    {
                        if (turn % 2 == 0)
                        {
                            if (turn > 0)
                            {
                                Console.Clear();
                            }
                            DrawBoard(tictactoeboard);
                            Console.WriteLine("Player 1");
                            ask();
                            ProcessTurn(tictactoeboard);
                        }
                        else if (turn % 2 != 0)
                        {
                            Console.Clear();
                            DrawBoard(tictactoeboard);
                            Console.WriteLine("Player 2");
                            ask();
                            ProcessTurn(tictactoeboard);
                        }
                        Console.WriteLine(turn);
                        if (turn == 8)
                        {
                            Console.Clear();
                            DrawBoard(tictactoeboard);
                            Console.WriteLine("It's a draw!");
                        }
                        turn = turn + 1;
                    }
                }
            }
        }
        static void ask()
        {
            Console.Write("Pick a column: ");
            column = int.Parse(Console.ReadLine());
            Console.Write("Pick a row: ");
            row = int.Parse(Console.ReadLine());
        }
        //processes their answer and inputs an x or o in the correct spot that they requested
        static void ProcessTurn(char[,] board)
        {
            char check = tictactoeboard[row, column];
            //check if spot is already taken
            while (check != ' ')
            {
                Console.WriteLine("That spot is already taken, try again");
                ask();
                check = tictactoeboard[row, column];
            }
            if (check == ' ')
            {
                //check if it is player 1 or 2
                if (turn % 2 == 0)
                {
                    tictactoeboard[row, column] = 'X';
                    verifyboard[row, column] = 1;
                }
                else
                {
                    tictactoeboard[row, column] = 'O';
                    verifyboard[row, column] = 5;
                }
            }
            for (int i = 0; i < verifyboard.GetLength(0); i++)
            {
                //Checks across 
                if (win != 15 && win != 3)
                {
                    win = 0;
                    for (int j = 0; j < verifyboard.GetLength(1); j++)
                    {
                        win = win + verifyboard[i, j];
                    }
                }
                //Checks down
                if (win != 15 && win != 3)
                {
                    win = 0;
                    for (int j = 0; j < verifyboard.GetLength(1); j++)
                    {
                        win = win + verifyboard[j, i];
                    }
                }
                //Checks diagonal
                if (win != 15 && win != 3)
                {
                    win = 0;
                    for (int j = 0; j < verifyboard.GetLength(1); j++)
                    {
                        win = win + verifyboard[j, j];
                    }
                }
                if (win != 15 && win != 3)
                {
                    win = 0;
                    for (int j = 0; j < verifyboard.GetLength(0); j++)
                    {
                        int a = 2;
                        win = win + verifyboard[a, j];
                        a = a - 1;
                    }
                }
            }
            if (win == 15)
            {
                Console.Clear();
                DrawBoard(tictactoeboard);
                Console.WriteLine("Player 2 Won!");
            }
            if (win == 3)
            {
                Console.Clear();
                DrawBoard(tictactoeboard);
                Console.WriteLine("Player 1 Won!");
            }
        }
        static void DrawBoard(char[,] board)
        {
            //draws the board out
            Console.WriteLine("    0   1   2 ");
            for (int i = 0; i < tictactoeboard.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < tictactoeboard.GetLength(1); j++)
                {
                    Console.Write(" | " + tictactoeboard[i, j]);
                }
                Console.Write(" | ");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// it resets the board
        /// </summary>
        /// <param name="board"></param>
        static void resetboard(char[,] board)
        {
            //resets the board so if they want to play again they can
            for (int i = 0; i < tictactoeboard.GetLength(0); i++)
            {
                for (int j = 0; j < tictactoeboard.GetLength(1); j++)
                {
                    tictactoeboard[i, j] = ' ';
                }
            }
            //resets the verify board
            for (int i = 0; i < verifyboard.GetLength(0); i++)
            {
                for (int j = 0; j < verifyboard.GetLength(1); j++)
                {
                    verifyboard[i, j] = 0;
                }
            }
        }
    }
}
