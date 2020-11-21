using System;
using System.Collections.Generic;
using System.IO;
using IOReader;
namespace IOReader
{
    public class Info {
        
        public static void UserInfo()
        {
            System.Console.WriteLine("Welcome to your daily song lyrics");
            System.Console.WriteLine("To add song directory - Press B");
            System.Console.WriteLine("To show your lyrics library - Press N");
            ConsoleKey input = Console.ReadKey();
            
            if (input is ConsoleKey)
            {
                switch (input)
                {
                    case input.Key.:
                    System.Console.WriteLine("Write down lyrics directory");
                    string lyricsDir = Console.ReadLine();
                        for (int i = 0; i < Int32.MaxValue; i++)
                        {
                            Utils._songDir.Add(i, lyricsDir);
                        }
                        break;
                    case "N":
                        Utils.ShowLibrary();
                        break;
                    default:
                    System.Console.WriteLine("Invalid Input");
                        break;
                }
            }
            
        }
    }
}