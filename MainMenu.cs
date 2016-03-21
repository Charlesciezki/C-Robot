using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class MainMenu : RobotProperties
    {
        

        public void theMainMenu()
        {
            
            bool switchCase = true;
            while (switchCase)
            {
            Console.WriteLine("Welcome to the robot main menu!");
            Console.WriteLine("Enter 1 for Boss and Tank/Flying/Rogue robot army...");
            Console.WriteLine("Enter 2 to start the battle of a life time...");
            Console.WriteLine("Enter 3 if you're a jerk and want to quit.");
            Console.WriteLine("Enter anything else for a nice suprise! *Dont do it*");

            int menuChoice = Convert.ToInt32(Console.ReadLine());
                
                switch (menuChoice)
                {
                    case 1:

                        AddToFleet bossfleet = new AddToFleet();
                        BossBotFleet = bossfleet.BossBotAddToFleet();

                        AddToFleet robotFleet = new AddToFleet();
                        robotfleet = robotFleet.CreateRobotArmy();                        
                        break;

                    case 2:
                       BattleBotMode battleBot = new BattleBotMode();
                       battleBot.battleBotMode();
                        break;

                    case 3:
                        Console.WriteLine("Ya jerk....");

                        Environment.Exit(0);
                        break;

                    default:
                        for (int i = 0; i < 1000000; i++)
                        {
                            Console.WriteLine("You broke it, you've broken it!!! And also YOU SMELL LIKE DOG BUNS");
                        }
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}
