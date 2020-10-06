using System;
using System.IO;
using IOReader;

namespace IOReader {
    public class Program : Utils {
        //TODO add AI framework to detect the curses
        //TODO purpose examine lyrics of a song
        
        public static void Main (string[] args) {
            string songPath = @"D:\GitRepos\FileIOc\IOReader\FinalSong.txt";
            if (songPath != null)
            {
               
                IOReader(songPath);

            }
        }
       
    }
}