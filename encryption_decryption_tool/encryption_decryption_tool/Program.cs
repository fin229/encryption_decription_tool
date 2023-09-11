using System;

namespace encryption_decryption_tool
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //request message

            //declare message variable
            string message = "";
            int key;

            Console.WriteLine("type a messageto encrypt"+Environment.NewLine);
            message = Console.ReadLine();
            Console.WriteLine("Enter your key"+Environment.NewLine);
            key=int.Parse(Console.ReadLine());
            Console.WriteLine("Encrypted data:");
            string cipherText=CEncipher(message, key);
            Console.WriteLine(cipherText+Environment.NewLine);
            Console.WriteLine("Decrypted data:");
            Console.WriteLine(CDecipher(cipherText,key)+Environment.NewLine);

            //validate message
            //do
            //{
            //    Console.WriteLine("Geef de tekst dat u wenst te encrypteren of te decrypteren in: ");
            //    Console.ReadLine();
            //} while (string.IsNullOrWhiteSpace(message));



            //functions for encryption
            static char CCipher(char ch, int key)
            {
                if (!char.IsLetter(ch))
                {
                    return ch;
                }
                char offset = char.IsUpper(ch) ? 'A' : 'a';
                return (char)((((ch + key) - offset) % 26) + offset);

            }
            //Ceasar cipher encryption
            static string CEncipher(string input,int key)
            {
                string output=string.Empty;

                foreach (char ch in input)
                {
                    output += CCipher(ch, key);
                }
                return output;
            }

            //Ceasar cipher deryption
            static string CDecipher(string input,int key)
            {
                return CEncipher(input, 26 - key);
            }
        }
    }
}
