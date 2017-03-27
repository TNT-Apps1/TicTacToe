using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
// Instuctor: Judith Ligocki
//Purpose:  Assignment #5 TicTacToe Board Model
//Date:3-22-17
//*******************************

namespace Thompson_TicTacToe
{
    class Board
    {
        const int NUM_SQUARES = 9;
        char[] m_squares = new char[NUM_SQUARES];
        const char EMPTY = ' ';
        

        public Board()
        {
            Reset();
        }






        public char[] PlayingBoard
        {
            get { return m_squares; }
        }







        public void Reset()
        {
            for (int i = 0; i < m_squares.Length; i++)
            {
                m_squares[i] = EMPTY;
            }


        }



        public bool isLegalMove(int arg1)
        {
            if (m_squares[arg1].Equals('X') || m_squares[arg1].Equals('O'))
                return true;
            else
                return false;
        }



        public bool IsWinner(char piece)
        {
            
            //across
            if (m_squares[0] == piece && m_squares[1] == piece && m_squares[2] == piece)
                return true;
            if (m_squares[3] == piece && m_squares[4] == piece && m_squares[5] == piece)
                return true;
            if (m_squares[6] == piece && m_squares[7] == piece && m_squares[8] == piece)
                return true;
            //down
            if (m_squares[0] == piece && m_squares[3] == piece && m_squares[6] == piece)
                return true;
            if (m_squares[1] == piece && m_squares[4] == piece && m_squares[7] == piece)
                return true;
            if (m_squares[2] == piece && m_squares[5] == piece && m_squares[8] == piece)
                return true;
            //diagonal
            if (m_squares[0] == piece && m_squares[4] == piece && m_squares[8] == piece)
                return true;
            if (m_squares[2] == piece && m_squares[4] == piece && m_squares[6] == piece)
                return true;

            return false;

        }




        public bool IsFull()
        {
            bool full = true;
            int i = 0;

            while (full && i < NUM_SQUARES)
            {
                if (m_squares[i] == EMPTY)
                {
                    full = false;
                }
                ++i;
            }
            return full;
        }




        public void ReceiveMove(char piece, int move)
        {
            m_squares[move] = piece;
        }
    }
}
