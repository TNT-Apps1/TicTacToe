using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
// Instuctor: Judith Ligocki
//Purpose:  Assignment #5 TicTacToe Player (Model Class)
//Date:3-22-17
//*******************************


namespace Thompson_TicTacToe
{
    class Player
    {
        char m_piece;
        static int current; //share memory location will all PLayers.
        const int NUM_PIECES = 2;
        readonly char[] PIECES = { 'X', 'O' };
        Board aBoard;

        public Player()
        {
            m_piece = PIECES[current];
            current = (current + 1) % NUM_PIECES;
            aBoard = new Board();
        }//end constructor


        public void MakeMove(int move, Board aBoard)  //no need to pass by ref Object already ref type variable.
        {
            //try not to prompt in Player..UI GameUI Class.
            aBoard.ReceiveMove(m_piece, move);

        }


        public char Piece
        {
            get { return m_piece; }
        }






    }
}
