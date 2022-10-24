using Labb3;
using Labb3Library;


//Wordlist a = new Wordlist("Frukt2", "Norska", "Svenska");


int abc = 10;
do
{

    Console.WriteLine("Enter one of the following parameters: ");
    string[] parameterArray = {
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
    InputParameter();

    void InputParameter()
    {
        string[] inputchoise = new[] { "-add", "-lists", "-new", "-add", "-remove", "-words", "-count", "-practice" };

        string input = Console.ReadLine().ToLower();

        string[] input2 = input.Split((" "));




        switch (input2[0])
        {


            case "-lists":
                PrintList();

                break;


            case "-new":
                Wordlist currentWordlist = new Wordlist(input2[1], input2[2], input2[3]);

                currentWordlist.Save();
                break;

            case "-add":


                Wordlist wordlist = Wordlist.LoadList(input2[1]);
                string languages1 = wordlist.Languages[0];

                string language2 = wordlist.Languages[1];
                Console.WriteLine($"Enter a word in {languages1}");

                string firstWord = Console.ReadLine();
                Console.WriteLine($"Enter a word in {language2}");
                string secondWord = Console.ReadLine();


                wordlist.Add(firstWord, secondWord);
                wordlist.Save();
                if (!string.IsNullOrEmpty(firstWord) || !string.IsNullOrEmpty(secondWord)) goto case "-add";




                break;

            case "-remove":

                Wordlist removelist = Wordlist.LoadList(input2[1]);

                string wordToRemove = input2[3];
                string inputLanguage = input2[2];

                if (wordToRemove == null || inputLanguage == null)
                {
                    Console.WriteLine("Invalid input. Try again!");
                    goto case "-remove";
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
                break;


            case "-words":
                Wordlist sortList = Wordlist.LoadList(input2[1]);
                string inputLanguage2 = input2[2];
                int translation2 = 3;
                if (inputLanguage2.Equals(sortList.Languages[0]))
                {
                    translation2 = 0;
                }

                if (inputLanguage2.Equals(sortList.Languages[1]))
                {
                    translation2 = 1;
                }

                sortList.List(translation2, PrintSortedWords);


                //Console.WriteLine();

                break;

            case "-count":
                Wordlist.LoadList(input2[1]).Save();
                Console.WriteLine(Wordlist.LoadList(input2[1]).Count());
                //Wordlist.LoadList(input2[1]).Count();


                //Console.WriteLine(Wordlist.LoadList(input2[1]).Count());
                //Console.WriteLine(Wordlist.LoadList(input2[1]).Count());
                //int count = input2[1].Count();

                //input2[1].Count();
                break;

            case "-practice":
                    Wordlist practiceList = Wordlist.LoadList(input2[1]);
                    int score = 0;
                    string practiceInput;
                    int wrongCount = 0;
                do
                {

                    //Console.WriteLine(string.Join(";", practiceList.GetWordToPractice().Translations));
                    Word practiceWord = practiceList.GetWordToPractice();
                    string fromLangugage = practiceList.Languages[practiceWord.FromLanguage];
                    string toLanguage = practiceList.Languages[practiceWord.ToLanguage];
                    string word2Practice = practiceWord.Translations[practiceWord.FromLanguage]; // joel
                    int randomTranslation = Random.Shared.Next(0, 2);

                    Console.WriteLine(
                        $"Translate {word2Practice} from {fromLangugage} to {toLanguage}");
                    practiceInput = Console.ReadLine();

                    if(string.IsNullOrEmpty(practiceInput))
                    {
                        PrintScore();
                    }

                    if (practiceInput == practiceWord.Translations[practiceWord.ToLanguage])
                    {
                        Console.WriteLine("Correct!");
                        score += 1;
                    }
                    if(practiceInput != practiceWord.Translations[practiceWord.ToLanguage] )
                    {
                        Console.WriteLine($"Incorrect the correct translation is {practiceWord.Translations[1]} ");
                        wrongCount += 1;

                    }

              
                    
                } while (!string.IsNullOrEmpty(practiceInput));

                    void PrintScore()
                    {
                        Console.WriteLine($"Youre answered {score} correct and {wrongCount} wrong. Percentage correct answears {(float)score / (score+wrongCount)*100:f0} %");

                    }

                break;

                    default:
                    Console.WriteLine("Invalid entry. Try again! ");
                    Console.WriteLine();
                    break;
                }

    }
} while (abc == 10);



void PrintList()
{
    Console.WriteLine();
    foreach (var file in Wordlist.GetLists())
    {
        Console.WriteLine(file);

    }
    Console.WriteLine();

}



void PrintSortedWords(string[] translations)
{
    foreach (string word in translations)
    {
        Console.Write(word+";");
    }
    Console.WriteLine();
}



//void CantLoadWordlist()
//{
    
//    if (Wordlist.LoadList(name == string.Empty)
//}


//void PrintList()
//{
//    foreach (var item in Wordlist.GetLists())
//    {
//        Console.WriteLine(item.);
//    }

//}





//    //{
//    //    Wordlist.GetLists();
//    //}
//    //string[] inputArr = parameterArray[1].Split('<');

////    if (input == parameterArray[1].Split('<'))
////    {
////        Console.WriteLine("TJena");
////        //Wordlist string[] languages = input.Split(new[] {'<'});

////    //    _= new Wordlist(input[0], input[1], input[2]);
////    }
////}








////b.GetWordToPractice();
////Console.WriteLine(b.GetWordToPractice());
//////Console.WriteLine(b.GetWordToPractice());
////Word k = new(0, 1, "Hej", "Hello");




//Wordlist a = new Wordlist("SwedishToEnglish","Swedish","English");
////Wordlist.GetLists();
////////Console.WriteLine(Wordlist.LoadList());
////////Wordlist.GetLists();
//a.Add("Potatis", "Potato");
//a.Add("Tomat", "Tomato");//
//Console.WriteLine();

////Wordlist.LoadList("SwedishToEnglish");
////a.List(0, a => Console.WriteLine(a));
//a.Remove(1, "Potato");
////a.Save();

////////a.Add("Bord", "Table", "xxxxx");

////////Console.WriteLine(a.Count());




