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
                default:
                    Console.WriteLine("Please enter a valid number");
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
                "She begins to wonder if there are any guards around.");
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
                    HallwayRoomTwoMainRoom();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    Console.ReadLine();
                    HallwayOne();
                    break;
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

        private void HallwayRoomTwoMainRoom()
        {
            Console.Clear();
            Console.WriteLine("Anne you made it into the next room. \n" +
                "There doesn't seem to be anyone in here.\n" +
                "You can see that there are two more doors; one to left, and another to the right.\n" +
                "What door would you like to choose?\n" +
                "1. Door to the right.\n" +
                "2. Door to the left.");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    MainRoomTwoDoorOne();
                    break;
                case "2":
                case "two":
                    MainRoomTwoDoorTwo();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    HallwayRoomTwoMainRoom();
                    break;
            }


        }
        private void MainRoomTwoDoorOne()
        {
            Console.Clear();
            Console.WriteLine("Anne finds herself at the foot of a large winding staircase.\n" +
                "The only light shining inside coming from the room she left behind her.\n" +
                "She begins to slowly climb the stairs being careful not to fall.\n" +
                "She comes to a dead end thats been sealed off.  Putting her ear to the wall\n" +
                "she thinks she can hear soft crying.  She turns heading back down the stair knowing this is not the right way.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now back in the room below, she sees the only is to continue on to the door across the room that she has not tried yet; hoping that it opens\n" +
                "1. Try the other door.\n" +
                "2. Try yelling to see who comes.");
            //Console.ReadLine();

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    MainRoomTwoDoorTwo();
                    break;
                case "2":
                case "Two":
                    YellMethod();
                    break;
                default:
                    Console.WriteLine("Please choose a valid number");
                    Console.ReadLine();
                    MainRoomTwoDoorOne();
                    break;
            }
        }

        private void MainRoomTwoDoorTwo()
        {
            Console.Clear();
            Console.WriteLine("Miraculously, the door opens and leads to a winding starcase going down.\n" +
                "Anne approaches the top of the staircase that corkscrews down to the bottom floor of the tower.\n" +
                "As she descends, she can hear a crowd cheering outside in the courtyard. Who could be celebrating such a dire situation?\n" +
                "As she reaches the bottom of the stairs, there is a door to her left, and the double door leading out to the courtyard. Choose a number to explore that room:\n" +
                "1. Door to the left\n" +
                "2. Double doors straight ahead");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    HenryWardrobe();
                    break;
                case "2":
                case "two":
                    Courtyard();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    Console.ReadLine();
                    MainRoomTwoDoorTwo();
                    break;
            }
        }

        private void HenryWardrobe()
        {
            Console.Clear();
            Console.WriteLine("The door swings inward onto a large, lavishly decorated room. Rows upon rows of gaudy outfits hang from large racks.\n" +
                "The cloths are brightly colored, and are for a very large man. Anne realizes she has stumbled into one of Henry's many rooms,\n" +
                "each one displaying his many colorful outfits for any occasion. An idea slowly dawns on Anne. Choose one:\n" +
                "1. No, it's a stupid idea. Best not to get caught in here!\n" +
                "2. Put on one of Henry's outfits in an attempt to disguise yourself.");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    MainRoomTwoDoorTwo();
                    break;
                case "2":
                case "two":
                    Console.Clear();
                    Console.WriteLine("Anne stands on a stool and dons a large tunic. Looking in the mirror, she realizes that this is only going to work\n" +
                        "as long as she's standing on the stool. Henry is much taller than her!\n" +
                        "Suddenly, a flash of movement in the mirror catches her eye, but too late!" +
                        "\n\n\nA French assassin, mistaking her for Henry, has stabbed HER in the back instead!" );
                    YouDied();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    Console.ReadLine();
                    MainRoomTwoDoorTwo();
                    break;
            }
        }

        private void Courtyard()
        {
            Console.Clear();
            Console.WriteLine("As Anne steps out into the bright morning sunlight, she can see a huge crowd forming a large, semicircle around a central object.\n" +
                "As she draws closer, two large men wearing black hods obscuring their faces grab each of her arms. Too late she realizes that she has willingly\n" +
                "walked herself to her own execution!");
            YouDied();
        }

        private void YouDied()
        {
            Console.WriteLine("Henry's scheming has caught up with you.\n\n\n" +
                "YOU ARE DEAD.");
            Console.ReadLine();
            _keepRunning = false;
            //Dead
        }

    }
}
