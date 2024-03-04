using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            Game Game1 = new Game();
            int Thrown_Dice_Values = Game1.play();

            Testing test = new Testing();
            int Check_Sum = test.V_check_Sum();
            Console.WriteLine("TEST: " + Check_Sum);

            Console.WriteLine("TDV" + Thrown_Dice_Values);
        }
    }
}
