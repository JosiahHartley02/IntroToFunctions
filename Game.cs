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
            SkipLines(3);
            SkipSpaces(40);            
            Console.Write("Welcome To the Land of the Dead!");
            SkipLines(24);
            Console.Write("Press Enter to Begin");
            Console.Write(" > ");
            Console.ReadKey();
        }
         void OpenMainMenu()
        {
            Console.Clear();
            SkipLines(3);
            SkipSpaces(45);
            Console.WriteLine("Naming Process");
            char input = ' ';
            while (input != '1')
            {
                Console.WriteLine("Please enter your name.");
                Console.Write("> ");
                _playername = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Hello " + _playername + "!");
                Console.WriteLine("Are you happy with this name?");            
                input = GetInput("Yes", "No");
                if(input == '2')
                {
                    Console.WriteLine("Yeah try again");
                }                
            }
        }
           
        //Repeated until the game ends
        public void Update()
        {
            Console.WriteLine("\nThis could be anything.");
            Console.Write("> ");
            char possiblyend = Console.ReadKey().KeyChar;            
            if (possiblyend == 'q')
            {
                _gameOver = true;
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
    }
}
