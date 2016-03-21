using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class AddToFleet 
    {
        public List<RobotProperties> OrignalBossBotFleet = new List<RobotProperties>();
        public List<RobotProperties> OrignalRobotFleet = new List<RobotProperties>();
        public static List<RobotProperties> BossBotFleet = new List<RobotProperties>();
        public static List<RobotProperties> robotfleet = new List<RobotProperties>();
        public List<RobotProperties> RobotFleetHand = new List<RobotProperties>();
        public TankBot TankBot = new TankBot();
        public FlyingBot FlyingBot = new FlyingBot();
        public RogueBot Rogue = new RogueBot();
        public BossBot BossBot = new BossBot();
    

    public List<RobotProperties> BossBotAddToFleet()
        {
            OrignalBossBotFleet.Add(BossBot);

            return OrignalBossBotFleet;
        }

        public List<RobotProperties> CreateRobotArmy()
        {
            Random random = new Random();

            Console.WriteLine("Select the amount of robots in your army!");
            Console.WriteLine("As an added twist they're random, so you will not get to choose how many specific tank, healing, and flying bots you get");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < userChoice; i++)
            {
                int randomNumber = random.Next(1, 4);

                if (randomNumber == 1)

                {

                    OrignalRobotFleet.Add(TankBot);

                } else if (randomNumber == 2)

                {
                    OrignalRobotFleet.Add(FlyingBot);

                } else if (randomNumber == 3)
                {
                    OrignalRobotFleet.Add(Rogue);

                }
            }
            foreach (RobotProperties temp in OrignalRobotFleet)
            {
                Console.WriteLine(temp.robotName);
            }
            return OrignalRobotFleet;

        }
    }
}
