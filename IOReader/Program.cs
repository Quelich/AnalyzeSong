using System;
using System.IO;

namespace IOReader {
    public class Program {
        //TODO add AI framework to detect the curses
        public static void Main (string[] args) {

        }
        /// <summary>
        /// Simple .txt reader
        /// </summary>
        public static void IOReader () {
            //! You need to key in the direction of the file yet
            string Text = File.ReadAllText (@"D:\GitRepos\FileIOc\IOReader\SampleText.txt");
            Console.WriteLine ($"{Text}");
            Console.ReadKey ();
        }
        /// <summary>
        /// Simple .txt data writer 
        /// </summary>
        public static void IOWriter () {
            string[] lines = { "Hello", "This is Emre", "Just having fun with it" };
            //! You need to key in the direction of the file yet
            File.WriteAllLines (@"D:\GitRepos\FileIOc\IOReader\WrittenText.txt", lines);
        }
        /// <summary>
        /// Gets input from the user wanting to create a text file
        /// </summary>
        public static void GotInput () {
            Console.WriteLine ("Type the file name...");
            string fileName = Console.ReadLine ();
            Console.WriteLine ("Type the content you want");
            string input = Console.ReadLine ();
            File.WriteAllText (@"D:\GitRepos\FileIOc\IOReader\" + fileName + ".txt", input);
        }
    }
}