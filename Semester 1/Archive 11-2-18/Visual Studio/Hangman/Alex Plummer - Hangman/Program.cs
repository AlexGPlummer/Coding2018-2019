using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alex_Plummer___Hangman
{
    class Program
    {
        static char[] alpha = new char[26];
        static string[] hangman = new string[7];
        static string[] words = new string[20];
        static string[] phrases = new string[20];
        static char[] check = new char[3];
        static string randomWord = "";
        static Random rand = new Random();
        static int mode = 0;
        static char guess;             
        static void Main(string[] args)
        {
            int answer = 0;
            

            while (answer != 2)
            {                
                hangman[0] = " _________     ";
                hangman[1] = "|      |       ";
                hangman[2] = "|              ";
                hangman[3] = "|              ";
                hangman[4] = "|              ";
                hangman[5] = "|              ";
                hangman[6] = "|              ";
                hangmanphrases();
                hangmanwords();                               
                Console.WriteLine("*************************************************************");
                Console.WriteLine("** Enter the integer value for the action you want to perform");
                Console.WriteLine("** 1. Play Hangman. ");
                Console.WriteLine("** 2. Exit the program");
                Console.WriteLine("*************************************************************");
                answer = int.Parse(Console.ReadLine());                
                if (answer == 1)
                {
                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("** Enter the integer value for the mode you want to play");
                    Console.WriteLine("** 1. Word ");
                    Console.WriteLine("** 2. Phrase");
                    Console.WriteLine("*************************************************************");
                    mode = int.Parse(Console.ReadLine());
                    Console.WriteLine("*************************************************************");
                    if (mode == 1)
                    {
                        randomWord = words[rand.Next(0, words.Length)];                        
                        hangmanprogram();
                    }
                    if (mode == 2)
                    {
                        randomWord = phrases[rand.Next(0, phrases.Length)];
                        hangmanprogram();
                    }
                }                 
            }
        }       
        static void hangmanprogram()
        {            
            check[0] = ' ';
            check[1] = '\'';
            check[2] = ',';
            bool isValid = false;
            char[] guessedLetters = new char[50];
            int run = 0;
            Console.WriteLine(randomWord);
            char[] myWordArray = new char[randomWord.Length];            
            for (int i = 0; i < myWordArray.Length; i++)
            {
                myWordArray[i] = '_';
            }
            for (int j = 0; j < check.Length; j++)
            {
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == check[j])
                    {
                        myWordArray[i] = check[j];
                    }
                }
            }
            int guesses = 6;
            Console.WriteLine("You have 6 guesses to guess the word or phrase");
            string s = "";
            while (guesses != 0 && randomWord != s)
            {

                Console.Clear();
                Console.WriteLine("*************************************************************");
                Console.WriteLine("You have " + guesses + " guesses left");
                gallows();
                Console.WriteLine(myWordArray);
                Console.Write("Guessed letters ");
                Console.WriteLine(guessedLetters);
                Console.WriteLine("Enter 1 to guess a letter or enter 2 to guess the word or phrase.");
                int guessOrWord = int.Parse(Console.ReadLine());
                if (guessOrWord == 2)
                {
                    Console.WriteLine("What is your guess?");
                    s = Console.ReadLine();
                    if (randomWord == s)
                    {
                        Console.Clear();
                        Console.WriteLine("*************************************************************");
                        gallows();
                        Console.WriteLine(randomWord);
                        Console.WriteLine("You Won");
                    }
                    else
                    {
                        guesses = 0;
                        if (guesses <= 5)
                        {
                            hangman[2] = "|      0      ";
                        }
                        if (guesses <= 4)
                        {
                            hangman[3] = "|      |      ";
                        }
                        if (guesses <= 3)
                        {
                            hangman[3] = "|     /|      ";
                        }
                        if (guesses <= 2)
                        {
                            hangman[3] = "|     /|\\    ";
                        }
                        if (guesses <= 1)
                        {
                            hangman[4] = "|     /       ";
                        }
                        if (guesses == 0)
                        {
                            hangman[4] = "|     / \\    ";
                            Console.Clear();
                            Console.WriteLine("*************************************************************");
                            gallows();
                            Console.WriteLine(myWordArray);
                            Console.WriteLine("You guessed " + s);
                            Console.WriteLine("The correct word is " + randomWord);
                        }
                    }
                }
                if (guessOrWord == 1)
                {
                    Console.WriteLine("What is your guess?");
                    guess = char.Parse(Console.ReadLine().ToLower());
                    isValid = false;
                    int k = 0;
                    for (int i = 0; i < guessedLetters.Length; i++)
                    {
                        if (guessedLetters[i] == guess)
                        {
                            Console.WriteLine("You have already guessed that letter");
                        }
                        else
                        {
                            k = k + 1;
                        }
                    }
                    if (k == 50)
                    {
                        guessedLetters[run] = guess;
                        run = run + 1;
                        isValid = false;
                        for (int i = 0; i < randomWord.Length; i++)
                        {
                            if (randomWord[i] == guess)
                            {
                                myWordArray[i] = guess;
                                isValid = true;
                            }
                        }
                        for (int i = 0; i < alpha.Length; i++)
                        {
                            lowercase();
                            if (alpha[i] == guess)
                            {
                                uppercase();
                                guess = alpha[i];
                            }
                        }
                        for (int i = 0; i < randomWord.Length; i++)
                        {
                            if (randomWord[i] == guess)
                            {
                                myWordArray[i] = guess;
                                isValid = true;
                            }
                        }
                        s = new string(myWordArray);
                        if (isValid == false)
                        {
                            guesses--;
                        }
                        if (guesses == 5)
                        {
                            hangman[2] = "|      0      ";
                        }
                        if (guesses == 4)
                        {
                            hangman[3] = "|      |      ";
                        }
                        if (guesses == 3)
                        {
                            hangman[3] = "|     /|      ";
                        }
                        if (guesses == 2)
                        {
                            hangman[3] = "|     /|\\    ";
                        }
                        if (guesses == 1)
                        {
                            hangman[4] = "|     /       ";
                        }
                        if (guesses == 0)
                        {
                            hangman[4] = "|     / \\    ";
                            Console.Clear();
                            Console.WriteLine("*************************************************************");
                            gallows();
                            Console.WriteLine(myWordArray);
                            Console.WriteLine("You are out of guesses");
                            Console.WriteLine("The correct word is " + randomWord);
                        }
                        if (randomWord == s)
                        {
                            Console.Clear();
                            Console.WriteLine("*************************************************************");
                            gallows();
                            Console.WriteLine(randomWord);
                            Console.WriteLine("You Won");
                        }
                    }                  
                }
              
                
            }
        }
        static void lowercase()
        {
            alpha[0] = 'a';
            alpha[1] = 'b';
            alpha[2] = 'c';
            alpha[3] = 'd';
            alpha[4] = 'e';
            alpha[5] = 'f';
            alpha[6] = 'g';
            alpha[7] = 'h';
            alpha[8] = 'i';
            alpha[9] = 'j';
            alpha[10] = 'k';
            alpha[11] = 'l';
            alpha[12] = 'm';
            alpha[13] = 'n';
            alpha[14] = 'o';
            alpha[15] = 'p';
            alpha[16] = 'q';
            alpha[17] = 'r';
            alpha[18] = 's';
            alpha[19] = 't';
            alpha[20] = 'u';
            alpha[21] = 'v';
            alpha[22] = 'w';
            alpha[23] = 'x';
            alpha[24] = 'y';
            alpha[25] = 'z';
        }
        static void uppercase()
        {
            alpha[0] = 'A';
            alpha[1] = 'B';
            alpha[2] = 'C';
            alpha[3] = 'D';
            alpha[4] = 'E';
            alpha[5] = 'F';
            alpha[6] = 'G';
            alpha[7] = 'H';
            alpha[8] = 'I';
            alpha[9] = 'J';
            alpha[10] = 'K';
            alpha[11] = 'L';
            alpha[12] = 'M';
            alpha[13] = 'N';
            alpha[14] = 'O';
            alpha[15] = 'P';
            alpha[16] = 'Q';
            alpha[17] = 'R';
            alpha[18] = 'S';
            alpha[19] = 'T';
            alpha[20] = 'U';
            alpha[21] = 'V';
            alpha[22] = 'W';
            alpha[23] = 'X';
            alpha[24] = 'Y';
            alpha[25] = 'Z';
        }
        static void hangmanwords()
        {
            words[0] = "shop";
            words[1] = "hate";
            words[2] = "balance";
            words[3] = "snail";
            words[4] = "rural";
            words[5] = "plucky";
            words[6] = "tiny";
            words[7] = "tense";
            words[8] = "rainy";
            words[9] = "colossal";
            words[10] = "beg";
            words[11] = "automatic";
            words[12] = "shoes";
            words[13] = "dynamic";
            words[14] = "superb";
            words[15] = "complete";
            words[16] = "muddled";
            words[17] = "afford";
            words[18] = "fantastic";
            words[19] = "witty";
        }
        static void hangmanphrases()
        {
            phrases[0] = "May the force be with you.";
            phrases[1] = "What we've got here is failure to communicate";
            phrases[2] = "There's no place like home";
            phrases[3] = "Show me the money";
            phrases[4] = "I'll be back";
            phrases[5] = "I see dead people";
            phrases[6] = "Houston, we have a problem";
            phrases[7] = "There's no crying in baseball";
            phrases[8] = "Keep your friends close, but your enemies closer";
            phrases[9] = "Hasta la vista, baby";
            phrases[10] = "Why I could make a hat, a brooch, or a pterodactyl";
            phrases[11] = "My precious";
            phrases[12] = "Nobody puts baby in a corner";
            phrases[13] = "African or European swallow";
            phrases[14] = "Now go away or I will taunt you a second time";
            phrases[15] = "To seek the Holy Grail";
            phrases[16] = "I am Arthur, King of the Britons";
            phrases[17] = "I am invincible";
            phrases[18] = "It's just a scratch";
            phrases[19] = "Just a flesh wound";
        }
        static void gallows()
        {
            for (int i = 0; i < hangman.Length; i++)
            {
                Console.WriteLine(hangman[i]);
            }
        }
    }
}
