using System;
using System.Collections.Generic;
using System.IO;
using IOReader;
namespace IOReader
{
    public class Info : Utils{
        
        public ConsoleKey input;
        public void UserInfo()
        {
            
            System.Console.WriteLine("Welcome to your daily song lyrics");
            System.Console.WriteLine("To add song directory - Press <B>");
            System.Console.WriteLine("To show your lyrics library - Press <N>");
            System.Console.WriteLine("To exit - Press <Esc>");
            myInfo.input = Console.ReadKey().Key; // just trying different methods 
            
            if (input != null)
            {
                switch (input)
                {
                    case ConsoleKey.B:
                    System.Console.WriteLine("Write down lyrics directory");
                    string lyricsDir = Console.ReadLine();
                        for (int i = 0; i < Int32.MaxValue; i++)
                        {
                            myUtil._songDir.Add(i, lyricsDir);
                        }
                        break;
                    case ConsoleKey.N:
                        myUtil.ShowLibrary();
                        break;
                    case ConsoleKey.Escape:
                        System.Console.WriteLine("Shutting Down");
                        break;
                    default:
                    System.Console.WriteLine("Invalid Input");
                        break;
                }
            }
            
        }
    }
}