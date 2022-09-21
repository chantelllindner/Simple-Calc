namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            //Intro
            Console.WriteLine("***********************************************\n Chantell's Simple & Tip Calculator Generator!\n***********************************************\n");

            while (keepGoing == true)
            {
                Console.WriteLine("\n ***************\n   Main Menu   \n ***************");  
                
                string answer = GetData.GetMainMenu();
                
                
                switch(answer)
                {
                    case "1":
                        keepGoing =Simple.TheCalculator();
                        break;
                    case "2":
                        keepGoing =Tip.TipCalculator();
                        break;
                    case "3":
                        keepGoing = false;
                        break;
                    default:
                        keepGoing = false;
                        break;
                }
                
            }
            
            Console.WriteLine("\nThank you! \n**********\n THE END\n**********");

        }
       
    }
}
    

