using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnneBoleynEscape
{
    public class ProgramUI
    {
        private AlternateHistoryClass _arnold = new AlternateHistoryClass();
        public bool _keepRunning = true;
        public bool _bedroomKey = false;
        public bool _hiddenlever = false;
        //public bool _isAlive = true;
        //public static Room annesRoom = new Room
        public void Run()
        {
            TitlePage();

            Console.Clear();
            Console.WriteLine("Anne, things with Henry aren't working out.  He's stuck you in the\n" +
                "Tower of London until your execution.  You should probably try to get out of here\n" +
                "while you still can.\n\n ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            while (_keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Anne, seriously it's time to get moving, choose an action:\n\n" +
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
            Console.WriteLine("You walk over to the bed.\n\n" +
                "While not as comfortable as those in the royal quarters, it's better than the\n straw-filled mattresses used by the commoners.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What do you want to do Anne?\n\n Choose a number:\n\n" +
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
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
            YouDied();
        }
        private void LookUnderPillow()
        {
            Console.Clear();
            Console.WriteLine("Anne pulls the pillow back, and finds a key.\n" +
                "She wonders why someone would put a key here, and picks it up.\n");
            _bedroomKey = true;
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
        private void WalkAwayFromBed()
        {
            Console.Clear();
            Console.WriteLine("Anne has no time for sleep, besides this bed looks like\n" +
                "its been made for peasants.  Cool pillow though.\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private void BedroomDoorMethod()
        {
            Console.Clear();
            if (_bedroomKey == false)
            {
                Console.WriteLine("The door looks very sturdy.  Anne tries the handle. \n" +
                    "She is not surprised to find that its locked.  Maybe there's a key somewhere.\n\n");
                Console.WriteLine("Press any key to continue...");
            }
            else
            {
                Console.WriteLine("The key from under the pillow fits the lock.  Anne uses it to leave the room.\n\n");
                Console.WriteLine("Press any key to continue...");
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
                "She begins to wonder if there are any guards around.\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
        //Hallway test methods
        private void HallwayOne()
        {
            Console.Clear();
            Console.WriteLine("Anne makes it out of the Room!\n" +
                "The hallway is dark. There seems to be a dead end to the left.\n But there is a door in front of you, and one down the hall to the right.\n\n" +
                "What do you want to do? Choose a number:\n\n" +
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

        private void HallwayRoomTwoMainRoomVTwo()
        {
            Console.Clear();
            Console.WriteLine("Anne quickly makes her way to the door where the mechanical\n" +
                "sounds lead. Hoping against all odds that she will make it out of this nightmare.\n\n" +
                "Press any key to continue..."
                );
            Console.ReadLine();
            MainRoomTwoDoorTwo();
        }

        private void HallwayRoomTwoMainRoom()
        {
            Console.Clear();
            Console.WriteLine("Anne you made it into the next room. \n" +
                "There doesn't seem to be anyone in here.\n" +
                "The room is lined with antique suits of armour, rusted and forgotten.\n Anne" +
                " can see that there are two more doors; one to left, and another to the right.\n\n" +
                "What door would you like to try? Choose a number:\n\n" +
                "1. Door to the right.\n" +
                "2. Door to the left.\n" +
                "3. Look around the room.");

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
                case "3":
                case "three":
                    SuitArmour();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    HallwayRoomTwoMainRoom();
                    break;
            }


        }
        //start
        private void MainRoomTwoDoorOne()
        {
            Console.Clear();
            Console.WriteLine("Anne finds herself at the foot of a large winding staircase.\n" +
                "The only light shining inside coming from the room she left behind her.\n" +
                "She begins to slowly climb the stairs being careful not to fall.\n" +
                "She comes to a dead end thats been sealed off.  Putting her ear to the wall\n" +
                "she thinks she can hear soft crying. \"Nope..\"  She thinks as she turns\n" +
                "heading back down the stair knowing this is not the right way.\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now back in the room below, she sees the only way to continue on is\nthrough door across the room that she has not tried yet; she PRAYS that it opens.\n\n" +
                "Choose a number:\n\n" +
                "1. Try the other door.\n" +
                "2. Try looking behind the armour."
                );
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
                    SuitArmour();
                    break;
                default:
                    Console.WriteLine("Please choose a valid number");
                    Console.ReadLine();
                    MainRoomTwoDoorOne();
                    break;
            }
        }

        private void SuitArmour()
        {
            Console.Clear();
            Console.WriteLine("Anne wonders if there could be something behind the suits of antique\n" +
                "armour. She begins checking hoping to find something that will help her.\n" +
                "Just as she begining to give up all hope she notices an armour set a bit further\n" +
                "from the wall than the others. Looking behind she spots a lever.\n\n" +
                "She pulls and hears a series of gears clicking that lead to the door.\n\n" +
                "Press any key to continue...");
            Console.ReadLine();
            _hiddenlever = true;
            HallwayRoomTwoMainRoomVTwo();
        }
        private void MainRoomTwoDoorTwo()
        {
            Console.Clear();
            if (_hiddenlever == true)
            {
                Console.WriteLine("Miraculously, the door opens and leads to a winding starcase going down.\n" +
                    "Anne approaches the top of the staircase that corkscrews down to the bottom floor of the tower.\n" +
                    "As she descends, she can hear a crowd cheering outside in the courtyard. Who could be celebrating such a dire situation?\n" +
                    "As she reaches the bottom of the stairs, there is a door to her left, and the double door leading out to the courtyard.\n\n" +
                    " Choose a number to explore that room:\n\n" +
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
            else
            {
                Console.WriteLine("This door wont budge.  There has to be a way to open it.");
                Console.ReadLine();
                HallwayRoomTwoMainRoom();
            }
        }
        //end
        private void HenryWardrobe()
        {
            Console.Clear();
            Console.WriteLine("The door swings inward onto a large, lavishly decorated room. Rows upon rows of gaudy outfits hang from large racks.\n" +
                "The cloths are brightly colored, and are for a very large man. Anne realizes she has stumbled into one of Henry's many rooms,\n" +
                "each one displaying his many colorful outfits for any occasion. An idea slowly dawns on Anne.\n\n Choose a number:\n\n" +
                "1. No, it's a stupid idea. Best not to get caught in here!\n" +
                "2. Put on one of Henry's outfits in an attempt to disguise yourself.");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    Corridor();
                    break;
                case "2":
                case "two":
                    Console.Clear();
                    Console.WriteLine("Anne stands on a stool and dons a large tunic. Looking in the mirror, she realizes that this is only going to work\n" +
                        "as long as she's standing on the stool. Henry is much taller than her!\n" +
                        "Suddenly, a flash of movement in the mirror catches her eye, but too late!" +
                        "\n\n\nA French assassin, mistaking her for Henry, has stabbed HER in the back instead!");
                    Console.ReadLine();
                    YouDied();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    Console.ReadLine();
                    MainRoomTwoDoorTwo();
                    break;
            }
        }

        private void Corridor()
        {
            Console.Clear();
            Console.WriteLine("Back at the bottom of the stairs, your only option now is to go through the double doors, out to the noisy courtyard.\n" +
                "But... you are starting to suspect something isn't right here. Is this some sort of sick surprise from Henry?\n" +
                "Your birthday is coming up... but he's also not been very pleased with you lately...\n\n" +
                "Choose a number:\n\n" +
                "1. Proceed through the double doors into the courtyard, ready for your big party!\n" +
                "2. Pray for guidance.");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1":
                case "one":
                    Courtyard();
                    break;
                case "2":
                case "two":
                    _arnold.AlternateHistory();
                    _keepRunning = false;
                    break;
                default:
                    Console.WriteLine("You hesistate at the turning point!");
                    YouDied();
                    break;
            }
        }

        private void Courtyard()
        {
            Console.Clear();
            Console.WriteLine("As Anne steps out into the bright morning sunlight, she can see a huge crowd forming a large, semicircle around a central object.\n" +
                "As she draws closer, two large men wearing black hoods obscuring their faces grab each of her arms. Too late she realizes that she has willingly\n" +
                "walked herself to her own execution!\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            YouDied();
        }
        private void TitlePage()
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------");
            Console.Clear();
            Console.WriteLine("In the year 1856, Henry VIII, King of England, became displeased with his wife\n" +
                "Anne Boleyn. She was locked in the tower of London until her execution on May 19, 1536.\n\n\n" +
                "In this game, you will play as Anne Boleyn, and your goal is to escape the tower without being killed.");
            Console.Beep(400, 400);
            Console.Beep(460, 900);
            Console.Beep(500, 400);
            Console.Beep(520, 900);
            Console.Beep(560, 300);
            Console.Beep(520, 300);
            Console.Beep(470, 900);
            Console.Beep(400, 400);
            Console.Beep(320, 1100);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private void YouDied()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Henry's scheming has caught up with you.\n\n\n" +
                "YOU ARE DEAD.\n");
            Console.Beep(700, 700);
            Console.Beep(500, 2000);

            Console.WriteLine("Would you like to try again? Y/N");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "y":
                    TitlePage();
                    break;
                case "n":
                    _keepRunning = false;
                    break;
                default:
                    _keepRunning = false;
                    break;
            }
        }
    }
}
