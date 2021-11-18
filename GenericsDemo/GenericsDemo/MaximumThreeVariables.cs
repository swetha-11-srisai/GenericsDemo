using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class MaximumThreeVariables
    {
       
        public void CheckMaxNumber()
        {
            string str = "Apple";
            string strone = "orange";
            string strtwo = "bananna";
            if(str.Length > strone.Length && str.Length > strtwo.Length)
            {
                Console.WriteLine("String is greater"+ str.Length);

            }
            if (strone.Length > strtwo.Length)
            {
                Console.WriteLine("String One is greater" + strone.Length);

            }
            else
            {
                Console.WriteLine("String Two is greater" + strtwo.Length);
            }


        }
    }
}
