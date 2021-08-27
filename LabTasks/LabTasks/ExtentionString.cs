using System;
using System.Collections.Generic;
using System.Text;

namespace LabTasks
{
   static class ExtentionString
    {
        public static string   SecretBannedWords(this string sentence,string[] bannedwords)
        {
            foreach (string item in bannedwords)
            {
                sentence = sentence.Replace(item, "Oops");
            }
            return sentence;
        }
    }
}
