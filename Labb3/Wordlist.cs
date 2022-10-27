﻿using Labb3;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
            string[] printing = new string[fileArray.Length];
          
                for (int i = 0; i < printing.Length; i++)
                {
                
                    printing[i] = Path.GetFileNameWithoutExtension(fileArray[i]);
                }

            return printing;
        }
        public static Wordlist LoadList(string name) 
        {
            

            string LoacalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(LoacalAppData, "Labb3",$"{name}.dat");
            
           
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                
               
            string[] readlines = File.ReadAllLines(filePath);
            
            string[] languages = readlines[0].Split( ';' );

            Wordlist wordlist = new Wordlist(name, languages);

            for (int i = 0; i < readlines.Length; i++)
            {
                
                if (i > 0)
                {                     
                        {
                            wordlist.Add(readlines[i].Split(';'));  
                        }

                    
                }
                    reader.Close();

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

            if (string.IsNullOrEmpty(translations[0]) || string.IsNullOrEmpty(translations[1]))
            {
                return;
            }
            
            //Words.Add(new Word(translations));
            Words.Add(new Word(translations[0], translations[1]));


            

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

           

      
            int wordCount = Words.Count;

            for (int i = 0; i < wordCount; i++)
            {
                if (Words[i].Translations[translation].Equals(word))
                {
                    Words.RemoveAt(i);
                    wordCount -= 1;
                    return true;
                }
            }
            
  

            return false;
            
        }
        public int Count()
        {
            

            return Words.Count();
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            

            //Words = Words.OrderBy(w = w.Translations) 

            Words = (from w in Words orderby w.Translations[sortByTranslation] select w).ToList();

            
            foreach (Word w in Words)//words
            {
                //showTranslations.Invoke(Translations);
                showTranslations(w.Translations);
                //Console.WriteLine(w.Translations[].ToString());
                //string printOrder = $"w.Translation[sortbytranslation[].ToString()";

            }


            //=> w.Translations[sortByTranslation];
           


        }


        public Word GetWordToPractice()
        {
            int randomTranslation = Random.Shared.Next(0, 1);
            
            int randomW = Random.Shared.Next(Words.Count);
            

            int randomFromLanguage = Random.Shared.Next(0,2);
            
                if (randomFromLanguage == 0) 
            { 
                int randomToLanguage = 1;
                //Word randomWord = new Word(randomFromLanguage, randomToLanguage, Words[randomW].Translations[randomTranslation]);
                //Word randomWord = new Word(randomFromLanguage, randomToLanguage, Words[randomW].Translations[1], Words[randomW].Translations[1]);//.Translations[randomTranslation]);
                //Word randomWord = new Word(0, 1, Words[randomW].Translations[0], Words[randomW].Translations[1]);
                Word randomWord = new Word(0, 1, Words[randomW].Translations);
                return randomWord;
            }
            else 
            { 
               // Word randomWord = new Word(1, 0, Words[randomW].Translations[randomTranslation]);
                //Word randomWord = new Word(1, 0, Words[randomW].Translations[1], Words[randomW].Translations[0]);
                //Word randomWord = new Word(1, 0, Words[randomW].Translations[1], Words[randomW].Translations[0]);
                Word randomWord = new Word(1, 0, Words[randomW].Translations);
              
                return randomWord;
            
            }

           
          
        }

    }
}
