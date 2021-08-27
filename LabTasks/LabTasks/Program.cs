using System;

namespace LabTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedwords = { "tehqir1", "tehqir2" };
            string sentence = "Bura zibil  tehqir2 atanin tehqir1";
            Console.WriteLine(sentence.SecretBannedWords(bannedwords));
        }
    }
}
