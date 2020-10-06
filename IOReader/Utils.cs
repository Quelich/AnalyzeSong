using System;
using System.IO;
namespace IOReader
{
    public class Utils {
        #region Counters
        //private static int good_Count = 0;


        #endregion
        protected enum Emotions
        {
            Interest, Joy, Surprise, Sadness, Anger, Disgust, Contempt, Hostility, Fear, Shame, Shyness, Guilt
        }
        //METHOD #1
        public static void StreamWriter()
        {
            string[] lines = { "100", "150", "200", "Third" };
            using (StreamWriter file = new StreamWriter(@"D:\GitRepos\FileIOc\IOReader\myFile.txt"))
            {
                foreach (var line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"D:\GitRepos\FileIOc\IOReader\myFile.txt", true))
            {
                file.WriteLine("Additional test line");
            }
        }
        //METHOD #2
        /// <summary>
        /// Simple .txt reader
        /// </summary>
        public static void IOReader(string _path)
        {
            //! You need to key in the direction of the file yet
            string Text = File.ReadAllText(_path);
            Console.WriteLine($"{Text}");
            System.Console.WriteLine("***************");
            Parse(Text);
            Console.ReadKey();
        }

        /// <summary>
        /// Simple .txt data writer 
        /// </summary>
        public static void IOWriter(string[] _parsedPhrase)
        {
            string[] lines = { "Hello", "This is Emre", "Just having fun with it" };
            //! You need to key in the direction of the file yet
            File.WriteAllLines(@"D:\GitRepos\FileIOc\IOReader\WrittenText.txt", lines);
        }

        public static void Parse(string _phrase)
        {
            string toParse = _phrase;
            string[] parsedPhrase = toParse.Split(' ');
            foreach (var element in parsedPhrase)
            {
               if (element == "gone")
               {
                    
               }
               
            }
            
        }
    }
}