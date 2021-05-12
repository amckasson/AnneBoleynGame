using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnneBoleynEscape
{
    public class ProgramUI
    {
        public bool _keepRunning = true;
        public bool _bedroomKey = false;
        //public bool _isAlive = true;
        //public static Room annesRoom = new Room
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Anne, things with Henry aren't working out.  He's stuck you in the\n" +
                "Tower of London until your execution.  You should probably try to get out of here\n" +
                "while you still can. ");
            Console.ReadLine();
            
            while (_keepRunning)
            { 
            Console.Clear();
            Console.WriteLine("Anne, seriously it's time to get moving choose an action:\n" +
                "1. Go over to the bed.\n" +
                "2. Go over to the door.\n" +
                "3. Yell to see if anyone can hear you.");

            string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        BedMethod();
                        break;
                    case "2":
                    case "two":
                        BedroomDoorMethod();
                        break;
                    case "3":
                    case "three":
                        YellMethod();
                        break;

                }
            }
        }

        private void BedMethod()
        {
            Console.Clear();
            Console.WriteLine("You walk over to the bed.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What do you want to do Anne?\n" +
                "1. Pull back the sheets, and try to get some rest.\n" +
                "2. Check under the pillow.\n" +
                "3. Walk away from the bed.");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    PullSheets();
                    break;
                case "2":
                case "two":
                    LookUnderPillow();
                    break;
                case "3":
                case "three":
                    WalkAwayFromBed();
                    break;
            }
        }

        private void PullSheets()
        {
            Console.Clear();
            Console.WriteLine("Anne lays and bed and thinks about how she got into this mess.\n" +
                "She starts to think that maybe Catherine wasn't that bad and Henry might be crazy.\n" +
                "Anne wakes up to a group of guards in the morning; they take her out to a courtyard\n" +
                "and cut her head off.  The last thought through her mind is about the overratedness of pious dating.  ");
            Console.ReadLine();
            Console.Clear();
            YouDied();
        }
        private void LookUnderPillow()
        {
            Console.Clear();
            Console.WriteLine("Anne pulls the pillow back, and finds a key.\n" +
                "She wonders why someone would put a key here, and picks it up.");
            _bedroomKey = true;
            Console.ReadLine();
        }
        private void WalkAwayFromBed()
        {
            Console.Clear();
            Console.WriteLine("Anne has no time for sleep, besides this bed looks like\n" +
                "its been made for peasants.  Cool pillow though.");
            Console.ReadLine();
        }

        private void BedroomDoorMethod()
        {
            Console.Clear();
            if (_bedroomKey == false)
            {
                Console.WriteLine("The door looks very sturdy.  Anne tries the handle. \n" +
                    "She is not surprised to find that its locked.  Maybe there's a key somewhere.");
            }
            else
            {
                Console.WriteLine("The key from under the pillow fits the lock.  Anne uses it to leave the room.");
                Console.ReadLine();
                //Test
                HallwayOne();
                //test end
            }
            Console.ReadLine();
        }

        private void YellMethod()
        {
            Console.Clear();
            Console.WriteLine("Anne starts yelling like a lunatic, no one seems to react.\n" +
                "She begins to wonder if there are any guards outside");
            Console.ReadLine();
        }
        //Hallway test methods
        private void HallwayOne()
        {
            Console.Clear();
            Console.WriteLine("Anne you made it out of the Room!\n" +
                "The hallway is dark. There seems to be a dead end to the left.\n But there is a door in front of you, and one down hall to the right.\n" +
                "What do you want to do?\n" +
                "1. Try the door in front of me.\n" +
                "2. Try the door to the right. ");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    HallwayRoomOne();
                    break;
                case "2":
                case "two":
                    break;
                //default "Not an option.":
                        //break;
            }
        }

        private void HallwayRoomOne()
        {
            Console.Clear();
            Console.WriteLine("Anne you have stumbled upon the exectioner. \n" +
                "He's readying his axe for your neck. The timing couldn't be worse. \n" +
                "You walk into his practice swing and lose your head!");
            Console.ReadLine();
            Console.Clear();
            YouDied();
        }

        private void YouDied()
        {
            Console.WriteLine("Henry's scheming has caught up with you.\n\n\n" +
                "YOU ARE DEAD.");
            Console.ReadLine();
            _keepRunning = false;
        }
    }
}
