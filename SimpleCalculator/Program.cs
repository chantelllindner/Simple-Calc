namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            //Intro
            Console.WriteLine("***********************************************\n Chantell's Simple Calculator & Tip Generator!\n***********************************************\n\n");

            while (keepGoing == true)
            {
                //Ask for 1 or 2
                string answer = GetData.GetMainMenu();
                
                //switch statement
                switch(answer)
                {
                    case "1":
                        keepGoing =Simple.TheCalculator();
                        break;
                    case "2":
                        keepGoing =Tip.TipCalculator();
                        break;
                    default:
                        keepGoing = false;
                        break;
                }
                
            }
            
            Console.WriteLine("\nThank you! \n*******\nTHE END\n*******");

        }
       
    }
}
    

