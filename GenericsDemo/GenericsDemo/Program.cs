using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag= true;
            while (flag)
            {
                Console.WriteLine("Enter your choice to execute-1-MaxIntNumber,2-Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter the numbers");
                        int firstNumber = Convert.ToInt32(Console.ReadLine());
                        int secondNumber = Convert.ToInt32(Console.ReadLine());
                        int thirdNumber = Convert.ToInt32(Console.ReadLine());
                        MaximumThreeVariables max =new  MaximumThreeVariables();
                        max.CheckMaxNumber(firstNumber,secondNumber,thirdNumber);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
       
    }
}
