using Labb3Library;

namespace WinFormsLabb3._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxLists = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBoxAddLists = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLanguage2 = new System.Windows.Forms.TextBox();
            this.textBoxLanguage1 = new System.Windows.Forms.TextBox();
            this.ListName = new System.Windows.Forms.TextBox();
            this.groupBoxPractice = new System.Windows.Forms.GroupBox();
            this.buttonNewWord = new System.Windows.Forms.Button();
            this.textBoxShowCorrect = new System.Windows.Forms.TextBox();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.EndPractice = new System.Windows.Forms.Button();
            this.buttonCheckAnswer = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxPracticeInput = new System.Windows.Forms.TextBox();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.goupAddWord = new System.Windows.Forms.GroupBox();
            this.labelSecondWord = new System.Windows.Forms.Label();
            this.labelFirstWord = new System.Windows.Forms.Label();
            this.textBoxWortTo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTranslationsFrom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxShowCount = new System.Windows.Forms.TextBox();
            this.buttonSortLanguage1 = new System.Windows.Forms.Button();
            this.buttonSortLanguage2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxShowError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBoxAddLists.SuspendLayout();
            this.groupBoxPractice.SuspendLayout();
            this.goupAddWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLists
            // 
            this.listBoxLists.FormattingEnabled = true;
            this.listBoxLists.ItemHeight = 20;
            this.listBoxLists.Location = new System.Drawing.Point(17, 51);
            this.listBoxLists.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLists.Name = "listBoxLists";
            this.listBoxLists.Size = new System.Drawing.Size(165, 144);
            this.listBoxLists.TabIndex = 0;
            this.listBoxLists.SelectedIndexChanged += new System.EventHandler(this.listBoxLists_SelectedIndexChanged);
            this.listBoxLists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxLists_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Wordlist";
            this.label1.Click += new System.EventHandler(this.Wordlist_Click);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(0, 186);
            this.buttonAddList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(155, 31);
            this.buttonAddList.TabIndex = 5;
            this.buttonAddList.Text = "Add ";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBoxAddLists
            // 
            this.groupBoxAddLists.Controls.Add(this.label4);
            this.groupBoxAddLists.Controls.Add(this.label3);
            this.groupBoxAddLists.Controls.Add(this.label2);
            this.groupBoxAddLists.Controls.Add(this.textBoxLanguage2);
            this.groupBoxAddLists.Controls.Add(this.buttonAddList);
            this.groupBoxAddLists.Controls.Add(this.textBoxLanguage1);
            this.groupBoxAddLists.Controls.Add(this.ListName);
            this.groupBoxAddLists.Location = new System.Drawing.Point(17, 205);
            this.groupBoxAddLists.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAddLists.Name = "groupBoxAddLists";
            this.groupBoxAddLists.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAddLists.Size = new System.Drawing.Size(164, 221);
            this.groupBoxAddLists.TabIndex = 3;
            this.groupBoxAddLists.TabStop = false;
            this.groupBoxAddLists.Text = "Add new list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Second Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter List Name";
            // 
            // textBoxLanguage2
            // 
            this.textBoxLanguage2.Location = new System.Drawing.Point(0, 153);
            this.textBoxLanguage2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLanguage2.Name = "textBoxLanguage2";
            this.textBoxLanguage2.Size = new System.Drawing.Size(156, 27);
            this.textBoxLanguage2.TabIndex = 4;
            this.textBoxLanguage2.TextChanged += new System.EventHandler(this.textBoxLanguage2_TextChanged);
            // 
            // textBoxLanguage1
            // 
            this.textBoxLanguage1.Location = new System.Drawing.Point(0, 106);
            this.textBoxLanguage1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLanguage1.Name = "textBoxLanguage1";
            this.textBoxLanguage1.Size = new System.Drawing.Size(156, 27);
            this.textBoxLanguage1.TabIndex = 3;
            this.textBoxLanguage1.TextChanged += new System.EventHandler(this.textBoxLanguage1_TextChanged);
            // 
            // ListName
            // 
            this.ListName.Location = new System.Drawing.Point(0, 55);
            this.ListName.Margin = new System.Windows.Forms.Padding(2);
            this.ListName.Name = "ListName";
            this.ListName.Size = new System.Drawing.Size(156, 27);
            this.ListName.TabIndex = 2;
            this.ListName.TextChanged += new System.EventHandler(this.ListName_TextChanged);
            // 
            // groupBoxPractice
            // 
            this.groupBoxPractice.Controls.Add(this.buttonNewWord);
            this.groupBoxPractice.Controls.Add(this.textBoxShowCorrect);
            this.groupBoxPractice.Controls.Add(this.buttonPractice);
            this.groupBoxPractice.Controls.Add(this.EndPractice);
            this.groupBoxPractice.Controls.Add(this.buttonCheckAnswer);
            this.groupBoxPractice.Controls.Add(this.textBoxAnswer);
            this.groupBoxPractice.Controls.Add(this.textBoxPracticeInput);
            this.groupBoxPractice.Location = new System.Drawing.Point(268, 332);
            this.groupBoxPractice.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPractice.Name = "groupBoxPractice";
            this.groupBoxPractice.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPractice.Size = new System.Drawing.Size(398, 221);
            this.groupBoxPractice.TabIndex = 4;
            this.groupBoxPractice.TabStop = false;
            this.groupBoxPractice.Text = "Practice";
            // 
            // buttonNewWord
            // 
            this.buttonNewWord.Location = new System.Drawing.Point(272, 96);
            this.buttonNewWord.Name = "buttonNewWord";
            this.buttonNewWord.Size = new System.Drawing.Size(107, 25);
            this.buttonNewWord.TabIndex = 5;
            this.buttonNewWord.Text = "New Word";
            this.buttonNewWord.UseVisualStyleBackColor = true;
            this.buttonNewWord.Click += new System.EventHandler(this.buttonNewWord_Click);
            // 
            // textBoxShowCorrect
            // 
            this.textBoxShowCorrect.Location = new System.Drawing.Point(4, 141);
            this.textBoxShowCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxShowCorrect.Multiline = true;
            this.textBoxShowCorrect.Name = "textBoxShowCorrect";
            this.textBoxShowCorrect.Size = new System.Drawing.Size(376, 70);
            this.textBoxShowCorrect.TabIndex = 7;
            // 
            // buttonPractice
            // 
            this.buttonPractice.Location = new System.Drawing.Point(5, 24);
            this.buttonPractice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(115, 27);
            this.buttonPractice.TabIndex = 5;
            this.buttonPractice.Text = "Practice";
            this.buttonPractice.UseVisualStyleBackColor = true;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // EndPractice
            // 
            this.EndPractice.Location = new System.Drawing.Point(125, 25);
            this.EndPractice.Name = "EndPractice";
            this.EndPractice.Size = new System.Drawing.Size(134, 26);
            this.EndPractice.TabIndex = 6;
            this.EndPractice.Text = "End Practice";
            this.EndPractice.UseVisualStyleBackColor = true;
            this.EndPractice.Click += new System.EventHandler(this.EndPractice_Click);
            // 
            // buttonCheckAnswer
            // 
            this.buttonCheckAnswer.Location = new System.Drawing.Point(201, 94);
            this.buttonCheckAnswer.Name = "buttonCheckAnswer";
            this.buttonCheckAnswer.Size = new System.Drawing.Size(66, 27);
            this.buttonCheckAnswer.TabIndex = 2;
            this.buttonCheckAnswer.Text = "Check";
            this.buttonCheckAnswer.UseVisualStyleBackColor = true;
            this.buttonCheckAnswer.Click += new System.EventHandler(this.buttonCheckAnswer_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(5, 97);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(189, 27);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxAnswer_TextChanged);
            // 
            // textBoxPracticeInput
            // 
            this.textBoxPracticeInput.Location = new System.Drawing.Point(5, 55);
            this.textBoxPracticeInput.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPracticeInput.Name = "textBoxPracticeInput";
            this.textBoxPracticeInput.Size = new System.Drawing.Size(376, 27);
            this.textBoxPracticeInput.TabIndex = 0;
            this.textBoxPracticeInput.TextChanged += new System.EventHandler(this.textBoxPracticeInput_TextChanged);
            // 
            // listBoxWords
            // 
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.ItemHeight = 20;
            this.listBoxWords.Location = new System.Drawing.Point(237, 51);
            this.listBoxWords.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(174, 144);
            this.listBoxWords.TabIndex = 5;
            this.listBoxWords.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxWords_MouseClick);
            this.listBoxWords.SelectedIndexChanged += new System.EventHandler(this.listBoxWords_SelectedIndexChanged);
            // 
            // goupAddWord
            // 
            this.goupAddWord.Controls.Add(this.labelSecondWord);
            this.goupAddWord.Controls.Add(this.labelFirstWord);
            this.goupAddWord.Controls.Add(this.textBoxWortTo);
            this.goupAddWord.Controls.Add(this.button1);
            this.goupAddWord.Controls.Add(this.textBoxTranslationsFrom);
            this.goupAddWord.Location = new System.Drawing.Point(444, 45);
            this.goupAddWord.Margin = new System.Windows.Forms.Padding(2);
            this.goupAddWord.Name = "goupAddWord";
            this.goupAddWord.Padding = new System.Windows.Forms.Padding(2);
            this.goupAddWord.Size = new System.Drawing.Size(151, 175);
            this.goupAddWord.TabIndex = 6;
            this.goupAddWord.TabStop = false;
            this.goupAddWord.Text = "Add New Word";
            // 
            // labelSecondWord
            // 
            this.labelSecondWord.AutoSize = true;
            this.labelSecondWord.Location = new System.Drawing.Point(0, 78);
            this.labelSecondWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSecondWord.Name = "labelSecondWord";
            this.labelSecondWord.Size = new System.Drawing.Size(81, 20);
            this.labelSecondWord.TabIndex = 8;
            this.labelSecondWord.Text = "Enter word";
            // 
            // labelFirstWord
            // 
            this.labelFirstWord.AutoSize = true;
            this.labelFirstWord.Location = new System.Drawing.Point(4, 23);
            this.labelFirstWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstWord.Name = "labelFirstWord";
            this.labelFirstWord.Size = new System.Drawing.Size(81, 20);
            this.labelFirstWord.TabIndex = 7;
            this.labelFirstWord.Text = "Enter word";
            // 
            // textBoxWortTo
            // 
            this.textBoxWortTo.Location = new System.Drawing.Point(0, 106);
            this.textBoxWortTo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWortTo.Name = "textBoxWortTo";
            this.textBoxWortTo.Size = new System.Drawing.Size(152, 27);
            this.textBoxWortTo.TabIndex = 5;
            this.textBoxWortTo.TextChanged += new System.EventHandler(this.textBoxWortTo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTranslationsFrom
            // 
            this.textBoxTranslationsFrom.Location = new System.Drawing.Point(0, 45);
            this.textBoxTranslationsFrom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTranslationsFrom.Name = "textBoxTranslationsFrom";
            this.textBoxTranslationsFrom.Size = new System.Drawing.Size(152, 27);
            this.textBoxTranslationsFrom.TabIndex = 4;
            this.textBoxTranslationsFrom.TextChanged += new System.EventHandler(this.textBoxTranslationsFrom_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 301);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxShowCount
            // 
            this.textBoxShowCount.Location = new System.Drawing.Point(236, 205);
            this.textBoxShowCount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxShowCount.Name = "textBoxShowCount";
            this.textBoxShowCount.ReadOnly = true;
            this.textBoxShowCount.Size = new System.Drawing.Size(174, 27);
            this.textBoxShowCount.TabIndex = 0;
            this.textBoxShowCount.Visible = false;
            this.textBoxShowCount.TextChanged += new System.EventHandler(this.textBoxShowCount_TextChanged);
            // 
            // buttonSortLanguage1
            // 
            this.buttonSortLanguage1.Location = new System.Drawing.Point(237, 255);
            this.buttonSortLanguage1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSortLanguage1.Name = "buttonSortLanguage1";
            this.buttonSortLanguage1.Size = new System.Drawing.Size(79, 27);
            this.buttonSortLanguage1.TabIndex = 8;
            this.buttonSortLanguage1.Text = "button3";
            this.buttonSortLanguage1.UseVisualStyleBackColor = true;
            this.buttonSortLanguage1.Click += new System.EventHandler(this.buttonSortLanguage1_Click);
            // 
            // buttonSortLanguage2
            // 
            this.buttonSortLanguage2.Location = new System.Drawing.Point(329, 255);
            this.buttonSortLanguage2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSortLanguage2.Name = "buttonSortLanguage2";
            this.buttonSortLanguage2.Size = new System.Drawing.Size(81, 27);
            this.buttonSortLanguage2.TabIndex = 9;
            this.buttonSortLanguage2.Text = "button4";
            this.buttonSortLanguage2.UseVisualStyleBackColor = true;
            this.buttonSortLanguage2.Click += new System.EventHandler(this.buttonSortLanguage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sort by language";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxShowError
            // 
            this.textBoxShowError.Location = new System.Drawing.Point(21, 447);
            this.textBoxShowError.Multiline = true;
            this.textBoxShowError.Name = "textBoxShowError";
            this.textBoxShowError.ReadOnly = true;
            this.textBoxShowError.Size = new System.Drawing.Size(161, 65);
            this.textBoxShowError.TabIndex = 11;
            this.textBoxShowError.TextChanged += new System.EventHandler(this.textBoxShowError_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 569);
            this.Controls.Add(this.textBoxShowError);
            this.Controls.Add(this.groupBoxPractice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSortLanguage2);
            this.Controls.Add(this.buttonSortLanguage1);
            this.Controls.Add(this.textBoxShowCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.goupAddWord);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.groupBoxAddLists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLists);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(755, 638);
            this.MinimumSize = new System.Drawing.Size(755, 616);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBoxAddLists.ResumeLayout(false);
            this.groupBoxAddLists.PerformLayout();
            this.groupBoxPractice.ResumeLayout(false);
            this.groupBoxPractice.PerformLayout();
            this.goupAddWord.ResumeLayout(false);
            this.goupAddWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxLists;
        private Label label1;
        private Button buttonAddList;
        private FileSystemWatcher fileSystemWatcher1;
        private GroupBox groupBoxAddLists;
        private TextBox textBoxLanguage2;
        private TextBox textBoxLanguage1;
        private TextBox ListName;
        private GroupBox groupBoxPractice;
        private TextBox textBoxPracticeInput;
        private Button buttonPractice;
        private TextBox textBoxAnswer;
        private Button buttonCheckAnswer;
        private Button EndPractice;
        private TextBox textBoxShowCorrect;
        private Button buttonNewWord;
        private ListBox listBoxWords;
        private GroupBox goupAddWord;
        private TextBox textBoxWortTo;
        private Button button1;
        private TextBox textBoxTranslationsFrom;
        private Label labelFirstWord;
        private Label labelSecondWord;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxShowCount;
        private Button buttonSortLanguage2;
        private Button buttonSortLanguage1;
        private Label label5;
        private TextBox textBoxShowError;
    }
}