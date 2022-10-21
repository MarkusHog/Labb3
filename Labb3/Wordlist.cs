using Labb3;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Library
{
    public class Wordlist
    {
        private List<Word> Words  = new List<Word>();
        
        private string swedishWord;
        private int totcount;
        private string folderPath;
        private static object name;
        private string translations;
        private object writer;
        private string[] languages;
        private string wordlist;

        public string[] Translations { get; }

        public string Name { get; }
        public string[] Languages { get; }

        

        public Wordlist(string name, params string[] languages)
        {
            this.Name = name;
            Languages = languages;
            Words = new();
            
            //Save();
        }
        public static string[] GetLists()
        {
            string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            string folderPath = Path.Combine(LoacalAppData, "Labb3");
            
            Directory.CreateDirectory(folderPath);
            
            string[] fileArray = Directory.GetFiles(folderPath);
            
            foreach (var file in fileArray)
            {
                //writer.WriteLine(file);
                //string printFilename = Path.GetFileNameWithoutExtension(file);
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
                return fileArray;

        }
        public static Wordlist LoadList(string name) 
        {
            
            string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(LoacalAppData, "Labb3",$"{name}.dat");


            using (StreamReader reader = new StreamReader(filePath))
            {

            //string[] readlines = File.ReadLines(filePath).ToArray();// ToList(); //read to end??
            string[] readlines = File.ReadAllLines(filePath);
            //string[] languages = readlines[0].Split(new[] { ';' },StringSplitOptions.RemoveEmptyEntries);
            
            
            string[] languages = readlines[0].Split( ';' );

                

                Wordlist wordlist = new Wordlist(name, languages);

            for (int i = 0; i < readlines.Length; i++)
            {
                
                if (i > 0)
                {

                        
                        {
                            wordlist.Add(readlines[i].Split(';'));
                            
                        }

                    //Console.WriteLine(readlines[i]);
                }
                    reader.Close();
                    //readlines.Count();
                
           }
            
            return wordlist;
             
            }
            
        }
        public void Save()
        {
            
            string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(LoacalAppData, "Labb3", $"{Name}.dat");

            //File.Create(filePath);

            using (TextWriter writer = new StreamWriter(filePath))
            {

                
                writer.WriteLine($"{Languages[0]};{Languages[1]}");
                //writer.WriteLine();

                //Console.WriteLine($"{Languages[0]};{Languages[1]}");




                for (int i = 0; i < Words.Count; i++)//words
                {

                    {
                        writer.WriteLine($"{Words[i].Translations[0]};{Words[i].Translations[1]}");
                       // i = i + 1;
                        //writer.WriteLine();
                        //Console.WriteLine($"{words[i].Translations[0]};{words[i].Translations[1]}");

                    }
                   

                }
                
            } 
        }
        public void Add(params string[] translations) 
        {
            string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(LoacalAppData, "Labb3", $"{Name}.dat");

            //Word word = new Word(translations[0], translations[1]);
            //Words.Add(new Word(translations[0],translations[1]));//(translations)
            
            Words.Add(new Word(translations));
            
            //TextWriter writer = new StreamWriter(filePath, true);

            //writer.WriteLine($"{translations[0]};{translations[1]}");
            //Words.Add(new Word(translations[0], translations[1]));



            //foreach (var word in translations)
            //{
            //   writer.WriteLine($"{translations[0]};{translations[1]}");
            //    //Words.Add(new Word(translations[0], translations[1]));
            //}


            //writer.Close();                                                     

            
            //Save();
        }

        public bool Remove(int translation, string word)
        {
            if(translation < Languages.Length || translation > Languages.Length)
            {
                return false;
            }
            else
            {
                Words.RemoveAt(translation);
                //words.Remove(word);
                Save();
                return true;
            }
        }
        public int Count()
        {
            //int count = 0;
            //foreach (var item in Words)
            //{
            //    count += 1;
            //}
            //int totcount = count;
            //for (int i = 0; i < Wordlist.Words.Count; i++)
            //{
            //    count += 1;
            //}

            return Words.Count();
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            //string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //string filePath = Path.Combine(LoacalAppData, "Labb3", $"{Name}.dat");
            //StreamReader reader = File.OpenText(filePath);
            //List<string> readlines = File.ReadLines(filePath).ToList();
            //using TextWriter writer = new StreamWriter(filePath);

            //words = words.OrderBy(w = w.Translations) 

            Words = (from w in Words orderby w.Translations[sortByTranslation] select w).ToList();

            
            foreach (Word w in Words)//words
            {
                showTranslations.Invoke(Translations);
                showTranslations(w.Translations);
                Console.WriteLine(Translations);

            }


            //=> w.Translations[sortByTranslation];
           


        }


        //public Word GetWordToPractice()
        //{

        //    //int randomTranslation = Random.Shared.Next(words.Count);
        //    //int randomFromLanguage = Random.Shared.Next(Languages.Length);
        //    //int randomToLanguage = Random.Shared.Next(Languages.Length);
        //    //Word randomWord = new Word(randomFromLanguage, randomToLanguage, words[randomTranslation].Translations);
        //    //int index = Random.Shared.Next(words.Count);
        //    //Word randomWord = words[index];           
        //    return randomWord;
        //}

    }
}
