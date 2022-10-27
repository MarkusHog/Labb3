namespace WinFormsLabb3
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
            System.Windows.Forms.CheckedListBox checkedListBoxShowLists;
            this.buttonAdd = new System.Windows.Forms.Button();
            checkedListBoxShowLists = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxShowLists
            // 
            checkedListBoxShowLists.CheckOnClick = true;
            checkedListBoxShowLists.FormattingEnabled = true;
            checkedListBoxShowLists.Location = new System.Drawing.Point(70, 105);
            checkedListBoxShowLists.Name = "checkedListBoxShowLists";
            checkedListBoxShowLists.Size = new System.Drawing.Size(294, 68);
            checkedListBoxShowLists.TabIndex = 0;
            checkedListBoxShowLists.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxShowLists_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(400, 106);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 40);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(checkedListBoxShowLists);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBoxShowLists;
        private Button buttonAdd;
    }
}