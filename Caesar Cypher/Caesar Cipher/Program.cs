using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
                't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("1- For encryption\n2- Decryption\nYour choice: ");
            int userechoice = Convert.ToInt32(Console.ReadLine());
            switch(userechoice)
            {
                case 1:

                    Console.Write("Please write the message to encrypted: ");
                    char[] userTextEncryption = Console.ReadLine().ToLower().ToCharArray();
                    Console.Write("Choose the offset: ");
                    int offset = Convert.ToInt32(Console.ReadLine());
                    string solution = encryption(userTextEncryption, offset, alphabet);
                    Console.WriteLine($"Solution -->{solution}");
                    break;
                case 2:
                    Console.Write("Please write the message to decrypted: ");
                    char[] userTextDecrypted= Console.ReadLine().ToLower().ToCharArray();
                    string []solutionDecrypted = decrypted(userTextDecrypted, alphabet);
                    foreach (string item in solutionDecrypted)
                        Console.WriteLine(item);
                    break;
            }
            
            Console.ReadLine();
        }

        static string[] decrypted(char[] message, char[] alphabet)
        {
            string[] solution = new string[26];
            char[] decrypted = new char[message.Length];
            int i = 0, j = 0;
            int newLetterIndex = 0;

            while (j < alphabet.Length)
            {
                i = 0;
                foreach (char letter in message)
                {
                    if (!Char.IsLetter(letter))
                    {
                        decrypted[i] = letter;
                        i++;
                        continue;
                    }
                    newLetterIndex = Array.IndexOf(alphabet, letter) + j;
                    newLetterIndex = (newLetterIndex >= alphabet.Length) ? newLetterIndex % alphabet.Length : newLetterIndex;
                    decrypted[i] = alphabet[newLetterIndex];
                    i++;
                }
                solution[j] = String.Join("", decrypted);
                j++;
            }
            return solution;
        }

        static string encryption(char[] userText, int offset, char[] alphabet)
        {
            char[] encryptedText = new char[userText.Length];
            int i = 0;
            int newLetterIndex;
            int decallage = (offset > alphabet.Length) ? offset / alphabet.Length : 0;
            foreach (char letter in userText)
            {
                if (!Char.IsLetter(letter))
                {
                    encryptedText[i] = letter;
                    i++;
                    continue;
                }
                newLetterIndex = Array.IndexOf(alphabet, letter) + offset + decallage;
                newLetterIndex = (newLetterIndex >= alphabet.Length) ? newLetterIndex % alphabet.Length : newLetterIndex;
                encryptedText[i] = alphabet[newLetterIndex];
                i++;
            }
            return String.Join("", encryptedText);

        }
    }
}