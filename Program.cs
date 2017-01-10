using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netblade3000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME USER");
            Console.WriteLine("You see a door.");
            Console.WriteLine("Enter door? y/n");
            String enter1 = Console.ReadLine();
            if (yesNo(enter1))
            {
                room1();
            }
            else
            {
                Console.WriteLine("There is no other way to go.");
                Console.WriteLine("Enter door? y/n");
                if (yesNo(enter1))
                {
                    room1();
                }
            }
            
        }

        public static void room1()
        {
            Console.WriteLine("You see a door");
            Console.WriteLine("Enter door? y/n");
            String enter2 = Console.ReadLine();
            if (yesNo(enter2))
            {
                hall1();
            }
            else
            {
                Console.WriteLine("There is no other way to go.");
                Console.WriteLine("Enter door? y/n");
                if (yesNo(enter2))
                {
                    hall1();
                }
            }
        }

        public static void hall1()
        {
            Console.WriteLine("You enter a hallway.");
            Console.WriteLine("There is a door to your left, right, and straight ahead is a glowing blue door.");
            Console.WriteLine("Which way? l/r/s.");
            String enter3 = Console.ReadLine();
            if (leftRightStraight(enter3) == 'l')
            {

            }

        }

        public static void room2()
        {
            Console.WriteLine("Bad guy, key.");
        }

        public static void room3()
        {
            Console.WriteLine("Bad guy, treasure");
        }

        public static void room4()
        {
            Console.WriteLine("You see a door");
        }

        public static bool yesNo(String inString)
            {
            String yn = inString;
            if (yn == "Y" || yn == "y")
            {
                return true;
            }

            else if (yn == "N" || yn == "n")
            {
                Console.WriteLine("YOU DIE");
                return false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
            return false;
        }

        public static char leftRightStraight(String inString)
        {
            String lrs = inString;
            if (lrs == "l" || lrs == "L" || lrs == "left" || lrs == "Left")
            {
                return 'l';
            }
            else if ((lrs == "r" || lrs == "R") || lrs == "right" || lrs == "Right")
            {
                return 'r';
            }
            else if ((lrs == "s" || lrs == "S" || lrs == "straight") || lrs == "Straight")
            {
                return 's';
            }
            else
            {
                return 'n';
            }
        }
    }
}
