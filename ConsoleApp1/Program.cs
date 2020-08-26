using System;


namespace ROCKPEPARCISSORE
{
    class Program
    {
        static void Main(string[] args)
        {
            String InputPlayer, InputCPU;
            int RandomInt;
            int scorPlayer = 0;
            int scorCPU = 0;
            bool playAgain = true;



            while (playAgain == true) {
               scorPlayer = 0;
                scorCPU = 0;

            while (scorPlayer <3 && scorCPU < 3) { 

            Console.WriteLine("Choose between ROCK,PAPER,SCISSORS:  ");
            InputPlayer = Console.ReadLine();
            InputPlayer = InputPlayer.ToUpper();

            Random rnd = new Random();

            RandomInt = rnd.Next(1, 4);

            switch (RandomInt)
            {
                case 1:
                    InputCPU = "ROCK";
                    Console.WriteLine("Computer choose ROCK");
                    if (InputPlayer == "ROCK")
                    {
                        Console.WriteLine("|..|..DRAW..|..|");
                    }
                    else if (InputPlayer == "PAPER")
                    {
                        Console.WriteLine("|..|..Player Win..|..|");
                        scorPlayer++;
                    }
                    else if (InputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("|..|..CPU Win..|..|");
                        scorCPU++;
                    }
                    break;
                case 2:
                    InputCPU = "PAPER";
                    Console.WriteLine("Computer choose PAPER");
                    if (InputPlayer == "ROCK")
                    {
                        Console.WriteLine("|..|..CPU win..|..|");
                        scorCPU++;

                    }
                    else if (InputPlayer == "PAPER")
                    {
                        Console.WriteLine("|..|..DRAW..|..|");

                    }
                    else if (InputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("|..|..Player win..|..|");
                        scorPlayer++;
                    }
                    break;
                case 3:
                    InputCPU = "SCISSORS";
                    Console.WriteLine("Computer choose SCISSORS");
                    if (InputPlayer == "ROCK")
                    {
                        Console.WriteLine("|..|..Player win..|..|");
                        scorPlayer++;
                    }
                    else if (InputPlayer == "PAPER")
                    {
                        Console.WriteLine("|..|..CPU Win..|..|");
                        scorCPU++;
                    }
                    else if (InputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("|..|.DRAW..|..|");

                    }
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
                    }
                    Console.WriteLine("\n\nSCOREs:\tPLAYER:\t{0}\tCPU:\t{1}", scorPlayer, scorCPU);
            }
            if (scorPlayer == 3)
                {
                    Console.WriteLine("|..|..Player won The match..|..|");
                 
                    }
            else if (scorCPU == 3)
                {
                    Console.WriteLine("|..|..CPU Won the match..|..|");
                       
                    }
                else
                {
                        Console.WriteLine("........DRAW.........");
                }
            

            Console.WriteLine("Do you want to play again : (Y/N)");


                String loop = Console.ReadLine();
                    if(loop == "y")
                    {
                        playAgain = true;
                    Console.Clear();
                    }
                    else if(loop == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {
                    playAgain = false;
                    }
            }



        }
}
}
