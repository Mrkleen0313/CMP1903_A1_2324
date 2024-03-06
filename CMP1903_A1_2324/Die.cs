using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{

    /*
     * The Die class should contain one property to hold the current die value,
     * and one method that rolls the die, returns an integer and takes no parameters.
     */

    internal class Die
    {
        //Fields
        private int Roll_Value = 0; //private integer to ensure that it cannot be changed by other files 
        private Random random = new 
        Random(Guid.NewGuid().GetHashCode());//pulled from stack overflow to fix error where dice roll same value due to tick speed being the seed for psuedo random 

        //Method
        public int Roll()//method which assigns the value of i (1-7), to the private property inside this class
        {

            int i = random.Next(1,7);//chooses a random number inclusive of 1 and exclusive of 7
            Roll_Value = i;// assigns the value of i to Roll_Value
            
            return Roll_Value;

        }

        

        

    }
}
