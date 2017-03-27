using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
// Instuctor: Judith Ligocki
//Purpose:  Assignment #5 TicTacToe UI View Class
//Date:3-22-17
//*******************************

namespace Thompson_TicTacToe
{
    class GameUI
    {
        Board theboard; //object variable
        private int winnerHolder;
        const int NUM_PLAYERS = 2;
        const int FIRST = 0;
        const int SECOND = 1;
        static int current_player = FIRST;
        Player[] theplayers = new Player[NUM_PLAYERS];  //allocate memory.
        String gameLoop = "y";
        

        public void Play()
        {
            do
            {
                theplayers[FIRST] = new Player(); //creates player
                theplayers[SECOND] = new Player();
                winnerHolder = 0;

                theboard = new Board();

                do
                {
                    int doLoopHolder = 0;
                    int move;
                    do
                    {
                        DisplayBothGrids();
                        if (doLoopHolder == 0)
                            Console.WriteLine("\nPlayer {0} make your move 0-8=>", theplayers[current_player].Piece);
                        if (doLoopHolder != 0)
                            Console.WriteLine("\nThe square you entered has already been taken.\n\nPlayer {0} make your move 0-8=>", theplayers[current_player].Piece);
                        doLoopHolder++;
                        int.TryParse(Console.ReadLine(), out move);
                    } while (theboard.isLegalMove(move) == true);

                    theplayers[current_player].MakeMove(move, theboard);
                    DisplayBothGrids();
                    NextPlayer();
                } while (IsPlaying());

                announceWinner();
                Console.WriteLine("Would you like to play again? Y:N");
                gameLoop = Console.ReadLine().ToLower();

            } while (gameLoop != "n");
        }


        bool IsPlaying()
        {
            //bool inPlay = false;
            if (theboard.IsWinner(theplayers[FIRST].Piece) == true)
            {
                winnerHolder = 1;//sets winner for announceWinner
                return false;
            }

            if (theboard.IsWinner(theplayers[SECOND].Piece) == true)
            {
                winnerHolder = 2;//sets winner for announceWinner
                return false;
            }

            if (theboard.IsFull() == true)
            {
                winnerHolder = 99;//sets winner for announceWinner
                return false;
            }


            return true;
        }


        void announceWinner()
        {
            DisplayBothGrids();
            switch (winnerHolder)
            {
                case 1:
                    Console.WriteLine("Player X won!!");
                    current_player = FIRST;//winner goes first next game
                    break;
                case 2:
                    Console.WriteLine("Player O won!!");
                    current_player = SECOND;//winner goes first next game
                    break;
                default:
                    Console.WriteLine("Tie game!");
                    break;
            }
        }

        


        



        void NextPlayer()
        {
            if (current_player == FIRST)
                current_player = SECOND;
            else
                current_player = FIRST;
        }





        void DisplayBothGrids()
        {
            char[] grid = theboard.PlayingBoard;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("        {0} | {1} | {2}          {3} | {4} | {5}", 0, 1, 2, grid[0], grid[1], grid[2]);
            Console.WriteLine("        ----------         ---------");
            Console.WriteLine("        {0} | {1} | {2}          {3} | {4} | {5}", 3, 4, 5, grid[3], grid[4], grid[5]);
            Console.WriteLine("        ----------         ---------");
            Console.WriteLine("        {0} | {1} | {2}          {3} | {4} | {5}", 6, 7, 8, grid[6], grid[7], grid[8]);
        }
       


    }
}
