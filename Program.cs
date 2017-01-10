﻿using System;
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
            Console.WriteLine("You see a door");
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
                Thread.Sleep(1000);
                hall1();
            }
            else
            {
                Console.WriteLine("A guard sleeps in front of security cam screens.");
                Thread.Sleep(1000);
                Console.WriteLine("You see a radgun clipped to his belt.");
                Thread.Sleep(1000);
                Console.WriteLine("Try to take the radgun? y/n");
                String stealGun = Console.ReadLine();
                if (yesNo(stealGun))
                {
                    Console.WriteLine("You reach to unclip the radgun from the guard's belt.");
                    Thread.Sleep(2000);
                    Console.WriteLine("The guard snorts and turns in his chair");
                    Thread.Sleep(2000);
                    Console.WriteLine("He is still asleep.");
                    Thread.Sleep(2000);
                    Console.WriteLine("You quickly unclip the radgun and slide it into your coat.");
                    Thread.Sleep(2000);
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
            Console.WriteLine("Bad guy, key");
        }

        public void room4()
        {
            Console.WriteLine("Contains locked door.");
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
            Thread.Sleep(1000);
        }
    }
}
