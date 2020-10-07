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
        
        /// <summary>
        /// Contains data about emotions
        /// </summary>
        /// <value> reference emotions[x]</value>
        protected static List<DataEmotions> emotions = new List<DataEmotions>
        {
            //TODO auto-incremental id
           new DataEmotions("Interest", (int)Emotion_Reference.Interest, 5f),//emotions[0]
           new DataEmotions("Joy", (int)Emotion_Reference.Joy, 10f),//emotions[1]
           new DataEmotions("Surprise", (int)Emotion_Reference.Surprise, 15f),//emotions[2]
           new DataEmotions("Sadness", (int)Emotion_Reference.Sadness, 20f),//emotions[3]
           new DataEmotions("Anger", (int)Emotion_Reference.Anger, 25f),//emotions[4]
           new DataEmotions("Disgust", (int)Emotion_Reference.Disgust, 30f),//emotions[5]
           new DataEmotions("Contempt", (int)Emotion_Reference.Contempt, 35f),//emotions[6]
           new DataEmotions("SHostility", (int)Emotion_Reference.Self_Hostility, 40f),//emotions[7]
           new DataEmotions("Fear", (int)Emotion_Reference.Fear, 45f),//emotions[8]
           new DataEmotions("Shame", (int)Emotion_Reference.Shame, 50f),//emotions[9]
           new DataEmotions("Shyness", (int)Emotion_Reference.Shyness, 55f),//emotions[10]
           new DataEmotions("Guilt", (int)Emotion_Reference.Guilt, 60f),//emotions[11]
        };
        public static Dictionary<int, string[]> _indicatorWords = new Dictionary<int, string[]>();
        public static void InitIndicators()
        {
            _indicatorWords.Add(emotions[0].ID, new string[2] {"impressive", "amazing"});
            foreach (KeyValuePair<int, string[]> keyValuePair in _indicatorWords)
            {
                System.Console.WriteLine($" Key:{keyValuePair.Key} | Value:{keyValuePair.Value[0]}");
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
            System.Console.WriteLine("********************************");
            Console.WriteLine($"{Text}");
            System.Console.WriteLine("********************************");
            Detection(Text);
            Console.ReadKey();
        }

        /// <summary>
        /// Simple .txt data writer 
        /// </summary>
        public static void IOWriter(string _fileDir, string[] _parsedPhrase)
        {
            //! You need to key in the direction of the file yet
            //File.WriteAllLines(@"D:\GitRepos\FileIOc\IOReader\WrittenText.txt", _parsedPhrase);
            File.WriteAllLines(_fileDir, _parsedPhrase);
        }

        public static void Detection(string _phrase)
        {
            string toParse = _phrase;
            string[] parsedPhrase = toParse.Split(' ');
            foreach (var element in parsedPhrase)
            {
               
               //TODO make word check
            }
            
        }
    }
}