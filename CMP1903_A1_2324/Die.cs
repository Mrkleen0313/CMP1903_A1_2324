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
        private int Roll_Value = 0;
        private Random random = new 
        Random(Guid.NewGuid().GetHashCode());

        //Method
        public int Roll()
        {

            int i = random.Next(1,7);
            Roll_Value = i;
            Console.WriteLine("You rolled a : " + i);
            return Roll_Value;

        }

        

        

    }
}
