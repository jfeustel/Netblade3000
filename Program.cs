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
        }

        public static void hall1()
        {
            Console.WriteLine("You enter a hallway.");
            Console.WriteLine("There is a door to your left, right, and straight ahead.");

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
    }
}
