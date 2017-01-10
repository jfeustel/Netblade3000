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
            Console.WriteLine("YOU SEE A DOOR");
            Console.WriteLine("ENTER DOOR? Y/N");
            String enter1 = Console.ReadLine();
            if (enter1 == "Y" || enter1 == "y")
            {
                room1();
            }

            else if(enter1 == "N" || enter1 == "n")
            {
                Console.WriteLine("YOU DIE");
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
        }

        public static void room1()
        {
            Console.WriteLine("You see a door");
        }
    }
}
