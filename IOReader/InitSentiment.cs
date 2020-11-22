using System;
using System.Collections.Generic;
using System.IO;
namespace IOReader
{
    public class InitSentiment
    {
        protected static Utils myUtil = new Utils();
        
        #region InitEmotions #ff0067 //
        public static void InitInterest() => Utils._indicatorWords.Add(myUtil.emotions[0].ID, new string[2] { "impressive", "amazing" });
        public static void InitJoy() => Utils._indicatorWords.Add(myUtil.emotions[1].ID, new string[2] { "impressive", "amazing" });
        public static void InitSurprise() => Utils._indicatorWords.Add(myUtil.emotions[2].ID, new string[2] { "impressive", "amazing" });
        public static void InitSadness() => Utils._indicatorWords.Add(myUtil.emotions[3].ID, new string[2] { "impressive", "amazing" });
        public static void InitAnger() => Utils._indicatorWords.Add(myUtil.emotions[4].ID, new string[2] { "impressive", "amazing" });
        public static void InitDisgust() => Utils._indicatorWords.Add(myUtil.emotions[5].ID, new string[2] { "impressive", "amazing" });
        public static void InitContempt() => Utils._indicatorWords.Add(myUtil.emotions[6].ID, new string[2] { "impressive", "amazing" });
        public static void InitSHostility() => Utils._indicatorWords.Add(myUtil.emotions[7].ID, new string[2] { "impressive", "amazing" });
        public static void InitFear() => Utils._indicatorWords.Add(myUtil.emotions[8].ID, new string[2] { "impressive", "amazing" });
        public static void InitShame() => Utils._indicatorWords.Add(myUtil.emotions[9].ID, new string[2] { "impressive", "amazing" });
        public static void InitShyness() => Utils._indicatorWords.Add(myUtil.emotions[10].ID, new string[2] { "impressive", "amazing" });
        public static void InitGuilt() => Utils._indicatorWords.Add(myUtil.emotions[11].ID, new string[2] { "impressive", "amazing" });


        #endregion

    }
}