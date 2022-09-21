namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            //Intro
            Console.WriteLine("***********************************************\n Chantell's Simple Calculator & Tip Generator!\n***********************************************\n\n");

            while (keepGoing = true)
            {
                Console.WriteLine("Please select 1 for Simple Calculator or 2 for Tip Generator. ");
                //Ask for 1 or 2
                
                //switch statement

                
                // Simple.TheCalculator();
                
                Tip.TipCalculator();
                
                //Ask To Continue
                keepGoing = GetData.GetContinue();
            }


        }
       
    }
}
    

