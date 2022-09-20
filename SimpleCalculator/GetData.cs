namespace SimpleCalculator;

public class GetData
{
    protected static double GetNumber(string numName)
    {
        double number;

        Console.Write($"Enter in {numName} number: ");
        string? numInput = Console.ReadLine();
        bool isNum = Double.TryParse(numInput, out number);

        while (!isNum)
        {
            Console.WriteLine("Invalid Input. Try Again...");
            Console.Write($"Enter in {numName} number: ");
            numInput = Console.ReadLine();
            isNum = Double.TryParse(numInput, out number);

        }
        return number;
    }

    protected static decimal GetDollar()
    {
        decimal number;
        
        Console.Write($"Enter Bill Amount: $");
        string? numInput = Console.ReadLine();
        bool isNum = Decimal.TryParse(numInput, out number);
        
        while (!isNum)
        {
            Console.WriteLine("Invalid Input. Try Again...");
            Console.Write($"Enter Bill Amount: $");
            numInput = Console.ReadLine();
            isNum = Decimal.TryParse(numInput, out number);

        }
        
        return Math.Round(number, 2);
    }

    public static bool GetContinue()
    {
                       
        Console.Write("Would you like to continue (y/n): ");
        string resposne = Console.ReadLine()!.ToLower();

        while (resposne != "y" && resposne != "n")
        {

            Console.WriteLine("Invalid Input. Try Again...");                              
            Console.Write("Would you like to continue (y/n): ");
            resposne = Console.ReadLine()!.ToLower();
                
        }
        if (resposne == "n")
        {
            Console.WriteLine("Thank you! \n______END______");
            return false;
        }
        return true;

    }
    
    protected static string GetOperator()
    {
                      
        Console.Write("Enter in operator: -, +, /, *: ");
        var txtOperator = Console.ReadLine();
        while (txtOperator != "-" && txtOperator != "+" && txtOperator != "/" && txtOperator != "*")
        {
            Console.WriteLine("Invalid Input. Try Again...");
            Console.Write("Enter in operator: -, +, /, *: ");
            txtOperator = Console.ReadLine();                
        }
        return txtOperator;
    }

    protected static decimal GetTipPercent()
    {
        Console.Write("Please enter option 1-3 for the tip amount you would like to calculate:\n1)18% \n2)20% \n3)25%\nEnter Option:");
        string? tipchoise = Console.ReadLine();
        while (tipchoise != "1" && tipchoise != "2" && tipchoise != "3" && tipchoise != "4")
        {
            Console.WriteLine("Invalid Input. Try Again..."); 
            Console.Write("Please enter option 1-3 for the tip amount you would like to calculate:\n1)18% \n2)20% \n3)25%\nEnter Option:");
            tipchoise = Console.ReadLine();
        }
        switch (tipchoise)
        {
            case "1":
                return (decimal).18;
            case "2":
                return (decimal).20;
            case "3":
                return (decimal).25;
            default:
                Console.WriteLine("This was not a valid choice.");
                return 0;
                
        }
        
    }
}