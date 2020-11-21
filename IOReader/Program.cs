using System;
using Newtonsoft.Json; // Just tried if it works
using System.IO;
using System.Collections.Generic;
using IOReader;

//TODO Get Url Content(song lyrics) in advance
namespace IOReader {
    public class Program : Utils {
        public static InitDir initSongDir = _songDirInit;
        public static void Main (string[] args) {
            Info.UserInfo(); // directly 
            initSongDir();
            for (int i = 0; i < _indicatorWords.Count; i++)
            {
                System.Console.WriteLine(_indicatorWords[emotions[i].ID]);
            }
            
            string songPath = _songDir[GetRandomSong(0, _songDir.Count-1)]; // Getting random song lyrics
            if (songPath != null)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                string songTitle = "Today's song is " + songPath;
                Console.Title = songTitle;
                System.Console.WriteLine(songTitle);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                IOReader(songPath);
                Console.ResetColor(); 
            }           
        }
    }
}