﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnneBoleynEscape
{
    public class Room
    {
        public bool _isRunning = true;
        public void AlternateHistory()
        {
            Console.Clear();
            Console.WriteLine("A terrible sound, like thunder, booms inside of the room next to you. Bright lights flash through the cracks\n" +
                "between the door and the wall.\n\n" +
                "As you stand there, stunned, the door is slammed off of its hinges from the inside.\n\n" +
                "You see a giant of a man standing before you, wearing one of Henry's outfits. He's holding one of Henry's swords.\n" +
                "As he looks down at you, you think you see his eyes glint red... just for a moment. But... that's not posible... is it?\n" +
                "\"Come with me if you want to live,\" he says in a deep voice. Your cultured ear picks up an Austrian accent? How can this be?");

            Console.ReadLine();
            YouAreQueen();
            
        }

        private void YouAreQueen()
        {
            Console.Clear();
            Console.WriteLine("Your new companion kicks open the double doors into the courtyard. He silently chops down all of Henry's guards,\n" +
                "and even Henry himself! The crowd is hushed and as your guardian stands behind you, they bow down.\n" +
                "\"All hail Queen Anne!\" they cheer. And why not? You were always better than Henry ever was on the throne.\n\n\n\n" +
                "Congratulations, you have survived and changed history!");

            _isRunning = false;
        }
    }
}
