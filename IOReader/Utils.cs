using System;
using System.Collections.Generic;
using System.IO;
namespace IOReader
{
    public class Utils {
        public enum Emotion_Reference
        {
            Interest, Joy, Surprise, Sadness, Anger, Disgust, Contempt, Self_Hostility, Fear, Shame, Shyness, Guilt
        }
        
        
        protected static List<DataEmotions> emotions = new List<DataEmotions>
        {
            //TODO auto-incremental id
           new DataEmotions("Interest", (int)Emotion_Reference.Interest, 5f),
           new DataEmotions("Joy", (int)Emotion_Reference.Joy, 10f),
           new DataEmotions("Surprise", (int)Emotion_Reference.Surprise, 15f),
           new DataEmotions("Sadness", (int)Emotion_Reference.Sadness, 20f),
           new DataEmotions("Anger", (int)Emotion_Reference.Anger, 25f),
           new DataEmotions("Disgust", (int)Emotion_Reference.Disgust, 30f),
           new DataEmotions("Contempt", (int)Emotion_Reference.Contempt, 35f),
           new DataEmotions("SHostility", (int)Emotion_Reference.Self_Hostility, 40f),
           new DataEmotions("Fear", (int)Emotion_Reference.Fear, 45f),
           new DataEmotions("Shame", (int)Emotion_Reference.Shame, 50f),
           new DataEmotions("Shyness", (int)Emotion_Reference.Shyness, 55f),
           new DataEmotions("Guilt", (int)Emotion_Reference.Guilt, 60f),
           
        };
        public void ReferCounter(List<int> _counters)
        {
            if (_counters != null)
            {
                foreach (int _counter in _counters)
                {
                   
                } 
            }
        }
        //METHOD #1
        public static void StreamWriter()
        {
            string[] lines = { "100", "150", "200", "Third" };
            using (StreamWriter file = new StreamWriter(@"D:\GitRepos\FileIOc\IOReader\FinalSong.txt"))
            {
                foreach (var line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"D:\GitRepos\FileIOc\IOReader\FinalSong.txt", true))
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