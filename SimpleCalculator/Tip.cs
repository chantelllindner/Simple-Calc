namespace SimpleCalculator;

public class Tip: GetData
{
    public static bool TipCalculator()
    {
        bool shouldContinue = true;
        Console.WriteLine("\n ***************\n Tip Calculator  \n ***************");
        Console.WriteLine("Welcome to Chantell's Tip Calculator! \nHere you will be able to enter your Bill amount, and select from 3 different Tip amounts. Don't be cheap, and math responsibly! ");

        while (shouldContinue == true)
        {
            //get number
            decimal dollarNum = GetDollar();
            while (dollarNum < 0)
            {
                Console.WriteLine($"A Bill can not be a negative amount. Try Again...");
                dollarNum = GetDollar();
            }

            //get tip %
            decimal percent = GetTipPercent();


            //math and print out. 
            Calculation(dollarNum, percent);

            string continueOption = GetContinue("Tip Calculator");
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
    
    //method to math tip
    private static void Calculation(decimal dollarNum, decimal percent)
    {
        Console.WriteLine($"Bill:         {dollarNum:C} \n{Math.Round(percent*100)}% Tip:      {(dollarNum*percent):C}\nTotal Bill:   {(dollarNum+(dollarNum*percent)):C} ");
    }
    
    
}
