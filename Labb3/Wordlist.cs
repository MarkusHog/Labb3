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
        
        private static List<Word> words = new List<Word>();
        private string swedishWord;

        private string folderPath;
        private static object name;
        private string translations;
        private object writer;
        private string[] languages;

        public string[] Translations { get; }

        public string Name { get; }
        public string[] Languages { get; }

        

        public Wordlist(string name, params string[] languages)
        {
            this.Name = name;
            Languages = languages;
            words = new();
            
            //Save();
        }
        public static string[] GetLists()
        {
            string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            string folderPath = Path.Combine(LoacalAppData, "Labb3");
            //using TextWriter writer = new StreamWriter(folderPath);
            //@"C:\Users\marku\AppData\Local\Labb3";
            //string folderPath = @"C:\Users\\AppData\Local\Labb3";
            Directory.CreateDirectory(folderPath);
            
            string[] fileArray = Directory.GetFiles(folderPath);
            
            foreach (var file in fileArray)
            {
                //Path.GetFileNameWithoutExtension(file);
                //writer.WriteLine(file);
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
                return fileArray;

        }
        public static Wordlist LoadList(string name) 
        {
            
            string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(LoacalAppData, "Labb3",$"{name}.dat");


            //using (StreamReader reader = new StreamReader(filePath))
            //{

            //StreamReader reader = File.OpenText(filePath);//

            //string[] readlines = File.ReadLines(filePath).ToArray();// ToList(); //read to end??
            string[] readlines =File.ReadAllLines(filePath);
            //string[] languages = readlines[0]?.Split(new[] { ';' },StringSplitOptions.RemoveEmptyEntries);

            
            string[] languages = readlines[0].Split( ';' );
            
              //string[] languages = readlines[0].Split(new[] { ';' });
           

           

            for (int i = 0; i < readlines.Length; i++)
            {
                //words.Add(new Word(readlines[i]?.Split(new[] { ',' })));
                if (i > 0)
                {

                    words.Add(new Word(readlines[i].Split( ',' )));
                    
                    //Console.WriteLine(readlines[i]);
                }

                    //readlines.Count();
                
           }
         
            return new Wordlist(name,languages);
             
            //}
            
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




                for (int i = 0; i < words.Count; i++)//words
                {

                    {
                        writer.WriteLine($"{words[i].Translations[0]};{words[i].Translations[1]}");
                        i = i + 1;
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
            words.Add(new Word(translations[0],translations[1]));

            using TextWriter writer = new StreamWriter(filePath,true);


            foreach (var word in words)
            {
                writer.WriteLine($"{translations[0]};{translations[1]}");

            }
                                                                 

            
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
                words.RemoveAt(translation);
                //words.Remove(word);
                Save();
                return true;
            }
        }
        public int Count()
        {


            
            //for (int i = 0; i < words.Count; i++)
            //{
            //    count += 1;
            //}

            return words.Count;
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            //string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //string filePath = Path.Combine(LoacalAppData, "Labb3", $"{Name}.dat");
            //StreamReader reader = File.OpenText(filePath);
            //List<string> readlines = File.ReadLines(filePath).ToList();
            //using TextWriter writer = new StreamWriter(filePath);

            //words = words.OrderBy(w = w.Translations) 

            words = (from w in words orderby w.Translations[sortByTranslation] select w).ToList();

            
            foreach (Word w in words)//words
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
