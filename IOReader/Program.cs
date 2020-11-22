using System;
using Newtonsoft.Json; // Just tried if it works
using System.IO;
using System.Collections.Generic;
using IOReader;

//TODO Get Url Content(song lyrics) in advance
namespace IOReader {
    public class Program : Utils {
        protected static Utils myUtil = new Utils();
        public InitDir initSongDir = myUtil._songDirInit;
        public static void Main (string[] args) {
           
            Info.UserInfo(); // directly 
            myUtil._songDirInit();
            for (int i = 0; i < _indicatorWords.Count; i++)
            {
                System.Console.WriteLine(_indicatorWords[myUtil.emotions[i].ID]);
            }
            
            string songPath = myUtil._songDir[myUtil.GetRandomSong(0, myUtil._songDir.Count-1)]; // Getting random song lyrics
            if (songPath != null)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
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