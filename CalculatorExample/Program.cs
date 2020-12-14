using System;

namespace CalculatorExample
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            double num1, num2, result;
            Char input;
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            try {
            Console.Write("Please enter your choice : ");

            try
            {
            input = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid option");
                return;
            }
            if(input != '1' & input != '2' & input != '3' & input != '4')
            {
                Console.Write("Please enter a valid option");
                return;
            }
            Console.Write("Please enter first number : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second number : ");
            num2 = Convert.ToDouble(Console.ReadLine());
            }
             catch
            {
                
                Console.WriteLine("Please enter a valid number");    
                                
                return;
            }
            
        
            switch (input)
            {
                case '1':
                result = num1 + num2;
                Console.Write("The result of calculation is : {0}", result);
                break;

                case '2':
                result = num1 - num2;
                Console.Write("The result of calculation is : {0}", result);
                break;

                case '3':
                result = num1 * num2;
                Console.Write("The result of calculation is : {0}", result);
                break;

                case '4':
                result = num1 / num2;
                Console.Write("The result of calculation is : {0}", result);
                break;

                default:
                break;
            }
            
        }
    }
}
