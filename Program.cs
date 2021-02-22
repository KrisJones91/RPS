using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int PlayerCount = 0;
            int CompCount = 0;

            Console.WriteLine(@" 
 __          __  _                            _          _   _            _______ _    _ _    _ _   _ _____  ______ _____  _____   ____  __  __ ______ 
 \ \        / / | |                          | |        | | | |          |__   __| |  | | |  | | \ | |  __ \|  ____|  __ \|  __ \ / __ \|  \/  |  ____|
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | |_| |__   ___     | |  | |__| | |  | |  \| | |  | | |__  | |__| | |  | | |  | | \  / | |__   
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | __| '_ \ / _ \    | |  |  __  | |  | | . ` | |  | |  __| |  _  /| |  | | |  | | |\/| |  __|  
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_| | | |  __/    | |  | |  | | |__| | |\  | |__| | |____| | \ \| |__| | |__| | |  | | |____ 
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \__|_| |_|\___|    |_|  |_|  |_|\____/|_| \_|_____/|______|_|  \_\_____/ \____/|_|  |_|______|
                                                                                                                                                      ");
            while (answer != "NO")
            {
                Console.WriteLine("You have a choice:\n->Rock\n->Paper\n->Scissors");
                string[] choices = new string[3] { "Rock", "Paper", "Scissors" };
                Random rndm = new Random();
                int num = rndm.Next(0, 3);
                Console.WriteLine("Make a choice:");
                string user = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer:" + choices[num]);

                if (user == "Paper" && choices[num] == "Scissors")
                {
                    Console.WriteLine("Computer Wins!! Scissors cut right through Paper!");
                    CompCount += 1;
                }
                else if (user == "Paper" && choices[num] == "Rock")
                {
                    Console.WriteLine("YOU WIN!! COVER THAT ROCK!");
                    PlayerCount += 1;
                }
                else if (user == "Rock" && choices[num] == "Paper")
                {
                    Console.WriteLine("Computer Wins!! Paper covers that Rock!");
                    CompCount += 1;
                }
                else if (user == "Rock" && choices[num] == "Scissors")
                {
                    Console.WriteLine("YOU WIN!! You crushed those Scissors!");
                    PlayerCount += 1;
                }
                else if (user == "Scissors" && choices[num] == "Rock")
                {
                    Console.WriteLine("Computer Wins!! Rock just broke those Scissors in half!");
                    CompCount += 1;
                }
                else if (user == "Scissors" && choices[num] == "Paper")
                {
                    Console.WriteLine("YOU WIN!! Make SNOWFLAKES outta that Paper!!!");
                    PlayerCount += 1;
                }
                else
                {
                    Console.WriteLine("TIE!");
                }

                Console.WriteLine("Want to play again? (Yes or No)");
                answer = Console.ReadLine().ToUpper();
                Console.WriteLine("----NEXT --||-- GAME----");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("User: " + PlayerCount + "------");
            Console.WriteLine("Computer: " + CompCount + "------");
            Console.WriteLine("---------------------------------------");
        }

    }
}
