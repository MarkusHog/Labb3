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
        string[] inputchoise = new[] { "-lists", "-new", "-add", "-remove", "-words", "-count", "-practice" };

        string input = Console.ReadLine();

        if (input == parameterArray[0]) Wordlist.GetLists();



        string[] input2 = input.Split((" "));



        switch (input2[0])
        {
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

                break;

            case "-remove":

                string wordToRemove = input2[3];
                Wordlist removelist = Wordlist.LoadList(input2[1]);
                removelist.Remove(0,wordToRemove);
               

                //Predicate<Word> sameAs = word => word.Equals(wordToRemove);
                //Predicate<Wordlist> l1 = l => l.Equals(wordToRemove);

                // if (input2[3].Equals(Wordlist.LoadList(input2[1])))

                
                //Wordlist.LoadList(input2[1]).Remove(0, input2[3]);
                removelist.Save();
                break;


            case "-words":

                Wordlist sortList = Wordlist.LoadList(input2[1]);
                sortList.List(0, w => Console.WriteLine(w));

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
                //Wordlist.LoadList(input2[1]).GetWordToPractice();
                
                break;

        }




    }
} while (abc == 10);

  











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




