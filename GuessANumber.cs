namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
           Random randomNum = new Random();
            int computerNum = randomNum.Next(1, 101);
            while(true)
            {
                Console.Write("Guess a number(1-100):");
                int playerInput = int.Parse(Console.ReadLine());

                if(playerInput == computerNum) 
                {
                    break;
                }
                else if (playerInput> computerNum) 
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
            }
            Console.WriteLine("You guessed it!");
        }
    }
}