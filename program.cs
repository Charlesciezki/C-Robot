using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class program : RobotProperties
    {
   
        static void Main(string[] args)
        {
            
            bool runProgram = true;

            while (runProgram)
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.theMainMenu();
            }
        }
    }
}
