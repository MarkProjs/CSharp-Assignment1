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
            
            Console.WriteLine("Welcome to a Piano Simulation!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine( "\t" +"If you want to list all the strings with their associated keys. Press Tab." + "\n" + 
                             "\t" + "If you want to play the piano, press Enter." + "\n");
            
            if (Console.ReadKey().Key == ConsoleKey.Tab) {
                for (int i = 0; i < piano.GetPianoKeys().Count;i++) {
                    Console.WriteLine(piano.GetPianoKeys()[i]);
                }
            }
            else if (Console.ReadKey().Key == ConsoleKey.Enter) {
                   Console.WriteLine("What key would you like to hit?");
                   string userInput = Console.ReadLine();

                   if (userInput.Length == 1) {
                       piano.StrikeKey(userInput.ToCharArray());
                       
                   }
            }

            
        }
    }
}
