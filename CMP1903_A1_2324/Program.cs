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
            

            Game myGame = new Game();//game object is instantialised 
            myGame.Roll_1();//Roll method is called
            
            myGame.Sum_Total();
            
            Testing Test = new Testing();//test object created
            Test.V_Check_Sum();//uses the V_Check_Sum method to ensure the total value of dice rolls is in the bounds (3-18)
            Test.D_Check_Value();//uses the D_Check_Value method to ensure dice values are in the bounds (1-6)
            
        }
    }
}
