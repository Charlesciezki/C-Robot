using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobot
{
    class RobotProperties
    {
        public int batteryLife;
        public string robotName;
        public int HP;
        public List<RobotProperties> OrignalBossBotFleet = new List<RobotProperties>();
        public List<RobotProperties> OrignalRobotFleet = new List<RobotProperties>();
        public static List<RobotProperties> BossBotFleet = new List<RobotProperties>(); 
        public static List<RobotProperties> robotfleet = new List<RobotProperties>();
        public List<RobotProperties> RobotFleetHand =  new List<RobotProperties>();

    }
}
