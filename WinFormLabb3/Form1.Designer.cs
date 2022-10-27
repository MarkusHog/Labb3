namespace WinFormLabb3
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWordlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordlistBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wordlistBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.wordlistBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewWordlistToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewWordlistToolStripMenuItem
            // 
            this.addNewWordlistToolStripMenuItem.Name = "addNewWordlistToolStripMenuItem";
            this.addNewWordlistToolStripMenuItem.Size = new System.Drawing.Size(291, 40);
            this.addNewWordlistToolStripMenuItem.Text = "Add new wordlist";
            // 
            // wordlistBindingSource
            // 
            this.wordlistBindingSource.DataSource = typeof(Labb3Library.Wordlist);
            // 
            // wordlistBindingSource1
            // 
            this.wordlistBindingSource1.DataSource = typeof(Labb3Library.Wordlist);
            // 
            // wordlistBindingSource2
            // 
            this.wordlistBindingSource2.DataSource = typeof(Labb3Library.Wordlist);
            // 
            // wordlistBindingSource3
            // 
            this.wordlistBindingSource3.DataSource = typeof(Labb3Library.Wordlist);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 33);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordlistBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addNewWordlistToolStripMenuItem;
        private BindingSource wordlistBindingSource;
        private BindingSource wordlistBindingSource1;
        private BindingSource wordlistBindingSource2;
        private BindingSource wordlistBindingSource3;
        private StatusStrip statusStrip1;
    }
}