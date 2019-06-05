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
        public static Player[] sloth = new Player[10];
        public static string handhole = "", entered = "";

        static void LevelOne()
        {
            string answer1, answer2;

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
            

            do
            {
                Console.WriteLine("You see a long narrow hallway that is as long as the eye can see.");
                Console.WriteLine("You are in the sewers, it is dark and you notice an unnatural green fog that is hard to see through.");
                Console.WriteLine("The fog obscures your visibility range.");
                Console.WriteLine();
                Console.WriteLine("What do you do...?");
                Console.WriteLine();
                Console.WriteLine("1 - Go North");
                Console.WriteLine("2 - Go East");
                Console.WriteLine("3 - Go South");
                Console.WriteLine("4 - Go West");

                Console.WriteLine();
                answer1 = Console.ReadLine();
                Console.Clear();
                
                switch (answer1)
                {
                    case "1":
                        Console.WriteLine("You head north through the fog.");
                        Thread.Sleep(3000);
                        Console.Clear();
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


            Console.WriteLine("Its hard to make out what's in the room, but you hear a soft snooring, almost sounds like purring.");
            Console.WriteLine("Once your eyes adjust to the light, your heart sinks as you notice a leopard sleeping on a pile of rubbish..");
            Console.WriteLine("Something else catches your eye as you're looking around.. a key hanging off a pipe right below the leopard.");
            Console.WriteLine("The room opens up with two exits, one behind the leopard and another one that goes deeper into the sewer.");
            Console.WriteLine("What do you do?..");
            Console.WriteLine();
            Console.WriteLine("1 - Sneak Past the Leopard East");
            Console.WriteLine("2 - Sneak Past the Leopard South");
            Console.WriteLine("3 - Try and grap the key..");

            answer2 = Console.ReadLine();

            do
            {
                switch (answer2)
                {
                    case "2":
                        Console.WriteLine("You sneak past the Leopard South..");
                        break;

                    case "1":
                        Console.WriteLine("Your path is blocked.. you cannot go that way.");
                        break;

                    case "3":
                        Console.WriteLine("You risk it all .. and lose it all. You have been eaten.");
                        break;
                }

            } while (answer2 == "2");
        }


        static void Main(string[] args)
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
    }
}
