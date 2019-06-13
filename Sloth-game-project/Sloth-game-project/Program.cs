using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sloth_game_project
{
    public struct Player
    {
        public string inventory;
        public string description;
    }

    class Program
    {
        public static int location = 1;
        public static Player[] sloth = new Player[10];
        public static string handhole, entered, answer1, answer2 = "", answer5;

        static void LevelOne()
        {          
            Console.Clear();
            Console.WriteLine("RULES/INTRODUCTION");
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("The rules are simple, in each room there will be multiple options for you to interact with the environment.");
            Thread.Sleep(500);
            Console.WriteLine("There will also be the option to move into a different room either North, South, East and West.");
            Thread.Sleep(500);
            Console.WriteLine("You will have to navigate these rooms and explore the options that you feel best fit your current situation.");
            Thread.Sleep(500);
            Console.WriteLine("Be careful however, as some options will have different outcomes to certain situations, which will affect your story,");
            Thread.Sleep(500);
            Console.WriteLine("Try to explore as many options as you can to uncover the story of SLOTHSCAPE");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You're an exotic sloth, escaping dangerous poachers that want to sell you as a pet!");
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("You make a narrow escape in the sewers, but you reach a few rooms that are seemingly a dead end.");
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("You must escape the sewers and the poachers, and get to the forest so you can have a life!");
            Thread.Sleep(500);
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
            Console.Clear();

            //ROOM 1

            Console.WriteLine("You are in the sewers, it is dark and you notice an unnatural green fog that is difficult to see through.");
            Console.WriteLine("The fog lowers your visability.");

            do
            {
                Console.WriteLine("You manage to lift the sewer drain open, and you drop in. You manage to close it off before the poachers catch up.");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("You slide down the ladder into a brigthly lit room.");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Your eyes slowly adjusts to the bright ceiling lights dangling in front of your eyes.");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("You notice that there is only one exit heading South, through a small sewer grate.");
                Console.WriteLine();
                Console.WriteLine("What do you do...?");
                Console.WriteLine();
                Console.WriteLine("1 - Head South");
                Console.WriteLine("2 - Head West");
                Console.WriteLine("3 - Head North");
                Console.WriteLine("4 - Head East");

                Console.WriteLine();
                answer1 = Console.ReadLine();
                Console.Clear();

                switch (answer1)
                {
                    case "1":                        
                        Console.WriteLine("You head South through the sewer grate... you manage to JUST fit through.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        location = 2;
                        break;
                    case "2":
                        if (entered == "")
                        {
                            do
                            {
                                Console.WriteLine("You look right.. you see a hole in the moss-covered wall, the size of your hand..");
                                Thread.Sleep(500);
                                Console.WriteLine();
                                Console.WriteLine("Stick your hand in the wall?");
                                Console.WriteLine();
                                Console.WriteLine("1 - Do it");
                                Console.WriteLine("2 - Do not");
                                Console.WriteLine();
                                handhole = Console.ReadLine();
                                Console.Clear();

                                if (handhole == "1")
                                {
                                    sloth[0].inventory = "RUSTY KNIFE";
                                    sloth[0].description = "- Unknown inscriptions are on the blade, it easily scratches stone regardless of the rust.";

                                    entered = "yes";
                                    Console.WriteLine("You decide to enter your claws into the hole and...");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.WriteLine("You found a rusty knife with some unknown markings on the blade.");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.WriteLine("Might be useful for later.");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.WriteLine("[ACQUIRED RUSTY KNIFE]");
                                    Console.WriteLine();
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                }
                                else if (handhole == "2")
                                {
                                    Console.WriteLine("You decide that it's in your best interests to not stick your hand in random places.");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("I do not understand your input.");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                }

                            } while ((handhole != "1") && (handhole != "2"));
                        }
                        else if (entered == "yes")
                        {
                            Console.WriteLine("You have already looked into the hole.");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("You decide that it is a waste of time to look in there again.");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("I do not understand your input.");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Going backwards doesn't seem like a good idea right now..");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("You look left, there is only a wall covered with moss.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case "map":
                        Map(location);
                        break;
                    case "inventory":
                        storage(ref answer1, sloth);
                        break;
                    default:
                        Console.WriteLine("I do not understand your input.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                }

            } while (answer1 != "1");

            LevelTwo();           
        }

        public static void LevelTwo()
        {
            string answer2;

            //ROOM 2//
            do
            {
                Console.WriteLine("It's hard to make out what's in the room, but you hear a soft snore.. almost like purring.");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Once your eyes adjust to the light, your heart sinks as you notice a Leopard, sleeping on a pile of rubbish in before your eyes!");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Something else catches your eye as you're looking around.. you spot a key hanging off a pipe right above the Leopard.");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("You spot 2 possible exits, one behind the Leopard, and another one to your right that seems to go deeper into the sewer.");
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("What do you do...?");
                Console.WriteLine();
                Console.WriteLine("1 - Attempt to sneak behind the Leopard and continue North.");
                Console.WriteLine("2 - Sneak around the Leopard and head East.");
                Console.WriteLine("3 - Try to grab the key that is right above the sleeping Leopard.");
                Console.WriteLine("4 - Head back South.");
                Console.WriteLine();
                answer2 = Console.ReadLine();
                Console.Clear();

                switch (answer2)
                {
                    case "3":
                        Console.WriteLine("There is a clear path South, so you decide that it is best to leave the Leopard alone");
                        Thread.Sleep(3000);
                        Console.Clear();
                        location = 3;
                        break;
                    case "2":
                        Console.WriteLine("You look down at the ground and notice that it is covered in Cans, Glass and all kinds of rubbish, which will make it impossible to sneak past");
                        Console.WriteLine("You realise that it would not be worth trying to sneak past");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case "1":
                        if ((sloth[0].inventory == "RUSTY KNIFE") && (answer2 == "3"))
                        {
                            sloth[1].inventory = "UNKNOWN KEY";
                            sloth[1].description = "- You don't know what door this goes into, just try to use for as many locked doors as you can find.";

                            Console.WriteLine("You decide to try and grab the key hanging below the Leopard");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("As you walk over the glass and cans on the ground, it WAKES THE LEOPARD UP FROM ITS SLUMBER!!");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("With your quick thinking, you take out the RUSTY KNIFE from earlier and and hold it infront of the charging Leopard!");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("The knife pierces the Leopard with great force, killing it quickly!");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("'phew', you sigh as you reach for the un-guarded key.");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("This key might be useful later.");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("[ACQUIRED UNKNOWN KEY]");
                            Console.WriteLine();
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("You decide to try and grab the key hanging below the Leopard");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("As you walk over the glass and cans on the ground it awakens the Leopard from its deep slumber!!");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine("With no form of protection, you are left unprotected as the Leopard charges for you!");
                            Thread.Sleep(500);
                            Console.WriteLine("The Leopard digs its teeth into your neck, killing you instantly.");
                            Thread.Sleep(800);
                            Console.WriteLine();
                            Console.WriteLine("[GAME OVER]");
                            Thread.Sleep(1500);
                            Console.Clear();
                        }
                        break;
                    case "4":
                        LevelOne();
                        break;
                    case "inventory":
                        storage(ref answer2, sloth);
                        break;
                    case "map":
                        Map(location);
                        break;
                    default:
                        Console.WriteLine("I do not understand your input.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            } while ((answer2 != "1") && (answer2 != "2") && (answer2 != "3"));

            LevelThree();
        }

        public static void LevelThree()
        {
            //ROOM 3 SOUTH//
            string riddleAnswer = "dark";

            if (answer2 == "3")
            {
                do
                {
                    Console.WriteLine("You manage to sneak past the Leopard and you walk into the room, cautious because you were scared of another beast lurking in your path.");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Console.WriteLine("You peek into the room and see a floating apparition, which you can make out as something familiar.");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Console.WriteLine("As you study it more, you realise that it is a SLOTH! but not a living one... a GHOST SLOTH!");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Console.WriteLine("It turns around and looks at you with its deathly eyes. It opens its mouth and with a deep voice says...");
                    Thread.Sleep(500);
                    Console.WriteLine();
                    Console.WriteLine("'In order to continue on your journey, you must first complete a riddle.'");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("Dazed and confused, you comply with the ghost as you realise there is no other way,");
                    Thread.Sleep(500);
                    Console.WriteLine();

                    int riddleAtt = 0;
                    string userRiddleAns = "";

                    do
                    {
                        Console.WriteLine("'It cannot be seen, it cannot be felt'");
                        Console.WriteLine("'It cannot be heard, it cannot be smelt'");
                        Console.WriteLine();
                        Console.WriteLine("'It lies behind the stars and under the hills'");
                        Console.WriteLine("'and empty holes it fills'");
                        Console.WriteLine();
                        Console.WriteLine("'It comes out first and follows after'");
                        Console.WriteLine("'ends life, kills laughter'");
                        Console.WriteLine();
                        Console.Write("What am i..? ");

                        userRiddleAns = Console.ReadLine();

                        if ((userRiddleAns != "dark") && (riddleAtt == 10))
                        {
                            Console.WriteLine("Sigh, I did not expect you to be this dumb..");
                            Console.WriteLine("Tell me that the answer is 'dark' and stop wasting my time..");
                        }

                        if (userRiddleAns != "dark")
                        {
                            Console.WriteLine("'Wrong..'");
                            riddleAtt += 1;
                        }
                    } while (userRiddleAns != "dark");

                } while (riddleAnswer == "dark");
            }
        }









        public static void LevelFive()
        {
            Console.WriteLine("You creep through the door and notice something in the corner");
            Console.WriteLine("It sounds like something is feasting on bones.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("The smell in the room is putrid, like something died a long time ago.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Suddenly, the feasting noise is replaced by squeaking, coming from the 'thing' in the corner");
            Console.WriteLine("... as if whatever 'it' is hasn't been oiled.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("As you creep forward to get a closer look, you step on an old bone.");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("'C        R       A       C       K'");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("You stumble back as you see the figure turn around and move towards the light coming from the control room.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("The squeaking gets louder and LOUDER as it moves closer!");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("As the figure moves into the light, you see what has been feasting...");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("A large, black wild DOG... but without any legs.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Instead, it sits upon two sets of wheels. A dog with wheels for legs.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("You don't have time to process this as it's coming right towards you!");
            Console.WriteLine("What do you do?");
            Thread.Sleep(500);
            Console.WriteLine("1 - Look for something in your inventory that you could use against it.");
            Console.WriteLine("2 - Attempt to dodge the dog and run North.");
            Console.WriteLine("3 - Attempt to dodge the dog and run South.");
            Console.WriteLine();
            answer5 = Console.ReadLine();

            switch (answer5)
            {
                case "1":
                    if (sloth[2].inventory == "BANANA PEEL")
                    {
                        
                    }
                    else if (sloth[0].inventory == "RUSTY KNIFE")
                    {

                    }
                    else
                    {

                    }
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }

        static void Main()
        {
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;                  
            }





            string selection = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                          _       _   _           ");
                Thread.Sleep(125);
                Console.WriteLine("                                         | |     | | | |          ");
                Thread.Sleep(125);
                Console.WriteLine("                                         | |     | | | |                              TM. ");
                Thread.Sleep(125);
                Console.WriteLine("                                      ___| | ___ | |_| |__   ___  ___ __ _ _ __   ___ ");
                Thread.Sleep(125);
                Console.WriteLine("                                     / __| |/ _ \\| __| '_ \\ / __|/ __/ _` | '_ \\ / _ \\");
                Thread.Sleep(125);
                Console.WriteLine("                                     \\__ \\ | (_) | |_| | | |\\__ \\ (_| (_| | |_) |  __/");
                Thread.Sleep(125);
                Console.WriteLine("                                     |___/_|\\___ /\\__|_| |_||___/\\___\\__,_| .__/ \\___|");
                Thread.Sleep(125);
                Console.WriteLine("                                     A text based survival game           | |");
                Thread.Sleep(125);
                Console.WriteLine("                                                                          | |");
                Thread.Sleep(125);
                Console.WriteLine("                                                                          |_|");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("                                               What would you like to do?" );
                Console.WriteLine();
                Console.WriteLine("                                                        1 = PLAY");
                Console.WriteLine();
                Console.WriteLine("                                                        2 = QUIT");
                Console.WriteLine(); 
                Console.WriteLine();
                Console.WriteLine("                           TIP: Type the word 'inventory', to view your inventory while in-game.");
                Console.WriteLine("                              TIP: Type the word 'map', to view your inventory while in-game.");
                Console.WriteLine();
                Console.Write("Input selection: ");
                selection = Console.ReadLine();

                if (selection == "1")
                {
                    LevelOne();
                }
                else if (selection == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("You chose to quit the game. Press enter to quit.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("I do not understand that input.");
                    Thread.Sleep(3000);
                    Console.Clear();
                }

            } while (selection != "2");

        }
        public static void storage(ref string yeet, Player[] sloth)
        {
            if (yeet == "inventory")
            {
                Console.WriteLine("INVENTORY");
                Console.WriteLine();

                for (int x = 0; x < sloth.Length; x++)
                {
                    Console.WriteLine(sloth[x].inventory);
                    Console.WriteLine(sloth[x].description);
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void Map(int location)
        {
            switch (location)
            {
                case 1:
                    Console.WriteLine("[ S ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[ S ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[ S ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[ S ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[ S ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 6:
                    Console.WriteLine("[   ] [ S ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}