namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
           Random randomNum = new Random();
            int computerNum = randomNum.Next(1, 101);
            Console.WriteLine("LEVEL 1");
            Console.WriteLine();
            while (true)
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

            Random randomNumLevel2 = new Random();
            int computerNumLevel2 = randomNumLevel2.Next(1, 201);
            Console.WriteLine("LEVEL 2");
            Console.WriteLine();
            while (true)
            {
                
                Console.Write("Guess a number(1-200):");
                int playerInput = int.Parse(Console.ReadLine());

                if (playerInput == computerNumLevel2)
                {
                    break;
                }
                else if (playerInput > computerNumLevel2)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
            }
            Console.WriteLine("You guessed it!");

            Random randomNumLevel3 = new Random();
            int computerNumLevel3 = randomNumLevel2.Next(1, 301);
            Console.WriteLine("LEVEL 3");
            Console.WriteLine();
            while (true)
            {
                
                Console.Write("Guess a number(1-300):");
                int playerInput = int.Parse(Console.ReadLine());

                if (playerInput == computerNumLevel3)
                {
                    break;
                }
                else if (playerInput > computerNumLevel3)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine();
            Console.WriteLine("You win the computer!");
        }
    }
}