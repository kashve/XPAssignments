using System;

namespace CalculatorExample
{
    class Calculator
    {
       
        static void Calculate(ref Char op,ref double num1 , ref double num2)
        {

        double result;
        switch (op)
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

        static bool getinput(ref Char input, ref double num1 ,ref double num2)
        {
           try {
            Console.Write("Please enter your choice : ");

            try
            {
            input = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid option");
                return false;
            }
            if(input != '1' & input != '2' & input != '3' & input != '4')
            {
                Console.Write("Please enter a valid option");
                return false;
            }
            Console.Write("Please enter first number : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter second number : ");
            num2 = Convert.ToDouble(Console.ReadLine());
           }
            
             catch
            {
                
                Console.WriteLine("Please enter a valid number");    
                                
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
           
            double num1 = 0, num2 = 0;
            Char input = '0';
            bool isvalid;
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            isvalid = getinput(ref input,ref num1, ref num2);
            if (isvalid == true)
            {
               Calculate(ref input,ref num1,ref num2);
            } 
        }
    }
}
