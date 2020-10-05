using System;
using System.IO;

namespace IOReader {
    class Program {
        //TODO add AI framework to detect the curses
        static void Main (string[] args) {
        }
        public void IOReader () {
            //! You need to key in the direction of the file yet
            string Text = File.ReadAllText (@"D:\GitRepos\FileIOc\IOReader\SampleText.txt");
            Console.WriteLine ($"{Text}");
            Console.ReadKey ();
        }
        public void IOWriter () {
            string[] lines = { "Hello", "This is Emre", "Just having fun with it" };
            //! You need to key in the direction of the file yet
            File.WriteAllLines (@"D:\GitRepos\FileIOc\IOReader\WrittenText.txt", lines);
        }
    }

}