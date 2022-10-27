using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using Labb3;
using Labb3Library;


//Wordlist a = new Wordlist("Frukt2", "Norska", "Svenska");


PrintAlternatives();









    //InputParameter();

    //void InputParameter()
    //{
        string[] inputchoise = new[] { "-add", "-lists", "-new", "-add", "-remove", "-words", "-count", "-practice" };

string input = args[0];// Console.ReadLine().ToLower();

        string[] userInput = input.Split((" "));

    


        switch (userInput[0])
        {


            case "-lists":
                PrintList();
                break;

            case "-new":
                //Wordlist currentWordlist = new Wordlist(userInput[1], userInput[2], userInput[3]);
                Wordlist currentWordlist = new Wordlist(args[1], args[2], args[3]);
        currentWordlist.Save();
                break;

            case "-add":

                AddMethod();
                
                break;

            case "-remove":
                
                RemoveMethod();
            
                break;


            case "-words":

                SortMethod();
             

                break;

            case "-count":

                //Console.WriteLine(Wordlist.LoadList(userInput[1]).Count());
                Console.WriteLine(Wordlist.LoadList(args[1]).Count());

        break;

            case "-practice":
                PracticeMethod();
        

                break;

            default:
                Console.WriteLine("Invalid entry. Try again! ");
                Console.WriteLine();
                break;
        }

    //}

    void PrintAlternatives()
    {
        Console.WriteLine("Enter one of the following parameters: ");
        string[] parameterArray = new[] {
            $"-lists",
            $"-new<list name><language1><language2>",
            "-add<list name>",
            "-remove<list name><language><word1><word2>",
            "-words<listname><sortByLanguage>",
            "-count<listname>",
            "-practice<listname>"
        };
        foreach (var parameter in parameterArray)
        {
            Console.WriteLine(parameter);
        }
        Console.WriteLine();

    }



void PrintList()
{
    Console.WriteLine();
    foreach (var file in Wordlist.GetLists())
    {
        Console.WriteLine(file);

    }
    Console.WriteLine();

}

void AddMethod()
{
    
        Wordlist wordlist = Wordlist.LoadList(userInput[1]);
        string languages1 = wordlist.Languages[0];
        string language2 = wordlist.Languages[1];
        string firstWord;
        string secondWord;

        if (args[1] == null)
        {
            Console.WriteLine("Invalid entry try again.");
        }
        
    do
    {

        Console.WriteLine($"Enter a word in {languages1}");
        firstWord = Console.ReadLine().ToLower();
        if (string.IsNullOrEmpty(firstWord)) return; 
        

        Console.WriteLine($"Enter a word in {language2}");
        secondWord = Console.ReadLine().ToLower();
        if (string.IsNullOrEmpty(secondWord))
        {
            Console.WriteLine($"{firstWord} were not added to the list since no translation was added.");
            return;
        }

        wordlist.Add(firstWord, secondWord);
        wordlist.Save();
        
    } while (!string.IsNullOrEmpty(firstWord) || !string.IsNullOrEmpty(secondWord));

}

void RemoveMethod()
{
    //Wordlist removelist = Wordlist.LoadList(userInput[1]);
    Wordlist removelist = Wordlist.LoadList(args[1]);

    for (int i = 3; i < userInput.Length; i++)
    {

        //string wordToRemove = userInput[i];
        string wordToRemove = args[i];
        //string inputLanguage = userInput[2];
        string inputLanguage = args[2];
        // Word removeWord = new Word(0,1,wordToRemove,"");




        if (wordToRemove == null || inputLanguage == null)
    {
        Console.WriteLine("Invalid input. ");
        return;
    }

    int translation = 3;
    if (inputLanguage.Equals(removelist.Languages[0]))
    {
        translation = 0;

    }

    if (inputLanguage.Equals(removelist.Languages[1]))
    {
        translation = 1;
    }

        
    
    removelist.Remove(translation, wordToRemove);
    
    
    removelist.Save();
    
    }

}

void SortMethod()
{
    if (string.IsNullOrEmpty(userInput[1]))
    {
        Console.WriteLine("Invalid input"); 
        return;
    }

    Wordlist sortList = Wordlist.LoadList(userInput[1]);
    //string inputLanguage2 = userInput[2];
    string inputLanguage2 = args[2];
    int translation2 = 3;

    if (inputLanguage2.Equals(sortList.Languages[0])) { translation2 = 0; }

    if (inputLanguage2.Equals(sortList.Languages[1])) { translation2 = 1; }

    sortList.List(translation2, PrintSortedWords);

}


void PrintSortedWords(string[] translations)
{
    foreach (string word in translations)
    {
        Console.Write(word + ";");
    }
    Console.WriteLine();
}

void PracticeMethod()
{
    Wordlist practiceList = Wordlist.LoadList(userInput[1]);
    int score = 0;
    string practiceInput;
    int wrongCount = 0;
    do
    {

        
        Word practiceWord = practiceList.GetWordToPractice();
        string fromLangugage = practiceList.Languages[practiceWord.FromLanguage];
        string toLanguage = practiceList.Languages[practiceWord.ToLanguage];
        string word2Practice = practiceWord.Translations[practiceWord.FromLanguage]; 
        int randomTranslation = Random.Shared.Next(0, 2);

        Console.WriteLine($"Translate {word2Practice} from {fromLangugage} to {toLanguage}");
        practiceInput = Console.ReadLine();

        if (string.IsNullOrEmpty(practiceInput))
        {
            PrintScore();
        }

        if (practiceInput == practiceWord.Translations[practiceWord.ToLanguage])
        {
            Console.WriteLine("Correct!");
            score += 1;
        }
        else
        {
            Console.WriteLine($"Incorrect the correct translation is {practiceWord.Translations[practiceWord.ToLanguage]} ");
            wrongCount += 1;

        }

    } while (!string.IsNullOrEmpty(practiceInput));

    void PrintScore()
    {
        Console.WriteLine($"Youre answered {score} correct and {wrongCount} wrong. Percentage correct answers {(float)score / (score + wrongCount) * 100:f0} %");

    }


}




