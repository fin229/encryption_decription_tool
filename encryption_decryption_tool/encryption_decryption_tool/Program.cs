using System;

namespace encryption_decryption_tool
{
    public class Program
    {
        static void Main(string[] args)
        {
            //request message

            //declare message variable
            string message, keuze;
            int key;
            bool stop = false;

            while (stop != true)
            {
                Console.WriteLine("Hallo, welkom bij de encryptie en decryptie tool." + Environment.NewLine
               + "om de tool te stoppen druk op q" + Environment.NewLine);
                Console.WriteLine("Geef de tekst dat u wenst te encrypteren of te decrypteren in: ");
                message = Console.ReadLine();
                if (message != "q")
                {
                    Console.WriteLine("Wilt u de tekst encrypteren of decrypteren?" + Environment.NewLine);
                    keuze = Console.ReadLine();
                    if (keuze == "encrypteren" || keuze == "decrypteren")
                    {
                        try
                        {
                            key = ReadInteger("Geef de sleutel (een geheel getal tussen 1 en 25):", 1, 25);

                            if (keuze == "encrypteren")
                            {
                                string encryptedMessage = CEncipher(message, key);
                                Console.WriteLine("Versleutelde tekst: " + encryptedMessage);
                            }
                            else if (keuze == "decrypteren")
                            {
                                string decryptedMessage = CDecipher(message, key);
                                Console.WriteLine("Ontsleutelde tekst: " + decryptedMessage);
                            }
                        }
                        catch (FormatException)
                        {

                            Console.WriteLine("Ongeldige invoer. Voer een geldig geheel getal in.");
                        }
                        catch
                        {
                            Console.WriteLine("Ongeldige invoer.Voer een geldig geheel getal tussen 1 en 25");
                        }
                    }
                    else if (keuze != "0")
                    {
                        Console.WriteLine("Ongeldige keuze. Kies 'encrypteren', 'decrypteren', of '0' om te stoppen.");
                    }
                    
                }
                else
                {
                    stop = true;
                }

            }

        }

        //functions for encryption
        public static int ReadInteger(string prompt, int minValue, int maxValue)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            int result;

            if (int.TryParse(input, out result) && result >= minValue && result <= maxValue)
            {
                return result;
            }
            else
            {
                throw new FormatException();
            }
        }
        public static char CCipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - offset) % 26) + offset);

        }
        //Ceasar cipher encryption
        public static string CEncipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
            {
                output += CCipher(ch, key);
            }
            return output;
        }

        //Ceasar cipher deryption
        public static string CDecipher(string input, int key)
        {
            return CEncipher(input, 26 - key);
        }
    }

}
