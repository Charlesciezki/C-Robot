using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class FlyingBot : RobotProperties
    {

        public FlyingBot()
        {
            Console.WriteLine("Enter a FlyBot name...");
            this.robotName = Console.ReadLine();
            batteryLife = 100;
        }
    }
}
