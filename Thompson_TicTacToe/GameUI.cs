using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thompson_TicTacToe
{
    class GameUI
    {
        Board theboard; //object variable
        private int winnerHolder = 0;
        const int NUM_PLAYERS = 2;
        const int FIRST = 0;
        const int SECOND = 1;
        static int current_player = FIRST;
        Player[] theplayers = new Player[NUM_PLAYERS];  //allocate memory.
        

        public void Play()
        {
            theplayers[FIRST] = new Player(); //creates player
            theplayers[SECOND] = new Player();

            theboard = new Board();
            
            do
            {

                int move;
                do
                {   
                    DisplayBothGrids();
                    Console.WriteLine("Player {0} make your move 0-8=>", theplayers[current_player].Piece);
                    int.TryParse(Console.ReadLine(), out move);
                } while (theboard.isLegalMove(move) == true);

                theplayers[current_player].MakeMove(move, theboard);
                DisplayBothGrids();
                NextPlayer();
            } while (IsPlaying());

            announceWinner();


        }

        bool isTie()
        {
            return false;
        }

        

        void announceWinner()
        {
            DisplayBothGrids();
            switch (winnerHolder)
            {
                case 1:
                    Console.WriteLine("Player X won!!");
                    break;
                case 2:
                    Console.WriteLine("Player O won!!");
                    break;
                default:
                    Console.WriteLine("Tie game!");
                    break;
            }
        }

        


        bool IsPlaying()
        {
            //bool inPlay = false;
            if((theboard.IsWinner(theplayers[FIRST].Piece) ? 1 : 0) == 1)
            {
                winnerHolder = 1;
                return false;
            }

            if ((theboard.IsWinner(theplayers[SECOND].Piece) ? 2 : 0)== 2)
            {
                winnerHolder = 2;
                return false;
            }

                if ((theboard.IsFull()? 99:0)== 99)
            {
                winnerHolder = 99;
                return false;
            }
                

            return true;
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
        void DisplayGrid()
        {
            Console.WriteLine();
            Console.WriteLine("        {0} | {1} | {2}", 0, 1, 2);
            Console.WriteLine("        ----------");
            Console.WriteLine("        {0} | {1} | {2}", 3, 4, 5);
            Console.WriteLine("        ----------");
            Console.WriteLine("        {0} | {1} | {2}", 6, 7, 8);
        }


    }
}
