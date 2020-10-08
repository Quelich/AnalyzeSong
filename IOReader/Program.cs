using System;
using System.IO;
using System.Collections.Generic;
using IOReader;
//TODO main purpose :: examine lyrics of a song
namespace IOReader {
    public class Program : Utils {
        //TODO add ML.NET framework to detect the curses and to do more
        public static void Main (string[] args) {
            for (int i = 0; i < _indicatorWords.Count; i++)
            {
                System.Console.WriteLine(_indicatorWords[emotions[i].ID]);
            }
            InitAll();
            //string songPath = @"D:\GitRepos\FileIOc\IOReader\FinalSong.txt";
            System.Console.WriteLine("Please give the song's file directory"); 
            string songPath = Console.ReadLine();
            if (songPath != null)
            {
                System.Console.WriteLine("Song Path is {0}", songPath);
                IOReader(songPath);
                
            }
            
          
        }
    }
}