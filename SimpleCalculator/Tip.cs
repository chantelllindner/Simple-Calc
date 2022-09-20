namespace SimpleCalculator;

public class Tip: GetData
{
    public static void TipCalculator()
    {
        Console.WriteLine("Welcome to Chantell's Tip Calculator! Here you will be able to enter your Bill amount, and select from 3 different Tip amounts. Don't be cheap, and math responsibly! ");
        //get number
        decimal dollarNum = GetDollar();
        while (dollarNum < 0)
        {
            Console.WriteLine($"A Bill can not be negative amount. Try Again...");
            dollarNum = GetDollar();
        }

        //get tip %
        decimal percent = GetTipPercent();


        //math and print out. 
        Calculation(dollarNum, percent);

    }
    
    //method to math tip
    private static void Calculation(decimal dollarNum, decimal percent)
    {
        Console.WriteLine($"Bill:         {dollarNum:C} \n{Math.Round(percent*100)}% Tip:      {(dollarNum*percent):C}\nTotal Bill:   {(dollarNum+(dollarNum*percent)):C} ");
    }
    
    
}
