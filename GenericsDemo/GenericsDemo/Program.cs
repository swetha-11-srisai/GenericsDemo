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
                Console.WriteLine("Enter your choice to execute-1-MaxStringNumber,2-Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Given Strings are:");
                        MaximumThreeVariables max =new  MaximumThreeVariables();
                        max.CheckMaxNumber();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
       
    }
}
