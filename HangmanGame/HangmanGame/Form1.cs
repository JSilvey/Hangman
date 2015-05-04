using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HangmanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            NewGame();
        }

        //Method to get a random word from text file.
        string GetRandomWord()
        {
            //create an array from the lines of the text file
            // in this text file there is 1 word per line
            string[] words = File.ReadAllLines("words.txt");
            Random random = new Random();
            //return a random word from 0 to end of array
            return words[random.Next(0,words.Length -1)];
        }

        int numWrong = 0;
        int numLetters = 0;

        string word ="";

        List<Label> labels = new List<Label>();

        enum BodyParts
        {
            Head,
            Body,
            RightArm,
            LeftArm,
            RightLeg,
            LeftLeg,
            RightEye,
            LeftEye,
            Mouth
        }

        //Draw Body Parts
        void DrawBodyPart(BodyParts bp)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black,3);
            Brush b = new SolidBrush(Color.Black);
            switch (bp)
            {
                case BodyParts.Head:
                    g.DrawEllipse(p, 95,50,60,60);
                    break;
                case BodyParts.Body:
                    g.DrawLine(p, new Point(125,110), new Point(125,250));
                    break;
                case BodyParts.LeftArm:
                    g.DrawLine(p, new Point(125, 130), new Point(75, 180));
                    break;
                case BodyParts.RightArm:
                    g.DrawLine(p, new Point(125, 130), new Point(175, 180));
                    break;
                case BodyParts.LeftLeg:
                    g.DrawLine(p, new Point(125, 250), new Point(75, 300));
                    break;
                case BodyParts.RightLeg:
                    g.DrawLine(p, new Point(125, 250), new Point(175, 300));
                    break;
                case BodyParts.LeftEye:
                    g.DrawLine(p, new Point(110, 70), new Point(120,80));
                    g.DrawLine(p, new Point(120, 70), new Point(110,80));
                    break;
                case BodyParts.RightEye:
                    g.DrawLine(p, new Point(130,70), new Point(140,80));
                    g.DrawLine(p, new Point(140,70), new Point(130,80));
                    break;
                case BodyParts.Mouth:
                    g.DrawArc(p, 115, 90, 20, 20, 165, 210);
                    break;
            }
        }


        //Draw Gallows each time a new game is started
        void DrawGallows()
        {
            //Create graphics and pen object
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Chocolate, 10);
            //Draw Vertical bar
            g.DrawLine(p, new Point(245, 385), new Point(245, 5));
            //Draw Top Horizontal bar
            g.DrawLine(p, new Point(250, 5), new Point(130, 5));
            //Draw small vertical bar (noose bar)
            g.DrawLine(p, new Point(125, 0), new Point(125, 50));
            //Draw diagnal support bar
            g.DrawLine(p, new Point(180, 5), new Point(245, 100));
            //Draw bottom support bar
            g.DrawLine(p, new Point(0, 380), new Point(266, 380));
            
            
        }

        //Method to create labels
        void CreateLabels()
        {
            //get random word
            word=GetRandomWord();
            //Message box to show word for debugging prurposes
            //MessageBox.Show(word);
            //create a character array for each character in word
            char[] chars = word.ToLower().ToCharArray();
            //create the space between the labels
            int blankSpace =325 / chars.Length;
            //create label for each character
            for(int i = 0; i< chars.Length; i ++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * blankSpace) +25, 90);
                labels[i].Text = "_";
                labels[i].Parent = groupBox2;
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            //set label text to display word length
            lblWordLength.Text = ("Word length: " + word.Length);
            //set max length of word guess text box to length of word
            txtword.MaxLength = word.Length;
        }
        //Method to create a new game
        void NewGame()
        {
            panel1.Refresh();
            txtMissedLetters.Clear();
            lstMissedWords.Items.Clear();
            CreateLabels();
            numWrong = 0;
            numLetters = 0;
            DrawGallows();
                       
        }

        //Method to check if game is over
        void GameOver()
        {
            if (numWrong==8)
            {
                MessageBox.Show("You Lost! The word was " + word, "SORRY!");
                NewGame();
            }
        }

        //Test user word against selected word       
        private void btnGuessWord_Click(object sender, EventArgs e)
        {
            //Check to make sure the textbox is not left blank
            if (string.IsNullOrEmpty(txtword.Text))
            {
                MessageBox.Show("Guessed Word Box Cannot Be Left Blank", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (txtword.Text == word)
                {
                    MessageBox.Show("You Guessed the word!", "CONGRATS!");
                    NewGame();
                }
                else
                {
                    lstMissedWords.Items.Add((txtword.Text)+", ");
                    txtword.Clear();
                    DrawBodyPart((BodyParts)numWrong);
                    numWrong++;
                    GameOver();
                }
            }
        }
        //Test user letter against selected word
        private void btnGuessLetter_Click(object sender, EventArgs e)
        {
            //Check to make sure the textbox is not left blank
            if (string.IsNullOrEmpty(txtLetter.Text))
            {
                MessageBox.Show("Guessed Letter Box Cannot Be Left Blank.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                char letter = txtLetter.Text.ToLower().ToCharArray()[0];
                if (!char.IsLetter(letter))
                {
                    MessageBox.Show("Only Characters are allowed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLetter.Clear();
                    return;
                }
                if (word.Contains(letter))
                {
                    numLetters++;
                    char[] letters = word.ToCharArray();
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (letters[i] == letter)
                            labels[i].Text = letter.ToString();
                    }
                    if (numLetters == word.Length)
                    {
                        MessageBox.Show("You guessed the word!\n The word was: " + word, "Congratulations!", MessageBoxButtons.OK);
                        NewGame();
                    }
                }
                else
                {
                    txtMissedLetters.Text += (letter.ToString() + ", ");
                    DrawBodyPart((BodyParts)numWrong);
                    numWrong++;
                    GameOver();

                }
                txtLetter.Text = "";
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void forfeitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numWrong = 8;
            GameOver();
        }

        private void quitExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
}
