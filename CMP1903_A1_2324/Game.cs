using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Game
    {
        private int Die_Value1 = 0;// private properties within the game class that cant be altered by another class
        private int Die_Value2 = 0;
        private int Die_Value3 = 0;

        Die Die1 = new Die();
        Die Die2 = new Die();
        Die Die3 = new Die();
        public (int, int, int) Roll_1()// this is a method that generates a die and invokes the Roll method which returns a random number
        {
   
            Die_Value1 = Die1.Roll();

            Die_Value2 = Die2.Roll();

           
            Die_Value3 = Die3.Roll();
            
            return (Die_Value1, Die_Value2, Die_Value3);

        }

        public int Sum_Total()// method that Sums the three dice and outputs the total as well as the dices individual scores
        {
            Console.WriteLine("You rolled a : " + Die_Value1);

            Console.WriteLine("You rolled a : " + Die_Value2);

            Console.WriteLine("You rolled a : " + Die_Value3);

            int Sum = Die_Value1 + Die_Value2 + Die_Value3;
            Console.WriteLine("In total, you rolled: " + Sum);
            return Sum;
        }

        public int Sum_Test()// a method which allows me to test the Sum value in my test file without printing
        {
            int Sum = Die_Value1 + Die_Value2 + Die_Value3;
            
            return Sum;
        }
    }

}
