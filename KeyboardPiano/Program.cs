using System;
using PianoSimulation;

namespace KeyboardPiano
{
    class Program
    {
        static void Main(string[] args)
        {  
            Piano piano = new Piano();
            Audio audio = new Audio();
            ConsoleKeyInfo keyInfo;
            Console.WriteLine("Welcome to a Piano Simulation!");           
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine( "\t" +"If you want to list all the strings with their associated keys. Press Tab." + "\n" + 
                             "\t" + "If you want to play the piano, press Enter." + "\n" + 
                             "\t" + "if you want to exit the program, press Escape.");
                keyInfo = Console.ReadKey(true);
                bool isTrue = true;
                while (isTrue)
                {
                    if (keyInfo.Key == ConsoleKey.Tab) {
                        for (int i = 0; i < piano.GetPianoKeys().Count;i++) {
                            Console.WriteLine(piano.GetPianoKeys()[i]);
                        }
                        isTrue = false;   

                    }
                    else if (keyInfo.Key == ConsoleKey.Enter) {
                        bool playPiano = true;
                        do {
                            try {
                                Console.WriteLine("You can now play the piano. What key(s) would you like to play? Press 0 to escape.");
                                string userInput = Console.ReadLine();
                                foreach(char chinput in userInput) {
                                    if (chinput == '0') {
                                        Console.WriteLine("You are now returning to the main menu.");
                                        playPiano = false; 
                                    }
                                    else {
                                        piano.StrikeKey(chinput);
                                        for (int i = 0; i < 44100 * 3; i++) {
                                            audio.Play(piano.Play());
                                        }

                                    }
                                }
                            }
                            catch (ArgumentOutOfRangeException) {
                                Console.WriteLine("You made an error! You pressed a key that is not in the piano. Try again.");
                            }
                        }while(playPiano);
                        isTrue = false;
                    }
                    else  if (keyInfo.Key == ConsoleKey.Escape) {
                        Console.WriteLine("You have exited the program! GoodBye!");
                        isTrue = false;
                    }
                    else {
                        Console.WriteLine("Invalid Key");
                        isTrue = false;
                    }
                    
                }

            } while (keyInfo.Key != ConsoleKey.Escape);
            
        }
    }
}
