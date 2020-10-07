using System;
using System.IO;
using System.Collections.Generic;
using IOReader;
//TODO main purpose :: examine lyrics of a song
namespace IOReader {
    public class Program : Utils {
        //TODO add ML.NET framework to detect the curses and to do more
        public static void Main (string[] args) {
            InitIndicators();
            //string songPath = @"D:\GitRepos\FileIOc\IOReader\FinalSong.txt";
            System.Console.WriteLine("Please give the song's file directory"); 
            string songPath = Console.ReadLine();
            if (songPath != null)
            {
                System.Console.WriteLine("Song Path is {0}", songPath);
                IOReader(songPath);
                
            }
            System.Console.WriteLine(emotions[0].Point + emotions[1].Point); 
          
        }
       
    }
}