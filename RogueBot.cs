using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class RogueBot : RobotProperties
    {

        public RogueBot()
        {
            Console.WriteLine("Enter a RogueBot name...");
            this.robotName = Console.ReadLine();
            batteryLife = 100;
        }
    }
}
