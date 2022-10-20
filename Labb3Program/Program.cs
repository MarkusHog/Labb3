using Labb3;
using Labb3Library;

//Wordlist a = new Wordlist("Frukt2", "Norska", "Svenska");

//Wordlist fem = new Wordlist("fem", "språk1", "språk2");
//fem.Add("ja", "yes");
//fem.Add("nej", "no");
//fem.Save();
//Wordlist.LoadList("test1").Add("hej", "hallå");
//Wordlist.LoadList("test1").Save();

//Wordlist.LoadList("Frukt").Add("apa","monkey");
//Wordlist.LoadList("Frukt").Add("gris", "Pig");
//Wordlist.LoadList("Frukt").Add("hej", "hello");
//Wordlist.LoadList("Frukt").Save();
//Wordlist.LoadList("Frukt").GetWordToPractice();

////int numberOfWords = b.Count();

//int count = Wordlist.LoadList("Frukt").Count();
//Console.WriteLine(count);


////b.Add("gyrke", "gurka");
//b.Add("gulebölj", "banan");
//b.Add("apple", "äpple");
//b.Add("tomator", "tomat");

////b.List(0, b => Console.WriteLine(b));


//b.Save();


//Wordlist a = Wordlist.LoadList("test2");
//Wordlist a = new Wordlist("Testlista9", "Svenska", "Grekiska");
//a.Add("katt", "cat");
//a.Add("hund", "dog");
//a.Remove(0, "katt");
//a.Save();
//b.Remove(1, "Hundlista");
//Wordlist.LoadList();

//Console.WriteLine();
//b.Save();



//ShowParameter();

//void ShowParameter()
//{

//string input = Console.ReadLine();
//Console.WriteLine(inputChoice.Contains(input));



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

                string language1 = Wordlist.LoadList(input2[1]).Languages[0].ToString();
                string language2 = Wordlist.LoadList(input2[1]).Languages[1].ToString();
                Console.WriteLine($"Enter a word in {language1}");
                string firstWord = Console.ReadLine();
                Console.WriteLine($"Enter a word in {language2}");
                string secondWord = Console.ReadLine();

                Wordlist.LoadList(input2[1]).Add(firstWord, secondWord);
                //Wordlist.LoadList(input2[1]).Save();

                break;

            case "-remove":

                string wordToRemove = input2[3];

                //if (input2[2].Equals(Wordlist.LoadList(input2[1])))

                Wordlist.LoadList(input2[1]).Remove(0, input2[3]);
                Wordlist.LoadList(input2[1]).Save();
                break;


            case "-words":
                Wordlist.LoadList(input2[1]).List(0, w => Console.WriteLine(w));

                break;

            case "-count":

                Wordlist.LoadList(input2[1]).Count();
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



    //Console.WriteLine(input.Equals(inputChoice));

    //Console.WriteLine(beforeLessthen);

    //for (int i = 0; i < 6; i++)
    //{
    //    inputArr[i].Split('<');
    //    Console.WriteLine(inputArr[i]);
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




