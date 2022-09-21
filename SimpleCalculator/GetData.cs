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

    public static string GetContinue(string CalcName)
    {
        Console.WriteLine("\n ***************\n   Continue?   \n ***************");               
        Console.WriteLine($"Please choose from the following: \n1 Try {CalcName} again \n2 Go back to Main Menu \n3 Exit Program ");
        Console.Write("Enter Option:");
        string resposne = Console.ReadLine()!.ToLower();

        while (resposne != "1" && resposne != "2" && resposne != "3")
        {

            Console.WriteLine("Invalid Input. Try Again...");                              
            Console.WriteLine($"Please choose from the following: \n1 Try {CalcName} again \n2 Go back to Main Menu \n3 Exit Program ");
            Console.Write("Enter Option:");
            resposne = Console.ReadLine()!.ToLower();
                
        }
        
        Console.WriteLine();
        return resposne;


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

    public static string GetMainMenu()
    {
        Console.WriteLine("Please choose from the following: \n1 Simple Calculator \n2 Tip Calculator");
        Console.Write("Enter Option:");
        var menuChoice = Console.ReadLine();
        while (menuChoice != "1" && menuChoice != "2")
        {
            Console.WriteLine("Invalid Input. Try Again...");
            Console.WriteLine("Please choose from the following: \n1 for Simple Calculator \n2 for Tip Calculator");
            Console.Write("Enter Option:");
            menuChoice = Console.ReadLine();                
        }
        return menuChoice;
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