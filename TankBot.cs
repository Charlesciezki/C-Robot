using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class TankBot : RobotProperties
    {

        public TankBot()
        {
            Console.WriteLine("Enter a TankBot name...");
            this.robotName = Console.ReadLine();
            batteryLife = 100;
        }
    }
}
