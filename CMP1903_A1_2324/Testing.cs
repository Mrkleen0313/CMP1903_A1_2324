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



        //Method
        public int V_check_Sum()
        {

        Game Game1 = new Game();
        int k = Game1.Sum_Total();
        int Thrown_Dice_Values = k;

        Debug.Assert(Thrown_Dice_Values >= 3 | Thrown_Dice_Values <= 18);

        Console.WriteLine("The thrown dice total value is: " + Thrown_Dice_Values);

        int Check_Sum = k;
        return Check_Sum;

        }
        
        public int D_Check_Value()
        {

        Die die1 = new Die();
        int L = die1.Roll();
        int Dice_Value = L;
        
        Debug.Assert(Dice_Value >= 1 | Dice_Value < 7);
            
        Console.WriteLine("The test dice has rolled a : " + Dice_Value);
            return Dice_Value;
        }

        

    }

}
