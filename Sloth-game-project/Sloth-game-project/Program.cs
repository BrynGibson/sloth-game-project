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
            Console.WriteLine("You are an exotic sloth, escaping dangerous poachers that want to sell you as a pet.");
            Console.WriteLine("You make a narrow escape in the sewers, but you reach a few rooms that are seemingly a dead end.");
            Console.WriteLine("You must escape the sewers and the poachers into the forest so you can have a life.");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
            //Console.Clear();

            Console.WriteLine("");
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
