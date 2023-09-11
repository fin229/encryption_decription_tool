using System;
using System.Security.Cryptography.X509Certificates;

namespace encryption_decryption_tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //request message

            //declare message variable
            string message = "";
            //validate message
            do
            {
                Console.WriteLine("Geef de tekst dat u wenst te encrypteren of te decrypteren in: ");
                Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(message));

            //functions for encryption
            static char CCipher(char ch,int key)
            {
                if (!char.IsLetter(ch))
                {
                    return ch;
                }
                char offset = char.IsUpper(ch) ? 'A' : 'a';
                return (char)((((ch+key)-offset)%26)+offset);

            }
            //Ceasar cipher encryption
            static string CEncrypt(string input)
            {
                return "";
            }

            //Ceasar cipher deryption
            static string CDecrypt(string input)
            {
                return "";
            }
        }
    }
}
