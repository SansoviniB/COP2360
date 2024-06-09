using System;

namespace division
{
internal class Program
    {
        private static void Main(string[] args)
        {
        
            Console.WriteLine("You will be entering two numbers, no greater than 1000.");
            
            Console.WriteLine("Please enter the first number: ");
            
            string firstInput = Console.ReadLine();

            Console.WriteLine("Please enter the second number: ");
            string secondInput = Console.ReadLine();

            try
            {
                int firstNum = Convert.ToInt32(firstInput);
                int secondNum = Convert.ToInt32(secondInput);

                 if (firstNum > 1000 || secondNum > 1000)
                {
                    throw new OverflowException("One or both of the numbers are greater than 1000.");
                }

                int answer = Division(firstNum, secondNum);
                Console.WriteLine($"The answer of {firstNum} divided by {secondNum} is {answer}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("One or both inputs is not a number.");
                Console.WriteLine($"More specifically, the issue is: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by 0 unfortunately");
                Console.WriteLine($"More specifically, the issue is: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error that caused the program to fail.");
                Console.WriteLine($"More specifically, the issue is: {ex.Message}");
            }
        }

        static int Division (int num1, int num2){
            return num1 / num2;
        } 
    }
}