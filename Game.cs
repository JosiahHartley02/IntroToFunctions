using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        bool _gameOver = false;
        string _playername = " ";



        //Run the game        
        public void Run()
        {
            Start();
            OpenMainMenu();
            while (_gameOver == false)
            {
                Update();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("To begin, please start the resizing calibration\nStretch the window to fit the # on one line which will be shown on the next screen");
            SkipLines(26);
            SkipSpaces(82);
            Console.Write("Press enter to start the calibration");
            Console.ReadKey();
            Console.Clear();
            WriteBarrier(100);
            SkipLines(11);
            SkipSpaces(15);
            Console.Write("Window width must be 100 units or the lenght of the above line\n");
            SkipSpaces(11);
            Console.Write("Window height must be 29 units or the length to the bottom line, if you do not\n");
            SkipSpaces(15);
            Console.Write("See the bottom or top line, readjust until you do or scroll up");
            SkipLines(7);
            SkipSpaces(20);
            Console.Write("Press enter when you have calibrated your screen");
            SkipLines(6);
            WriteBarrier(100);

            Console.ReadKey();

        }
        void OpenMainMenu()
        {
            Console.Clear();
            WriteBarrier(100);
            SkipLines(3);
            SkipSpaces(40);
            Console.WriteLine("Naming Process");
            SkipLines(7);
            char input = ' ';
            while (input != '1')
            {
                SkipSpaces(35);
                Console.WriteLine("Please enter your name.");
                SkipSpaces(35);
                Console.Write("> ");
                _playername = Console.ReadLine();
                Console.Clear();
                WriteBarrier(100);
                SkipLines(5);
                SkipSpaces(40);
                Console.WriteLine("Hello " + _playername + "!");
                SkipLines(7);
                SkipSpaces(33);
                Console.WriteLine("Are you happy with this name?");
                input = GetInput("Yes", "No");
                if (input == '2')
                {
                    Console.WriteLine("Yeah try again");
                }
            }
        }

        //Repeated until the game ends
        public void Update()
        {
            Console.Clear();
            WriteBarrier(100);
            SkipLines(3);
            SkipSpaces(20);
            Console.Write(_playername + " is in front of a town, they must explore to find shelter");
            Get4Input("Walk forward into the town.", "walk left to the woods", "walk right to feild", "walk away from the city");
            char input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case 'w':
                    Console.Clear();
                    WriteBarrier(100);
                    SkipLines(3);
                    SkipSpaces(15);
                    Console.Write("You enter the town, around you is still, nothing is moving except to the right\n");
                    SkipSpaces(20);
                    Console.Write("a bird above a barred up bank. Ahead is deeper into the town with\n");
                    SkipSpaces(20);
                    Console.Write("cars littering the street. Behind you is the outskirt of the city");
                    Get4Input("walk farther into the city", "Scream                  ", "walk to the birds nest", "walk back to the front of the city");
                    Console.ReadKey();
                    break;
                case 'a':
                    Console.Clear();
                    WriteBarrier(100);
                    SkipLines(3);
                    SkipSpaces(15);
                    Console.Write("You enter the woods, around you is windy yet offly quiet, on the ground\n");
                    SkipSpaces(20);
                    Console.Write("scatterd around you are twigs and a few heavy rocks.");
                    Get4Input("walk toward the heavy rocks", "walk to the sticks to the left", "walk to the sticks to the right", "walk back to the front of the town");
                    Console.ReadKey();
                    break;
                case 's':
                    Console.Clear();
                    WriteBarrier(100);
                    SkipLines(3);
                    SkipSpaces(15);
                    Console.Write("There is nothing here for you\n");
                    SkipLines(14);
                    SkipSpaces(15);
                    Console.Write("Press Enter to walk back to the front of the city.");
                    Console.ReadKey();
                    break;
                case 'd':
                    Console.Clear();
                    WriteBarrier(100);
                    SkipLines(3);
                    SkipSpaces(15);
                    Console.Write("You enter the field, there seems to be nothing\n");
                    SkipSpaces(20);
                    Console.Write("worth exploring out here, maybe later there will be?");
                    SkipLines(14);
                    SkipSpaces(15);
                    Console.Write("Press Enter to walk back to the front of the city");
                    Console.ReadKey();
                    break;
            }
        }

        //Performed once when the game ends
        public void End()
        {
            Console.Clear();
            Console.WriteLine("This is the end");

        }

        char GetInput(string option1, string option2)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            return input;
        }
        //this shouldnt have taken as long to figure out as it did
        void SkipLines(int howmany)
        {
            for (int i = 0; i <= howmany; i++)
            {
                Console.WriteLine();
            }
        }
        void SkipSpaces(int howmany)
        {
            for (int i = 0; i <= howmany; i++)
            {
                Console.Write(" ");
            }
        }
        void WriteBarrier(int howmany)
        {
            for (int i = 0; i <= howmany; i++)
            {
                Console.Write("#");
            }

        }
        void Get4Input(string option1,string option2,string option3,string option4)
        {
        SkipLines(5);
        SkipSpaces(40);
        Console.Write("Press W to " + option1);
            SkipLines(1);
        SkipSpaces(15);
        Console.Write("Press A to " + option2);
            SkipSpaces(20);
        Console.Write("Press D to " + option3);
            SkipLines(1);
        SkipSpaces(40);
        Console.Write("Press S to " + option4);
            }
    }
}
