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
        private int Roll_Value1 = 0;
        private int Roll_Value2 = 0;
        private int Roll_Value3 = 0;
        public int Sum = 0;

        public int Sum_Total()
        {
            Die Die1 = new Die();
            Roll_Value1 = Die1.Roll();
            

            Die Die2 = new Die();
            Roll_Value2 = Die1.Roll();
            

            Die Die3 = new Die();
            Roll_Value3 = Die1.Roll();
            



            int j = Roll_Value1 + Roll_Value2 + Roll_Value3;
            int Sum = j;
            
            return Sum;
        }

        
    }

}
