
//using Labb3;
//using Labb3Library;

//bool aoa = true;

//do
//{
//    Console.WriteLine();
//    PrintUserOptions();
//    //string[] userInput = Console.ReadLine().Split(" ");
//    UsersChoice();
//} while (aoa == true);

//void UsersChoice()
//{
//    string[] userInput = Console.ReadLine().Split(" ");

//    switch (userInput[0])
//{
//        case "-lists":
//            Console.WriteLine();
//            Wordlist.GetLists();
//            Console.WriteLine();
//    break;

//    case "-new":
//        Wordlist words  = new Wordlist(userInput[1], userInput[2], userInput[3]);
//        words.Save();
//        break;


//    case "-add":

//        string language1 = Wordlist.LoadList(userInput[1]).Languages[0].ToString();
//        string language2 = Wordlist.LoadList(userInput[1]).Languages[1].ToString();
//        int assa = 2;
//        do
//        {          
//            Console.WriteLine($"Enter a word in {language1}");
//            string firstWord = Console.ReadLine();

//            Console.WriteLine($"Enter a word in {language2}");
//            string secondWord = Console.ReadLine();

//            Wordlist.LoadList(userInput[1]).Add(firstWord, secondWord);
 
//        } while (assa == 2);

//        break;

//    case "-remove":
           
//        string wordToRemove = userInput[3];
//        Wordlist wordlist2 = Wordlist.LoadList(userInput[1]);

//        Wordlist.LoadList(userInput[1]).Remove(0, userInput[3]);
//        Wordlist.LoadList(userInput[1]).Save();
//        break;


//    case "-words":
//        Wordlist.LoadList(userInput[1]).List(0, w => Console.WriteLine(w));

//        break;

//    case "-count":
        
//            Console.WriteLine(Wordlist.LoadList(userInput[1]).Count());
//            Console.WriteLine();
            

           
            
//        break;

//    case "-practice":
        

//        break;

//}
//}





//void PrintUserOptions()
//{
//    Console.WriteLine("Enter one of the following parameters: ");
//    string[] parameterArray = {
//        $"-lists",
//        $"-new<list name><language1><language2>",
//        "-add<list name>",
//        "-remove<list name><language><word1><word2>",
//        "-words<listname><sortByLanguage>",
//        "-count<listname>",
//        "-practice<listname>" };

//    foreach (var parameter in parameterArray)
//    {
//        Console.WriteLine(parameter);
//        //Write-Host (parameter);
//    }

//}



