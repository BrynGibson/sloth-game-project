using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sloth_game_project
{
    class Program
    {

        static void LevelOne()
        {
            string answer1, answer2;

            Console.WriteLine("You are an exotic sloth, escaping dangerous poachers that want to sell you as a pet.");
            Console.WriteLine("You make a narrow escape in the sewers, but you reach a few rooms that are seemingly a dead end.");
            Console.WriteLine("You must escape the sewers and the poachers into the forest so you can have a life.");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
            //Console.Clear();


            //ROOM 1
            Console.WriteLine("You see a long narrow hallway that is as long as the eye can see.");
            Console.WriteLine("You are in the sewers, it is dark and you notice an unnatural green fog that is hard to see through.");
            Console.WriteLine("The fog obscures your visibility range.");
            Console.WriteLine("What do you do?..");
            Console.WriteLine();
            Console.WriteLine("1 - Go North");
            Console.WriteLine("2 - Go East");
            Console.WriteLine("3 - Go South");
            Console.WriteLine("4 - Go West");

            answer1 = Console.ReadLine();

            do
            {

                switch (answer1)
                {
                    case "3":
                        Console.WriteLine("You head south..");
                        break;

                    default:
                        Console.WriteLine("You cannot go that way..");
                        break;
                }

            } while (answer1 == "3");


            Console.WriteLine("Its hard to make out what's in the room, but you hear a soft snooring, almost sounds like purring.");
            Console.WriteLine("Once your eyes adjust to the light, your heart sinks as you notice a leopard sleeping on a pile of rubbish..");
            Console.WriteLine("Something else catches your eye as you're looking around.. a key hanging off a pipe right below the leopard.");
            Console.WriteLine("The room opens up with two exits, one behind the leopard and another one that goes deeper into the sewer.");
            Console.WriteLine("What do you do?..");
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
                    Console.WriteLine("Selection unrecognized. Press enter to retry.");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (selection != "2");
        }
    }
}
