namespace HangmanGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPanelDrawing = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWordLength = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstMissedWords = new System.Windows.Forms.ListBox();
            this.lblMissedWords = new System.Windows.Forms.Label();
            this.txtMissedLetters = new System.Windows.Forms.TextBox();
            this.lblMissedLetters = new System.Windows.Forms.Label();
            this.gbUserGuess = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtword = new System.Windows.Forms.TextBox();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnGuessWord = new System.Windows.Forms.Button();
            this.btnGuessLetter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forfeitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPanelDrawing.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbUserGuess.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPanelDrawing
            // 
            this.gbPanelDrawing.Controls.Add(this.panel1);
            this.gbPanelDrawing.Location = new System.Drawing.Point(435, 38);
            this.gbPanelDrawing.Name = "gbPanelDrawing";
            this.gbPanelDrawing.Size = new System.Drawing.Size(272, 404);
            this.gbPanelDrawing.TabIndex = 0;
            this.gbPanelDrawing.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 385);
            this.panel1.TabIndex = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWordLength);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblWordLength
            // 
            this.lblWordLength.AutoSize = true;
            this.lblWordLength.Location = new System.Drawing.Point(7, 131);
            this.lblWordLength.Name = "lblWordLength";
            this.lblWordLength.Size = new System.Drawing.Size(68, 13);
            this.lblWordLength.TabIndex = 0;
            this.lblWordLength.Text = "Word length:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstMissedWords);
            this.groupBox3.Controls.Add(this.lblMissedWords);
            this.groupBox3.Controls.Add(this.txtMissedLetters);
            this.groupBox3.Controls.Add(this.lblMissedLetters);
            this.groupBox3.Location = new System.Drawing.Point(15, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lstMissedWords
            // 
            this.lstMissedWords.BackColor = System.Drawing.SystemColors.Control;
            this.lstMissedWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMissedWords.FormattingEnabled = true;
            this.lstMissedWords.Location = new System.Drawing.Point(91, 43);
            this.lstMissedWords.Name = "lstMissedWords";
            this.lstMissedWords.Size = new System.Drawing.Size(320, 93);
            this.lstMissedWords.TabIndex = 100;
            this.lstMissedWords.TabStop = false;
            // 
            // lblMissedWords
            // 
            this.lblMissedWords.AutoSize = true;
            this.lblMissedWords.Location = new System.Drawing.Point(7, 46);
            this.lblMissedWords.Name = "lblMissedWords";
            this.lblMissedWords.Size = new System.Drawing.Size(77, 13);
            this.lblMissedWords.TabIndex = 211;
            this.lblMissedWords.Text = "Missed Words:";
            // 
            // txtMissedLetters
            // 
            this.txtMissedLetters.Location = new System.Drawing.Point(91, 17);
            this.txtMissedLetters.MaxLength = 26;
            this.txtMissedLetters.Name = "txtMissedLetters";
            this.txtMissedLetters.ReadOnly = true;
            this.txtMissedLetters.Size = new System.Drawing.Size(320, 20);
            this.txtMissedLetters.TabIndex = 101;
            this.txtMissedLetters.TabStop = false;
            // 
            // lblMissedLetters
            // 
            this.lblMissedLetters.AutoSize = true;
            this.lblMissedLetters.Location = new System.Drawing.Point(7, 20);
            this.lblMissedLetters.Name = "lblMissedLetters";
            this.lblMissedLetters.Size = new System.Drawing.Size(78, 13);
            this.lblMissedLetters.TabIndex = 10;
            this.lblMissedLetters.Text = "Missed Letters:";
            // 
            // gbUserGuess
            // 
            this.gbUserGuess.Controls.Add(this.label2);
            this.gbUserGuess.Controls.Add(this.label1);
            this.gbUserGuess.Controls.Add(this.txtword);
            this.gbUserGuess.Controls.Add(this.txtLetter);
            this.gbUserGuess.Controls.Add(this.btnGuessWord);
            this.gbUserGuess.Controls.Add(this.btnGuessLetter);
            this.gbUserGuess.Location = new System.Drawing.Point(12, 361);
            this.gbUserGuess.Name = "gbUserGuess";
            this.gbUserGuess.Size = new System.Drawing.Size(417, 81);
            this.gbUserGuess.TabIndex = 3;
            this.gbUserGuess.TabStop = false;
            this.gbUserGuess.Text = "Guess a Letter or Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Word:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Letter:";
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(243, 21);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(100, 20);
            this.txtword.TabIndex = 2;
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(115, 21);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(21, 20);
            this.txtLetter.TabIndex = 0;
            // 
            // btnGuessWord
            // 
            this.btnGuessWord.Location = new System.Drawing.Point(255, 47);
            this.btnGuessWord.Name = "btnGuessWord";
            this.btnGuessWord.Size = new System.Drawing.Size(75, 23);
            this.btnGuessWord.TabIndex = 3;
            this.btnGuessWord.Text = "Guess Word";
            this.btnGuessWord.UseVisualStyleBackColor = true;
            this.btnGuessWord.Click += new System.EventHandler(this.btnGuessWord_Click);
            // 
            // btnGuessLetter
            // 
            this.btnGuessLetter.Location = new System.Drawing.Point(77, 47);
            this.btnGuessLetter.Name = "btnGuessLetter";
            this.btnGuessLetter.Size = new System.Drawing.Size(75, 23);
            this.btnGuessLetter.TabIndex = 1;
            this.btnGuessLetter.Text = "Guess Letter";
            this.btnGuessLetter.UseVisualStyleBackColor = true;
            this.btnGuessLetter.Click += new System.EventHandler(this.btnGuessLetter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.forfeitGameToolStripMenuItem,
            this.quitExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // forfeitGameToolStripMenuItem
            // 
            this.forfeitGameToolStripMenuItem.Name = "forfeitGameToolStripMenuItem";
            this.forfeitGameToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.forfeitGameToolStripMenuItem.Text = "Forfeit Game";
            this.forfeitGameToolStripMenuItem.Click += new System.EventHandler(this.forfeitGameToolStripMenuItem_Click);
            // 
            // quitExitToolStripMenuItem
            // 
            this.quitExitToolStripMenuItem.Name = "quitExitToolStripMenuItem";
            this.quitExitToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.quitExitToolStripMenuItem.Text = "Quit/Exit";
            this.quitExitToolStripMenuItem.Click += new System.EventHandler(this.quitExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(719, 459);
            this.Controls.Add(this.gbUserGuess);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPanelDrawing);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman By: John Silvey";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbPanelDrawing.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbUserGuess.ResumeLayout(false);
            this.gbUserGuess.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPanelDrawing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbUserGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnGuessWord;
        private System.Windows.Forms.Button btnGuessLetter;
        private System.Windows.Forms.ListBox lstMissedWords;
        private System.Windows.Forms.Label lblMissedWords;
        private System.Windows.Forms.TextBox txtMissedLetters;
        private System.Windows.Forms.Label lblMissedLetters;
        private System.Windows.Forms.Label lblWordLength;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forfeitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitExitToolStripMenuItem;
    }
}

