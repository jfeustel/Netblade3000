using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Netblade3000
{
    class Program
    {
        
        public bool hasKey = false;
        public bool hasGun = false;

        static void Main(string[] args)
        {

            Program p = new Program();
            p.welcome();
            Thread.Sleep(2000);
            Console.WriteLine("You pull yourself out of a sleep pod.");
            Thread.Sleep(2000);
            Console.WriteLine("The room is mostly empty, ");
            Thread.Sleep(2000);
            Console.WriteLine("aside from a small terminal displaying vitals for the sleep pod.");
            Thread.Sleep(2000);
            Console.WriteLine("You see a door.");
            Thread.Sleep(1000);
            Console.WriteLine("Enter door? y/n");
            String enter1 = Console.ReadLine();
            if (p.yesNo(enter1))
            {
                Console.WriteLine("");
                p.room1();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("There is no other way to go.");
                Thread.Sleep(1000);
                Console.WriteLine("You begrudgingly open the door...");
                Thread.Sleep(1000);
                p.room1();
            }
            
        }

        /// <summary>
        /// The starting room.
        /// Player only has the option to leave the room.
        /// yes or no (y/n)
        /// </summary>
        public void room1()
        {
            Console.WriteLine("You're in some kind of com research lab.");
            Thread.Sleep(1000);
            Console.WriteLine("The door you came through reads: ");
            Console.WriteLine("AUTHORIZED PERSONNEL ONLY");
            Thread.Sleep(1000);
            Console.WriteLine("The door terminal appears to have been disabled. The screen is black.");
            Thread.Sleep(1000);
            Console.WriteLine("You see crates of nutrition capsules stacked along the walls.");
            Thread.Sleep(1000);
            Console.WriteLine("There is only one door leading out.");
            Thread.Sleep(1000);
            Console.WriteLine("Enter door? y/n");
            String enter2 = Console.ReadLine();
            if (yesNo(enter2))
            {
                Console.WriteLine("");
                hall1();
            }
            else
            {
                Console.WriteLine("There is no other way to go.");
                Thread.Sleep(1000);
                Console.WriteLine("You begrudgingly open the door...");
                Console.WriteLine("");
                Thread.Sleep(1000);
                hall1();
            }
        }

        /// <summary>
        /// The hallway.
        /// Player has options to go left, right, or straight.
        /// </summary>
        public void hall1()
        {
            Console.WriteLine("You enter a hallway.");
            Thread.Sleep(1000);
            Console.WriteLine("The hallway walls and floor are blindingly white.");
            Thread.Sleep(1000);
            Console.WriteLine("There is a door to your left, right, and straight ahead is a glowing blue door.");
            Thread.Sleep(1000);
            Console.WriteLine("Which way? l/r/s.");
            String enter3 = Console.ReadLine();
            if (leftRightStraight(enter3) == 'l')
            {
                Console.WriteLine("");
                room2();
            }
            if (leftRightStraight(enter3) == 'r')
            {
                Console.WriteLine("");
                room3();
            }
            if (leftRightStraight(enter3) == 's')
            {
                Console.WriteLine("");
                room4();
            }
            if (leftRightStraight(enter3) == 'n')
            {
                Console.WriteLine("INVALID ENTRY.");
                Console.WriteLine("");
                hall1();                   
            }
        }

        /// <summary>
        /// The guard encounter.
        /// Player has the option to steal a gun, which will trigger the "hasGun" global.
        /// </summary>
        public void room2()
        {
            if (hasGun == true)
            {
                Console.WriteLine("The guard is still asleep.");
                Thread.Sleep(1000);
                Console.WriteLine("You shouldn't test your luck.");
                Console.WriteLine("");
                Thread.Sleep(1000);
                hall1();
            }
            else
            {
                Console.WriteLine("A pasty white guard sleeps in front of security cam screens.");
                Thread.Sleep(2000);
                Console.WriteLine("You see a radgun clipped to his belt.");
                Thread.Sleep(2000);
                Console.WriteLine("Try to take the radgun? y/n");
                String stealGun = Console.ReadLine();
                if (yesNo(stealGun))
                {
                    Console.WriteLine("You reach to unclip the radgun from the guard's belt.");
                    Thread.Sleep(2000);
                    Console.WriteLine("The guard snorts and turns in his chair.");
                    Thread.Sleep(2000);
                    Console.WriteLine("He is still asleep.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You quickly unclip the radgun and slide it into your coat.");
                    Thread.Sleep(3000);
                    Console.WriteLine("");
                    Console.WriteLine("***********************************");
                    Console.WriteLine("*** RECEIVED ITEM - RADGUN V3.5 ***");
                    Console.WriteLine("***********************************");
                    Console.WriteLine("");
                    hasGun = true;
                    Thread.Sleep(2000);
                    Console.WriteLine("Leave room? y/n");
                    String leaveRoom = Console.ReadLine();
                    if (yesNo(leaveRoom))
                    {
                        hall1();
                    }
                    else
                    {
                        Console.WriteLine("You should leave before he wakes up...");
                        Thread.Sleep(2000);
                        hall1();
                    }
                }
                else
                {
                    Console.WriteLine("You slowly back out of the room...");
                    Thread.Sleep(2000);
                    hall1();
                }
            }

        }

        public void room3()
        {
            if (hasKey)
            {
                Console.WriteLine("There is nothing else worthwhile in this room.");
                Console.WriteLine("");
                hall1();
            }
            else
            {
                Console.WriteLine("You enter a room alive with the persistent whirring of computer fans");
                Thread.Sleep(2000);
                Console.WriteLine("A technician sits at a desk facing three glowing com screens.");
                Thread.Sleep(2000);
                Console.WriteLine("It's hard to tell if she moved when you entered,");
                Thread.Sleep(2000);
                Console.WriteLine("as her hair is as black as her canvas motorbike jacket.");
                Thread.Sleep(2000);
                Console.WriteLine("You see an implant com protruding from the bottom of her skull");
                Thread.Sleep(3000);
                if (hasGun)
                {
                    Console.WriteLine("Shoot her?");
                    String shoot = Console.ReadLine();
                    if (yesNo(shoot))
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("The high pitched whine of the radgun cuts through the dull fan noise.");
                        Thread.Sleep(1000);
                        Console.WriteLine("The technician's face crashes to her desk.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Her implant com cable dangles lifelessly from her still head");
                        Thread.Sleep(1000);
                        Console.WriteLine("You search her pockets and find a key.");
                        Console.WriteLine("");
                        Thread.Sleep(1000);
                        Console.WriteLine("***********************************");
                        Console.WriteLine("**** RECEIVED ITEM - BLUE KEY1 ****");
                        Console.WriteLine("***********************************");
                        Console.WriteLine("");
                        hasKey = true;
                        Thread.Sleep(1000);
                        Console.WriteLine("You should leave...");
                        Console.WriteLine("");
                        Thread.Sleep(1000);
                        hall1();
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("She swivels around to investigate your presence");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"You're...\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"They said you were alive back there...\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"I mean, I saw your vitals myself...\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"Well whoever got you out of that simu-freeze sure picked a good time\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"I know this isn't a coincidence.\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("She shoots an uneasy glance to the door, and unplugs her implant com");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"Look, I've always supported your cause.\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"You're going to get yourself killed, but it's at least noble.\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("\"Here, take this key. You're probably already too late, but good luck.\"");
                        Thread.Sleep(2000);
                        Console.WriteLine("***********************************");
                        Console.WriteLine("**** RECEIVED ITEM - BLUE KEY1 ****");
                        Console.WriteLine("***********************************");
                        hasKey = true;
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        hall1();
                    }
                }                
                else
                {
                    Console.WriteLine("You wish you had a radgun right about now...");
                    Console.WriteLine("");
                    Thread.Sleep(2000);
                    Console.WriteLine("She swivels around to investigate your presence");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"You're...\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"They said you were alive back there...\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"I mean, I saw your vitals myself...\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"Well whoever got you out of that simu-freeze sure picked a good time\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"I know this isn't a coincidence.\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("She shoots an uneasy glance to the door, and unplugs her implant com");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"Look, I've always supported your cause.\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"You're going to get yourself killed, but it's at least noble.\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("\"Here, take this key. You're probably already too late, but good luck.\"");
                    Thread.Sleep(2000);
                    Console.WriteLine("***********************************");
                    Console.WriteLine("**** RECEIVED ITEM - BLUE KEY1 ****");
                    Console.WriteLine("***********************************");
                    hasKey = true;
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    hall1();
                }
            }
        }

        public void room4()
        {
            Console.WriteLine("You open the glowing blue door.");
            Thread.Sleep(2000);
            Console.WriteLine("You see the polished black steel surface of a Net3000 terminal.");
            Thread.Sleep(2000);
            Console.WriteLine("A sharp pain shoots through your com implant.");
            Thread.Sleep(2000);
            Console.WriteLine("You reach back to feel an unfamilir configuration on your artificial orifice.");
            Thread.Sleep(2000);
            Console.WriteLine("\"Someone has been inside my head...\"");
            Thread.Sleep(2000);
            Console.WriteLine("You look back to the Net3000 terminal.");
            Thread.Sleep(2000);
            Console.WriteLine("Enter the Net?");
            Thread.Sleep(2000);
            String enterNet = Console.ReadLine();
            if (yesNo(enterNet))
            {
                if (hasKey)
                {
                    Console.WriteLine("You insert the blue key into the terminal.");
                    Thread.Sleep(2000);
                    Console.WriteLine("The com cable doesn't fit in your implant like it should...");
                    Thread.Sleep(2000);
                    Console.WriteLine("You fight with the cable til a *click* assures you that it's good enough.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You flip the terminal switch.");
                    Thread.Sleep(2000);
                    Console.WriteLine("The world goes black.");
                    Thread.Sleep(2000);
                    endGame();
                }
                else
                {
                    Console.WriteLine("This terminal requires a key.");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Maybe you missed something...");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    hall1();
                }
                
            }
            else
            {
                hall1();
            }
        }

        public bool yesNo(String inString)
            {
            String yn = inString;
            if (yn == "Y" || yn == "y" || yn == "yes" || yn == "Yes")
            {
                return true;
            }

            else if (yn == "N" || yn == "n" || yn == "no" || yn == "No")
            {
                return false;
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
            return false;
        }

        public char leftRightStraight(String inString)
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

        public void welcome()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("******************************** NETBLADE 3000 ********************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.Write("W");
            Thread.Sleep(200);
            Console.Write("E");
            Thread.Sleep(200);
            Console.Write("L");
            Thread.Sleep(200);
            Console.Write("C");
            Thread.Sleep(200);
            Console.Write("O");
            Thread.Sleep(200);
            Console.Write("M");
            Thread.Sleep(200);
            Console.Write("E");
            Thread.Sleep(200);
            Console.Write(" ");
            Thread.Sleep(200);
            Console.Write("U");
            Thread.Sleep(200);
            Console.Write("S");
            Thread.Sleep(200);
            Console.Write("E");
            Thread.Sleep(200);
            Console.Write("R");
            Thread.Sleep(200);
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(500);
        }

        public void endGame()
        {
            Console.WriteLine("WHRRRRRRRRRRRRRRRRRRRRRRRR");
            Thread.Sleep(2000);
            Console.WriteLine("BEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEP");
            Thread.Sleep(2000);
            Console.WriteLine("...");

        }
    }
}


