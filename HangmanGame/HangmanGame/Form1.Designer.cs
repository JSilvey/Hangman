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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbUserGuess = new System.Windows.Forms.GroupBox();
            this.btnGuessLetter = new System.Windows.Forms.Button();
            this.btnGuessWord = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMissedLetters = new System.Windows.Forms.Label();
            this.txtMissedLetters = new System.Windows.Forms.TextBox();
            this.lblMissedWords = new System.Windows.Forms.Label();
            this.lstMissedWords = new System.Windows.Forms.ListBox();
            this.gbPanelDrawing.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbUserGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPanelDrawing
            // 
            this.gbPanelDrawing.Controls.Add(this.panel1);
            this.gbPanelDrawing.Location = new System.Drawing.Point(435, 12);
            this.gbPanelDrawing.Name = "gbPanelDrawing";
            this.gbPanelDrawing.Size = new System.Drawing.Size(272, 404);
            this.gbPanelDrawing.TabIndex = 0;
            this.gbPanelDrawing.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstMissedWords);
            this.groupBox3.Controls.Add(this.lblMissedWords);
            this.groupBox3.Controls.Add(this.txtMissedLetters);
            this.groupBox3.Controls.Add(this.lblMissedLetters);
            this.groupBox3.Location = new System.Drawing.Point(15, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // gbUserGuess
            // 
            this.gbUserGuess.Controls.Add(this.label2);
            this.gbUserGuess.Controls.Add(this.label1);
            this.gbUserGuess.Controls.Add(this.textBox2);
            this.gbUserGuess.Controls.Add(this.textBox1);
            this.gbUserGuess.Controls.Add(this.btnGuessWord);
            this.gbUserGuess.Controls.Add(this.btnGuessLetter);
            this.gbUserGuess.Location = new System.Drawing.Point(12, 335);
            this.gbUserGuess.Name = "gbUserGuess";
            this.gbUserGuess.Size = new System.Drawing.Size(417, 81);
            this.gbUserGuess.TabIndex = 3;
            this.gbUserGuess.TabStop = false;
            this.gbUserGuess.Text = "Guess a Letter or Word";
            // 
            // btnGuessLetter
            // 
            this.btnGuessLetter.Location = new System.Drawing.Point(77, 47);
            this.btnGuessLetter.Name = "btnGuessLetter";
            this.btnGuessLetter.Size = new System.Drawing.Size(75, 23);
            this.btnGuessLetter.TabIndex = 2;
            this.btnGuessLetter.Text = "Guess Letter";
            this.btnGuessLetter.UseVisualStyleBackColor = true;
            this.btnGuessLetter.Click += new System.EventHandler(this.btnGuessLetter_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 21);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Word:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 385);
            this.panel1.TabIndex = 0;
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
            // lblMissedWords
            // 
            this.lblMissedWords.AutoSize = true;
            this.lblMissedWords.Location = new System.Drawing.Point(7, 46);
            this.lblMissedWords.Name = "lblMissedWords";
            this.lblMissedWords.Size = new System.Drawing.Size(77, 13);
            this.lblMissedWords.TabIndex = 211;
            this.lblMissedWords.Text = "Missed Words:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(719, 428);
            this.Controls.Add(this.gbUserGuess);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPanelDrawing);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hangman By: John Silvey";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbPanelDrawing.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbUserGuess.ResumeLayout(false);
            this.gbUserGuess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPanelDrawing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbUserGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuessWord;
        private System.Windows.Forms.Button btnGuessLetter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstMissedWords;
        private System.Windows.Forms.Label lblMissedWords;
        private System.Windows.Forms.TextBox txtMissedLetters;
        private System.Windows.Forms.Label lblMissedLetters;
    }
}

