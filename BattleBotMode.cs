using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class BattleBotMode : AddToFleet
    {
        public void battleBotMode()
        {

            Console.WriteLine("Welcome to battle mode, prepare yourself...");
            for (int i = 0; i <= 2; i++)
            {
                RobotFleetHand.Add(robotfleet[i]);
            }

            for (int i = 0; i <= 2; i++)
            {
                robotfleet.RemoveAt(i);
            }

            Console.WriteLine("Your attack fleet looks like this:");

            foreach (RobotProperties temp in RobotFleetHand)
            {
                Console.WriteLine(temp.robotName);
            }

            Console.WriteLine("Press Enter to start the battle!");
            Console.ReadLine();

            if (RobotFleetHand[0] == TankBot)
                {
                    Console.WriteLine("The " + TankBot.robotName + " does 5 damage!");
                    BossBot.HP -= 5;
                    Console.WriteLine("Boss HP is now at " + BossBot.HP);
                    Console.ReadLine();
                }
                else if (RobotFleetHand[0] == FlyingBot)
                {
                    Console.WriteLine("The " + FlyingBot.robotName + " does 3 damage!");
                    BossBot.HP -= 3;
                    Console.WriteLine("Boss HP is now at " + BossBot.HP);
                    Console.ReadLine();
                }
                else if (RobotFleetHand[0] == Rogue)
                {
                    Console.WriteLine("The " + Rogue.robotName + " does 2 damage!");
                    Console.WriteLine(Rogue.robotName + " snreak attacks for 2 more damage!");
                    BossBot.HP -= 4;
                    Console.WriteLine("Boss HP is now at " + BossBot.HP);
                    Console.ReadLine();
                }

                        if (RobotFleetHand[1] == TankBot)
                        {
                            Console.WriteLine("The " + TankBot.robotName + " does 5 damage!");
                            BossBot.HP -= 5;
                            Console.WriteLine("Boss HP is now at " + BossBot.HP);
                         Console.ReadLine();
                        }
                        else if (RobotFleetHand[1] == FlyingBot)
                        {
                         Console.WriteLine("The " + FlyingBot.robotName + " does 3 damage!");
                        BossBot.HP -= 3;
                        Console.WriteLine("Boss HP is now at " + BossBot.HP);
                        Console.ReadLine();
                    }
                    else if (RobotFleetHand[1] == Rogue)
                    {
                        Console.WriteLine("The " + Rogue.robotName + " does 2 damage!");
                        Console.WriteLine(Rogue.robotName + " snreak attacks for 2 more damage!");
                        BossBot.HP -= 4;
                        Console.WriteLine("Boss HP is now at " + BossBot.HP);
                        Console.ReadLine();
                    }

                            if (RobotFleetHand[2] == TankBot)
                            {
                                Console.WriteLine("The " + TankBot.robotName + " does 5 damage!");
                                BossBot.HP -= 5;
                                Console.WriteLine("Boss HP is now at " + BossBot.HP);
                                Console.ReadLine();
                            }
                            else if (RobotFleetHand[2] == FlyingBot)
                            {
                                Console.WriteLine("The " + FlyingBot.robotName + " does 3 damage!");
                                BossBot.HP -= 3;
                                Console.WriteLine("Boss HP is now at " + BossBot.HP);
                                Console.ReadLine();
                            }
                            else if (RobotFleetHand[2] == Rogue)
                            {
                                Console.WriteLine("The " + Rogue.robotName + " does 2 damage!");
                                Console.WriteLine(Rogue.robotName + " snreak attacks for 2 more damage!");
                                BossBot.HP -= 4;
                                Console.WriteLine("Boss HP is now at " + BossBot.HP);
                                Console.ReadLine();
                        }

            Console.ReadLine();
            Console.WriteLine("The Boss " + BossBot.robotName + " attacks destroying 1" + RobotFleetHand[0]);
            RobotFleetHand.RemoveAt(0);
            RobotFleetHand.Add(robotfleet[0]);
            

            while (RobotFleetHand.Count > 0 || BossBot.HP > 0)
            {
                if (RobotFleetHand[0] == TankBot)
                {
                    Console.WriteLine("The " + TankBot.robotName + " does 5 damage!");
                    BossBot.HP -= 5;
                    Console.WriteLine("Boss HP is now at " + BossBot.HP);
                    Console.ReadLine();
                }
                else if (RobotFleetHand[0] == FlyingBot)
                {
                    Console.WriteLine("The " + FlyingBot.robotName + " does 3 damage!");
                    BossBot.HP -= 3;
                    Console.WriteLine("Boss HP is now at " + BossBot.HP);
                    Console.ReadLine();
                }
                else if (RobotFleetHand[0] == Rogue)
                {
                    Console.WriteLine("The " + Rogue.robotName + " does 2 damage!");
                    Console.WriteLine(Rogue.robotName + " snreak attacks for 2 more damage!");
                    BossBot.HP -= 4;
                    Console.WriteLine("Boss HP is now at " + BossBot.HP);
                    Console.ReadLine();
                }

                        if (RobotFleetHand[1] == TankBot)
                        {
                            Console.WriteLine("The " + TankBot.robotName + " does 5 damage!");
                            BossBot.HP -= 5;
                            Console.WriteLine("Boss HP is now at " + BossBot.HP);
                         Console.ReadLine();
                        }
                        else if (RobotFleetHand[1] == FlyingBot)
                        {
                         Console.WriteLine("The " + FlyingBot.robotName + " does 3 damage!");
                        BossBot.HP -= 3;
                        Console.WriteLine("Boss HP is now at " + BossBot.HP);
                        Console.ReadLine();
                    }
                    else if (RobotFleetHand[1] == Rogue)
                    {
                        Console.WriteLine("The " + Rogue.robotName + " does 2 damage!");
                        Console.WriteLine(Rogue.robotName + " snreak attacks for 2 more damage!");
                        BossBot.HP -= 4;
                        Console.WriteLine("Boss HP is now at " + BossBot.HP);
                        Console.ReadLine();
                    }

                            if (RobotFleetHand[2] == TankBot)
                            {
                                Console.WriteLine("The " + TankBot.robotName + " does 5 damage!");
                                BossBot.HP -= 5;
                                Console.WriteLine("Boss HP is now at " + BossBot.HP);
                                Console.ReadLine();
                            }
                            else if (RobotFleetHand[2] == FlyingBot)
                            {
                                Console.WriteLine("The " + FlyingBot.robotName + " does 3 damage!");
                                BossBot.HP -= 3;
                                Console.WriteLine("Boss HP is now at " + BossBot.HP);
                                Console.ReadLine();
                            }
                            else if (RobotFleetHand[2] == Rogue)
                            {
                                Console.WriteLine("The " + Rogue.robotName + " does 2 damage!");
                                Console.WriteLine(Rogue.robotName + " snreak attacks for 2 more damage!");
                                BossBot.HP -= 4;
                                Console.WriteLine("Boss HP is now at " + BossBot.HP);
                                Console.ReadLine();
                        }


                Console.ReadLine();
                Console.WriteLine("The Boss " + BossBot.robotName + " attacks destroying 1" + RobotFleetHand[0]);
                RobotFleetHand.RemoveAt(0);
                RobotFleetHand.Add(robotfleet[0]);
                robotfleet.RemoveAt(0);
                Console.ReadLine();

                if (BossBot.HP <= 0)
                {
                    Console.WriteLine("Boss wins! Come back again when you want to be serious...");
                    Environment.Exit(0);
                } else if (RobotFleetHand.Count == 0)
                {
                    Console.WriteLine("You army reins supreme over all known universe!");
                    Environment.Exit(0);
                }
                else
                {
                    
                }
            }
        }
    }
}
