using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        private int Check_Sum = 0;
        private int Dice_Value = 0;
        

        //Method
        public int V_Check_Sum()//the V_Check_Sum method ensures that the total value of all dice rolls is in the bounds (3-18)
        {
            
        Game Gametest = new Game();
        Gametest.Roll_1();
        int Check_Sum = Gametest.Sum_Test();
        
            
            Debug.Assert(Check_Sum >= 3 && Check_Sum < 19, "the total value is not possible");//the dubug,assert will take a condition and print an error if it is false
        
        return Check_Sum;
            
        }
        
        public int D_Check_Value()//the D_Check_Value method ensures die values are in the bounds (1-6)
        {

        Die die1 = new Die();
        int L = die1.Roll();
        int Dice_Value = L;
        
        Debug.Assert(Dice_Value >= 1 && Dice_Value < 7, "the dice has been lost");//the dubug,assert will take a condition and print an error if it is false


            return Dice_Value;
        }

        

    }

}
