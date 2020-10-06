using System;
using System.IO;
using System.Collections.Generic;
using IOReader;
//TODO main purpose :: examine lyrics of a song
namespace IOReader {
    public class Program : Utils {
        //TODO add AI framework to detect the curses
        
        
        public static void Main (string[] args) {
            string songPath = @"D:\GitRepos\FileIOc\IOReader\FinalSong.txt"; //TODO find a way to get the path of the file from the user directly
            if (songPath != null)
            {
                //IOReader(songPath);
            }
            System.Console.WriteLine(emotions[0].Point + emotions[1].Point); 
           
        }
       
    }
}