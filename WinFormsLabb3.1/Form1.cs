using System.ComponentModel;
using Labb3;
using Labb3Library;

namespace WinFormsLabb3._1
{
    public partial class Form1 : Form
    {
        private string _listName;
        private string _language1;
        private string _language2;
        private string _nameOfList;
        private string _answer;
        private int score;
        private int wrongCount;
        private Word practiceWord;
        private string _word;
        private int _sortLanguage = 0;

        public Form1()
        {
            InitializeComponent();
            ShowAllLists();
            listBoxLists.SelectedItem = listBoxLists.Items[0];
            _nameOfList = listBoxLists.Text.ToLower();
            ChooseWordlist();
            


        }

        private void listBoxLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxShowCorrect.Text = string.Empty;
            _nameOfList = listBoxLists.Text.ToLower();
            ChooseWordlist();
        }

        void ShowAllLists()
        {

            foreach (var file in Wordlist.GetLists())
            {
                listBoxLists.Items.Add(file);
            }
        }

        private void Wordlist_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {

            textBoxShowCorrect.Text = string.Empty;
            NewWordList();
            ListName.Text = String.Empty;
            textBoxLanguage1.Text = String.Empty;
            textBoxLanguage2.Text = String.Empty;
            listBoxLists.Items.Clear();
            ShowAllLists();
        }


        private void ListName_TextChanged(object sender, EventArgs e)
        {
            textBoxShowCorrect.Text = string.Empty;
            _listName = ListName.Text;
        }

        private void textBoxLanguage1_TextChanged(object sender, EventArgs e)
        {
            _language1 = textBoxLanguage1.Text;
        }

        private void textBoxLanguage2_TextChanged(object sender, EventArgs e)
        {
            _language2 = textBoxLanguage2.Text;
        }

        void NewWordList()
        {
            if (_listName == String.Empty || _language1 == String.Empty || _language2 == String.Empty)
            {
                return;
            }
            if (Wordlist.GetLists().Contains(ListName.Text))
            {
                textBoxShowError.Text = "File already exist. Choose other name.";
                return;
            }
            Wordlist wordlist = new Wordlist(_listName, _language1, _language2);
            wordlist.Save();
        }

        private void textBoxPracticeInput_TextChanged(object sender, EventArgs e)
        {
        }

        void PracticeWord()
        {

            Wordlist practiceList = Wordlist.LoadList(_nameOfList);
            Word practiceWord = practiceList.GetWordToPractice();
            string fromLangugage = practiceList.Languages[practiceWord.FromLanguage];
            string toLanguage = practiceList.Languages[practiceWord.ToLanguage];
            string word2Practice = practiceWord.Translations[practiceWord.FromLanguage];
            int randomTranslation = Random.Shared.Next(0, 2);
            textBoxPracticeInput.Text = $"Translate {word2Practice} from {fromLangugage} to {toLanguage}";

        }

        private void listBoxLists_MouseDown(object sender, MouseEventArgs e)
        {
            ChooseWordlist();

        }

        void ChooseWordlist()
        {
            _nameOfList = listBoxLists.Text.ToLower();

            listBoxWords.Items.Clear();
            FillListboxWords();
            labelFirstWord.Text = $"Enter word in {Wordlist.LoadList(_nameOfList).Languages[0]}";
            labelSecondWord.Text = $"Enter word in {Wordlist.LoadList(_nameOfList).Languages[1]}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            textBoxShowCorrect.Text = string.Empty;
            listBoxWords.Items.Clear();
            Practice();


        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheckAnswer_Click(object sender, EventArgs e)
        {
            _answer = textBoxAnswer.Text;
            CheckIfCorrect();
            
        }

        private void textBoxShowResult_TextChanged(object sender, EventArgs e)
        {
        }

        void Practice()
        {

            Wordlist practiceList = Wordlist.LoadList(_nameOfList);
            practiceWord = practiceList.GetWordToPractice();
            string fromLangugage = practiceList.Languages[practiceWord.FromLanguage];
            string toLanguage = practiceList.Languages[practiceWord.ToLanguage];
            string word2Practice = practiceWord.Translations[practiceWord.FromLanguage];
            int randomTranslation = Random.Shared.Next(0, 2);
            int score = 0;
            int wrongCount = 0;
            textBoxPracticeInput.Text = $"Translate {word2Practice} from {fromLangugage} to {toLanguage}";


            _answer = textBoxAnswer.Text;
        }

        void CheckIfCorrect()
        {

            if (_answer == String.Empty)
            {
                return;
            }

            
            if (_answer.ToLower() == practiceWord.Translations[practiceWord.ToLanguage].ToLower())
            {
                textBoxShowCorrect.Text = "Correct!";
                score += 1;
            }
            else
            {
                textBoxShowCorrect.Text =
                    $"Incorrect the correct translation is {practiceWord.Translations[practiceWord.ToLanguage]} ";

                wrongCount += 1;
            }

        }

        void PrintScore()
        {
            textBoxShowCorrect.Text =
                ($"Youre answered {score} correct and {wrongCount} wrong. Percentage correct answers {(float)score / (score + wrongCount) * 100:f0} %");
        }

        private void EndPractice_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = string.Empty;
            textBoxPracticeInput.Text = string.Empty;
            PrintScore();
            wrongCount = 0;
            score = 0;
            FillListboxWords();
        }

        private void buttonNewWord_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = string.Empty;
            textBoxPracticeInput.Text = string.Empty;
            textBoxShowCorrect.Text = string.Empty;
            Practice();

        }

        private void dataGridWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            _word = listBoxWords.Text.ToLower();
        }

        void FillListboxWords()
        {
            listBoxWords.Items.Clear();
            Wordlist wordlist = Wordlist.LoadList(_nameOfList);

            listBoxWords.Items.Add(wordlist.Languages[0] + " ; " + wordlist.Languages[1]);

            wordlist.List(_sortLanguage, PrintSortedWords);

            textBoxShowCount.Text = $"Number of words: {wordlist.Count().ToString()}";

            buttonSortLanguage1.Text = wordlist.Languages[0];
            buttonSortLanguage2.Text = wordlist.Languages[1];

        }

        void PrintSortedWords(string[] translations)
        {


            for (int i = 0; i < translations.Length; i++)
            {


                for (int j = i + 1; j < translations.Length; j++)
                {
                    listBoxWords.Items.Add(translations[i] + " ; " + translations[j]);
                }

            }

        }

        private void textBoxTranslationsFrom_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxWortTo_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wordlist wordlist = Wordlist.LoadList(_nameOfList);
            string translationFrom = textBoxTranslationsFrom.Text.ToLower();

            string translationTo = textBoxWortTo.Text.ToLower();
            if (textBoxTranslationsFrom.Text == string.Empty || textBoxWortTo.Text == String.Empty)
            {
                return;
            }

            Word word = new Word(translationFrom, translationTo);

            wordlist.Add(word.Translations[0], word.Translations[1]);
            listBoxWords.Items.Add(word.Translations[0] + " ; " + word.Translations[1]);
            wordlist.Save();
            textBoxShowCount.Text = $"Number of words: {wordlist.Count()}";
            textBoxTranslationsFrom.Clear();
            textBoxWortTo.Clear();


        }
        private void listBoxWords_MouseClick(object sender, MouseEventArgs e)
        {
            string _word = listBoxWords.Text.ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveWord();
        }

        void RemoveWord()
        {
            Wordlist removelist = Wordlist.LoadList(_nameOfList);
            string wordFirstLanguage = _word.Trim();
            string[] wordToRemove = wordFirstLanguage.Split(";");

            string thisWordWillBeRemoved = wordToRemove[0].Trim();

            if (_word == null)
            {
                return;
            }
            listBoxWords.Items.Remove(_word);

            removelist.Remove(0, thisWordWillBeRemoved);

            removelist.Save();

            textBoxShowCount.Text = $"Number of words: {removelist.Count().ToString()}";

        }

        private void textBoxNumberOfWords_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxShowCount_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonSortLanguage1_Click(object sender, EventArgs e)
        {
            _sortLanguage = 0;
            FillListboxWords();
        }

        private void buttonSortLanguage2_Click(object sender, EventArgs e)
        {
            _sortLanguage = 1;
            FillListboxWords();
        }

        private void labelCount_Click(object sender, EventArgs e)
        {
        }

        private void textBoxShowError_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
