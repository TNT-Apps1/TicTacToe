using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
// Instuctor: Judith Ligocki
//Purpose:  Assignment #5 TicTacToe
//Date:3-22-17
//*******************************


namespace Thompson_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info1 = new Info();
            GameUI thegame = new GameUI();
            info1.hello();
            thegame.Play(); //eventually become PlayAgain

            Console.ReadLine();



        }
    }
}
