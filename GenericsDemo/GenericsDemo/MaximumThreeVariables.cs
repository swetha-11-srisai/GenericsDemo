using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class MaximumThreeVariables
    {
       
        public void CheckMaxNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("First Number is greater");
            }
            if(secondNumber > thirdNumber)
            {
                Console.WriteLine("Second Number is greater");
            }
            else
            {
                Console.WriteLine("Third Number is greater");
            }

        }
    }
}
