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
        public static string handhole = "", entered = "";

        static void LevelOne()
        {
            string answer1, answer2;

            Console.Clear();
            Console.WriteLine("RULES/INTRODUCTION");
            Console.WriteLine("");
            Console.WriteLine("The rules are simple, in each room there will be multiple options for you to interact with the environment,");
            Console.WriteLine("There will also be the option to move into a different room either north, south east and west,");
            Console.WriteLine("You will have to navigate these rooms and explore the options that you feel best fits for your current situation,");
            Console.WriteLine("Be carefull however, as some options will have different outcomes to certain situations which will affect your story,");
            Console.WriteLine("Try to explore as many options as you can to undercover the story of slothscape!");
            Console.WriteLine("");
            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You are an exotic sloth, escaping dangerous poachers that want to sell you as a pet.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("You make a narrow escape in the sewers, but you reach a few rooms that are seemingly a dead end.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine("You must escape the sewers and the poachers into the forest so you can have a life.");
            Thread.Sleep(3000);
            Console.Clear();

            //ROOM 1


            Console.WriteLine("You manage to lift it open and drop in, just mannageing to close it off before the poachers catch up.");
            Console.WriteLine("You are in the sewers, it is dark and you notice an unnatural green fog that is hard to see through.");
            Console.WriteLine("The fog obscures your visibility range.");

            do
            {
                Console.WriteLine("You mannage to lift it open and drop in, just mannageing to close it off before the poachers catch up.");
                Console.WriteLine("you slide down the ladder into a brigthly lit room");
                Console.WriteLine("Your eyes slowly adjusts to the bright ceiling lights dangling in front of your eyes.");
                Console.WriteLine("You notice that there is only one exit, througth a small sewer grate.");
                Console.WriteLine();
                Console.WriteLine("What do you do...?");
                Console.WriteLine();
                Console.WriteLine("1 - Go South");
                Console.WriteLine("2 - Go East");
                Console.WriteLine("3 - Go North");
                Console.WriteLine("4 - Go West");

                Console.WriteLine();
                answer1 = Console.ReadLine();
                Console.Clear();

                switch (answer1)
                {
                    case "1":
                       
                        Console.WriteLine("You head South through the sewer grate, you mannage just to fir through.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        location = 2;
                        break;
                    case "2":
                        if (entered == "")
                        {
                            do
                            {
                                Console.WriteLine("You look right, you see a hole in the moss-covered wall where your claws can easily fit through.");
                                Thread.Sleep(1000);
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
                                    Thread.Sleep(3000);
                                    Console.WriteLine();
                                    Console.WriteLine("You found a rusty knife with some unknown markings on the blade.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine();
                                    Console.WriteLine("Might be useful later.");
                                    Thread.Sleep(1000);
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
                            Thread.Sleep(1000);
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
                        Console.WriteLine("Going back into where the poachers are seems to be a bad idea.");
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

            //ROOM 2//


            Console.WriteLine("It's hard to make out what's in the room, but you hear a soft snore. Almost sounds like purring.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Once your eyes adjust to the light, your heart sinks as you notice a leopard sleeping on a pile of rubbish in front of you.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Something else catches your eye as you're looking around, you spot a key hanging off a pipe right above the leopard.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("You spot two possible exits, one behind the leopard and another one to your right that seems to go deeper into the sewer.");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("What do you do...?");
            Console.WriteLine();
            Console.WriteLine("1 - Attempt to grab the key");
            Console.WriteLine("2 - Sneak around the Leopard East.");
            Console.WriteLine("3 - Continue deeper into the sewers south");
            Console.WriteLine("4 - Head back into the sewer grate.");
            Console.WriteLine();
            answer2 = Console.ReadLine();
            Console.Clear();

            do
            {
                Console.WriteLine("It's hard to make out what's in the room, but you hear a soft snore. Almost sounds like purring.");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Once your eyes adjust to the light, your heart sinks as you notice a leopard sleeping on a pile of rubbish in front of you.");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Something else catches your eye as you're looking around, you spot a key hanging off a pipe right above the leopard.");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("You spot two possible exits, one behind the leopard and another one to your right that seems to go deeper into the sewer.");
                Thread.Sleep(1000);
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
                        Console.WriteLine("there is a clearing going south, so you decide that it is best to leave the leopard alone");
                        Thread.Sleep(3000);
                        Console.Clear();
                        location = 3;
                        break;
                    case "2":
                        Console.WriteLine("You look down at the ground and notice that it is covered in cans and glass which will make it impossible to sneek past");
                        Console.WriteLine("You realise that it would not be worth trying to sneak past");
                        Thread.Sleep(3000);
                        Console.Clear();


                        break;

                    case "1":

                        if ((sloth[0].inventory == "RUSTY KNIFE") && (answer2 == "3"))
                        {
                            sloth[1].inventory = "UNKNOWN KEY";
                            sloth[1].description = "- You don't know what door this goes into, just try to use for as many locked doors as you can find.";

                            Console.WriteLine("You decide to try and grab the key hanging below the leopard");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("As you walk over the glass and cans on the ground it awakes the leopard from its slumber");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("with your quick thinking you take out the rusty knife from earlier and and hold it infront of the charging leopard");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("The knife entres the leopard and which gives it a swift death");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("You stand on the Leopard's corpse which allows you to easily grab the key.");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("This key might be useful later.");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("[ACQUIRED UNKNOWN KEY]");
                            Console.WriteLine();
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("You decide to try and grab the key hanging below the leopard");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("As you walk over the glass and cans on the ground it awakes the leopard from its slumber");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("with no form of protection you are left to be mauled by the leopard");
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            Console.WriteLine("[GAME OVER]");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                    case "4":
                        //add code here that goes back into room 1
                        break;
                    case "inventory":
                        storage(ref answer2, sloth);
                        break;
                    case "map":
                        Map(location);
                        break;
                    default:
                        Console.WriteLine("I do not understand your input.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }

            } while ((answer2 != "1") && (answer2 != "2") && (answer2 != "3"));

            //ROOM 3 SOUTH//
            string riddleAnswer = "dark";

            if (answer2 == "3")
            {
                do
                {
                    Console.WriteLine("You manage to sneak past the Leopard and you walk into the room, cautious because you were scared of another beast waiting in your path.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("You peek into the room and see a floating apparition which you can make out as something familiar.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("As you study it more, you realise that it is a sloth, but not a living one... a ghost.");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("It turns around and looks at you with its deathly eyes. It opens its mouth and with a deep voice says,");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("'In order to continue on your journey, you must first complete a riddle.'");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("Dazed and confused, you comply with the ghost as you realise there is no other way,");
                    Console.WriteLine("unless you want to deal with the leopard.");
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    int riddleAtt = 0;
                    string userRiddleAns = "";

                    do
                    {
                        Console.WriteLine("'It cannot be seen, cannot be felt,'");
                        Console.WriteLine("'cannot be heard, cannot be smelt.'");
                        Console.WriteLine();
                        Console.WriteLine("'It lies behind stars and under hills,'");
                        Console.WriteLine("'and empty holes it fills.'");
                        Console.WriteLine();
                        Console.WriteLine("'It comes out first and follows after,'");
                        Console.WriteLine("'ends life, kills laughter.'");
                        Console.WriteLine();
                        Console.Write("What am I? ");

                        userRiddleAns = Console.ReadLine();

                        if ((userRiddleAns != "dark") && (riddleAtt == 10))
                        {
                            Console.WriteLine("Sigh, I did not expect you to be this unintelligent.");
                            Console.WriteLine("Tell me that the answer is 'dark'.");
                        }

                        if (userRiddleAns != "dark")
                        {
                            Console.WriteLine("'Wrong...'");
                            riddleAtt += 1;
                        }
                    }
                    while (userRiddleAns != "dark");

                } while (riddleAnswer == "dark");
            }

        }

        static void Main()
        {

            string selection = "";

            do
            {
                Console.WriteLine("     _       _   _           ");
                Thread.Sleep(125);
                Console.WriteLine("    | |     | | | |          ");
                Thread.Sleep(125);
                Console.WriteLine("    | |     | | | |          ");
                Thread.Sleep(125);
                Console.WriteLine(" ___| | ___ | |_| |__   ___  ___ __ _ _ __   ___ ");
                Thread.Sleep(125);
                Console.WriteLine("/ __| |/ _ \\| __| '_ \\ / __|/ __/ _` | '_ \\ / _ \\");
                Thread.Sleep(125);
                Console.WriteLine("\\__ \\ | (_) | |_| | | |\\__ \\ (_| (_| | |_) |  __/");
                Thread.Sleep(125);
                Console.WriteLine("|___/_|\\___ /\\__|_| |_||___/\\___\\__,_| .__/ \\___|");
                Thread.Sleep(125);
                Console.WriteLine("                                     | |");
                Thread.Sleep(125);
                Console.WriteLine("                                     | |");
                Thread.Sleep(125);
                Console.WriteLine("                                     |_|");
                Console.WriteLine();
                Console.WriteLine("1: PLAY");
                Console.WriteLine("2: QUIT");
                Console.WriteLine();
                Console.WriteLine("Tip: Type the word inventory to view your inventory while in-game.");
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

                Thread.Sleep(5000);
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
                    break;

                case 2:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[ S ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[ S ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[ S ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("[   ] [   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[ S ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;

                case 6:
                    Console.WriteLine("[   ] [ S ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine(" | |   | | ");
                    Console.WriteLine("[   ]=[   ]");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;



            }
        }

    }
}