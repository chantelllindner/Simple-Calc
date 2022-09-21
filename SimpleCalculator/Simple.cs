namespace SimpleCalculator;

public class Simple: GetData
{
        public static bool TheCalculator()
        {
            Console.WriteLine("\nWelcome to Chantell's Simple Calculator, \nwhere you can do simple math to get simple answers. \nThis calculator can add, subtract, multiply, or divide 2 numbers. \nAnything more or anything less will result in an error. \nHave fun and math responably.\n");
            bool shouldContinue = true;

            while (shouldContinue)
            {
                
                double firstNumber = GetNumber("first");

                string txtOperator = GetOperator();
                
                double secondNumber = GetNumber("second");
                if (txtOperator.Equals("/"))
                {
                    while (secondNumber == 0)
                    {
                        Console.WriteLine("Can not Divide by Zero.Try Again...");
                        secondNumber = GetNumber("second");
                    }
                }

                CalculateStuff(firstNumber, txtOperator, secondNumber);
                
                string continueOption = GetContinue("Simple Calculator");
                switch (continueOption)
                {
                    case "1":
                        shouldContinue = true;
                        break;
                    case "2":
                        return true;
                    case "3":
                        return false;
                    default:
                        Console.WriteLine("This was not a valid option");
                        break;
                }

                
            }

            return true;
        }

        private static void CalculateStuff(double firstNumber, string txtOperator, double secondNumber)
        {
            switch (txtOperator)
            {

                case "+":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;

                case "-":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;

                case "*":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;

                case "/":
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;

                default:
                    Console.WriteLine($"{txtOperator} is not a valid Operator.");
                    break;
            }

        }
        
}