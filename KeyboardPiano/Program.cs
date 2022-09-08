using System;
using PianoSimulation;

namespace KeyboardPiano
{
    class Program
    {
        static void Main(string[] args)
        {  
            bool playPiano = true;
            Console.WriteLine("Welcome to a Piano Simulation!");
            

            while (playPiano) {
                
                string UserInput = Console.ReadLine();
                Piano piano = new Piano();
                Audio audio = new Audio();

            }

            
        }
    }
}
