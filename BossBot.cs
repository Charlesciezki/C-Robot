using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class BossBot : RobotProperties
    {
       
        public BossBot()
        {
            HP = 100;          
            Console.WriteLine("Enter a BossBot name...");
            this.robotName = Console.ReadLine();
        }
    }
}
