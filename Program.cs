using System;

namespace Substitution_Kryptering
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryptor enc = new Encryptor();

            string word = "Hej med dig jeg hedder kaj";
            string newWord = enc.Encrypt(word);
            string OrgWord = enc.Decrypt(newWord);
            Console.WriteLine(word);
            Console.WriteLine(newWord);
            Console.WriteLine(OrgWord);

        }
    }
}
