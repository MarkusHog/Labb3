using Labb3;
using Labb3Library;


namespace WinFormsLabb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillCheckBoxShowLists();
        }

        private void checkedListBoxShowLists_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            
            
        }

        void FillCheckBoxShowLists()
        {

            checkedListBoxShowLists.Items.Add("hel");
            //foreach (var file in Wordlist.GetLists())
            //{
            //    checkedListBoxShowLists.Items.Add(file.ToString());
            //}
        }
    }
}