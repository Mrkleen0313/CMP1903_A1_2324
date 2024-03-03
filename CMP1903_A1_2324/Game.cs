using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */


        public Game() 
        {
            Die Die1 = new Die();
            int Roll_Value1 = Die1.Roll();
            Console.WriteLine(Roll_Value1);

            Die Die2 = new Die();
            int Roll_Value2 = Die1.Roll();
            Console.WriteLine(Roll_Value2);

            Die Die3 = new Die();
            int Roll_Value3 = Die1.Roll();
            Console.WriteLine(Roll_Value3);

            //Methods
            int Combined_Roll = Roll_Value1 + Roll_Value2 + Roll_Value3;
            Console.WriteLine(Combined_Roll);
        }




    }
}
