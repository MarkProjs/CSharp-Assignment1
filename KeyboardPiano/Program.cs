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
                        Console.WriteLine("You can now play the piano. You can go back to the menu by pressing 0.");
                        ConsoleKeyInfo chinput = Console.ReadKey(true);
                        switch (chinput.Key)
                        {
                            case ConsoleKey.Q:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D2:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.W:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }case ConsoleKey.E:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D4:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.R:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D5:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.T:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Y:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D7:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.U:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D8:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.I:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D9:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.O:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.P:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Subtract:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Oem4:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.OemPlus:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Z:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.X:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.C:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.F:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.V:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.G:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.B:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.N:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.J:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.M:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.K:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.OemComma:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.OemPeriod:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Oem1:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Divide:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Oem8:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.Spacebar:{
                                piano.StrikeKey(chinput.KeyChar);
                                for (int i = 0; i < 44100 * 3; i++) {
                                    audio.Play(piano.Play());
                                }
                                break;
                            }
                            case ConsoleKey.D0: {
                                isTrue = false;
                                break;

                            }
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }

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
