using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Program
    {
        static void Main()
        {
            // 4x4
            // 4 arrays of length 4
            // Enter number : If array[number] == null... Write X... else .... reenter
            //foreach array ... print [ ][ ][ ][ ] .... [X][ ][ ][X]

            bool over = false;
            int counter = 0;

            Console.WriteLine("Enter Width of Grid");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height of Grid");
            int height = int.Parse(Console.ReadLine());

            string[,] board = new string[height, width];

            Console.WriteLine("Enter Column:");

            while (!over)
            {
                counter++;

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (board[i, j] == null)
                            Console.Write("[ ]");
                        else
                            if (board[i,j]=="X")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("[" + board[i, j] + "]");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        else if(board[i,j]=="O")
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("[" + board[i, j] + "]");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Gray;
       
                        }
                    }
                    Console.WriteLine();
                }

                int col = int.Parse(Console.ReadLine());

                for (int i = 0; i < height; i++)
                {
                    if (board[height - 1 - i, col] == null && counter % 2 == 1)
                    {
                        board[height - 1 - i, col] = "X";
                        break;
                    }
                    else if (board[height - 1 - i, col] == null && counter % 2 == 0)
                    {
                        board[height - 1 - i, col] = "O";
                        break;


                    }
                }
                //CHECK ACROSS
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width - 3; j++)
                    {
                        if (board[i, j] == "X" && board[i, j + 1] == "X" && board[i, j + 2] == "X" && board[i, j + 3] == "X")
                        {
                            Console.WriteLine("X Wins!");
                            over = true;
                            break;
                        }
                        else if (board[i, j] == "O" && board[i, j + 1] == "O" && board[i, j + 2] == "O" && board[i, j + 3] == "O")
                        {
                            Console.WriteLine("O Wins!");
                            over = true;
                            break;
                        }
                    }
                }
                //CHECK UP
                for (int k = 0; k < height - 3; k++)
                {
                    for (int l = 0; l < width; l++)
                    {
                        if (board[k, l] == "X" && board[k + 1, l] == "X" && board[k + 2, l] == "X" && board[k + 3, l] == "X")
                        {
                            Console.WriteLine("X Wins!");
                            over = true;
                            break;
                        }
                        if (board[k, l] == "O" && board[k + 1, l] == "O" && board[k + 2, l] == "O" && board[k + 3, l] == "O")
                        {
                            Console.WriteLine("O Wins!");
                            over = true;
                            break;
                        }
                    }
                }

                // CHECK for \ WAY
                for (int m = 0; m < height - 3; m++)
                {
                    for (int n = 0; n < width - 3; n++)
                    {
                        if (board[n, m] == "X" && board[n + 1, m + 1] == "X" && board[n + 2, m + 2] == "X" && board[n + 3, m + 3] == "X")
                        {
                            Console.WriteLine("X Wins!");
                            over = true;
                            break;
                        }
                        else if (board[n, m] == "O" && board[n + 1, m + 1] == "O" && board[n + 2, m + 2] == "O" && board[n + 3, m + 3] == "O")
                        {
                            Console.WriteLine("O Wins!");
                            over = true;
                            break;
                        }
                    }
                }
                // CHECK for / WAY

                for (int m = 0; m < height - 3; m++)
                {
                    for (int n = width - 1; n > 3; n--)
                    {
                        if (board[n, m] == "X" && board[n - 1, m + 1] == "X" && board[n - 2, m + 2] == "X" && board[n - 3, m + 3] == "X")
                        {
                            Console.WriteLine("X Wins!");
                            over = true;
                            break;
                        }
                        else if (board[n, m] == "O" && board[n - 1, m + 1] == "O" && board[n - 2, m + 2] == "O" && board[n - 3, m + 3] == "O")
                        {
                            Console.WriteLine("O Wins!");
                            over = true;
                            break;
                        }
                    }
                }


            }

        }
    }
}