using System;
using Newtonsoft.Json; // Just tried if it works
using System.IO;
using System.Collections.Generic;
using IOReader;

//TODO Get Url Content(song lyrics) in advance
namespace IOReader {
    public class Program : Utils {
        
        public static void Main (string[] args) {
           while (myInfo.input != ConsoleKey.Escape)
           {
                myInfo.UserInfo();
                myUtil._songDirInit();
                for (int i = 0; i < _indicatorWords.Count; i++)
                {
                    System.Console.WriteLine(_indicatorWords[myUtil.emotions[i].ID]);
                }

                string songPath = myUtil._songDir[myUtil.GetRandomSong(0, myUtil._songDir.Count - 1)]; // Getting random song lyrics
                if (songPath != null)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine();
                    string songTitle = "Today's song is " + songPath;
                    Console.Title = songTitle;
                    System.Console.WriteLine(songTitle);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    myUtil.IOReader(songPath);
                    Console.ResetColor();
                }
            }
            
        }
    }
}