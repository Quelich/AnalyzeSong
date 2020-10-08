using System;
using System.Collections.Generic;
using System.IO;
namespace IOReader {
    public class Utils {
        public enum Emotion_Reference {
            Interest,
            Joy,
            Surprise,
            Sadness,
            Anger,
            Disgust,
            Contempt,
            Self_Hostility,
            Fear,
            Shame,
            Shyness,
            Guilt
        }

        /// <summary>
        /// Contains data about emotions
        /// </summary>
        /// <value> reference emotions[x]</value>
        protected static List<DataEmotions> emotions = new List<DataEmotions> {

            new DataEmotions ("Interest", (int) Emotion_Reference.Interest, 5f), //emotions[0]
            new DataEmotions ("Joy", (int) Emotion_Reference.Joy, 10f), //emotions[1]
            new DataEmotions ("Surprise", (int) Emotion_Reference.Surprise, 15f), //emotions[2]
            new DataEmotions ("Sadness", (int) Emotion_Reference.Sadness, 20f), //emotions[3]
            new DataEmotions ("Anger", (int) Emotion_Reference.Anger, 25f), //emotions[4]
            new DataEmotions ("Disgust", (int) Emotion_Reference.Disgust, 30f), //emotions[5]
            new DataEmotions ("Contempt", (int) Emotion_Reference.Contempt, 35f), //emotions[6]
            new DataEmotions ("SHostility", (int) Emotion_Reference.Self_Hostility, 40f), //emotions[7]
            new DataEmotions ("Fear", (int) Emotion_Reference.Fear, 45f), //emotions[8]
            new DataEmotions ("Shame", (int) Emotion_Reference.Shame, 50f), //emotions[9]
            new DataEmotions ("Shyness", (int) Emotion_Reference.Shyness, 55f), //emotions[10]
            new DataEmotions ("Guilt", (int) Emotion_Reference.Guilt, 60f), //emotions[11]
        };
        /// <summary>
        /// Dictionary of the Indicator words to compare the words of song
        /// </summary>
        /// <typeparam name="int"> Key</typeparam>
        /// <typeparam name="string[]"> Value </typeparam>
        /// <returns>null</returns>
        public static Dictionary<int, string[]> _indicatorWords = new Dictionary<int, string[]> ();
       
        /// <summary>
        /// Initializes all Emotions at the beginning of the program
        /// </summary>
        public static void InitAll()
        {
            InitInterest();
                InitJoy();
            InitSurprise();
                InitSadness();
            InitAnger();
                InitDisgust();
            InitContempt();
                InitSHostility();
            InitFear();
                InitShame();
            InitShyness();
                InitGuilt();
        }

        #region Writers #7fe5f0
        /// <summary>
        /// Uses Stream writer to reach the directory and gets it into a new file
        /// </summary>
        public static void StreamWriter () {
            string[] lines = { "100", "150", "200", "Third" };
            using (StreamWriter file = new StreamWriter (@"D:\GitRepos\FileIOc\IOReader\FinalSong.txt")) {
                foreach (var line in lines) {
                    if (line.Contains ("Third")) {
                        file.WriteLine (line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter (@"D:\GitRepos\FileIOc\IOReader\FinalSong.txt", true)) {
                file.WriteLine ("Additional test line");
            }
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
        #endregion

        #region Readers #f6d61a
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
        #endregion
      
        public static void Detection (string _phrase) {
            string toParse = _phrase;
            string[] parsedPhrase = toParse.Split (' ');
            foreach (var element in parsedPhrase) {
                
            }

        }
        /// <summary>
        /// Initialization of each emotion one by one, ju
        /// </summary>
        #region InitEmotions #ff0067
        public static void InitInterest() => _indicatorWords.Add(emotions[0].ID, new string[2] { "impressive", "amazing" });
        public static void InitJoy() => _indicatorWords.Add(emotions[1].ID, new string[2] { "impressive", "amazing" });
        public static void InitSurprise() => _indicatorWords.Add(emotions[2].ID, new string[2] { "impressive", "amazing" });
        public static void InitSadness() => _indicatorWords.Add(emotions[3].ID, new string[2] { "impressive", "amazing" });
        public static void InitAnger() => _indicatorWords.Add(emotions[4].ID, new string[2] { "impressive", "amazing" });
        public static void InitDisgust() => _indicatorWords.Add(emotions[5].ID, new string[2] { "impressive", "amazing" });
        public static void InitContempt() => _indicatorWords.Add(emotions[6].ID, new string[2] { "impressive", "amazing" });
        public static void InitSHostility() => _indicatorWords.Add(emotions[7].ID, new string[2] { "impressive", "amazing" });
        public static void InitFear() => _indicatorWords.Add(emotions[8].ID, new string[2] { "impressive", "amazing" });
        public static void InitShame() => _indicatorWords.Add(emotions[9].ID, new string[2] { "impressive", "amazing" });
        public static void InitShyness() => _indicatorWords.Add(emotions[10].ID, new string[2] { "impressive", "amazing" });
        public static void InitGuilt() => _indicatorWords.Add(emotions[11].ID, new string[2] { "impressive", "amazing" });
        #endregion
        
    }
}