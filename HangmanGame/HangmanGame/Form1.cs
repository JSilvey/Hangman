using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DrawGallows();
        }

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

        //Test user word against selected word       
        private void btnGuessWord_Click(object sender, EventArgs e)
        {

        }
        //Test user letter against selected word
        private void btnGuessLetter_Click(object sender, EventArgs e)
        {
            DrawBodyPart(BodyParts.Head);
            DrawBodyPart(BodyParts.Body);
            DrawBodyPart(BodyParts.LeftArm);
            DrawBodyPart(BodyParts.RightArm);
            DrawBodyPart(BodyParts.LeftLeg);
            DrawBodyPart(BodyParts.RightLeg);
            DrawBodyPart(BodyParts.LeftEye);
            DrawBodyPart(BodyParts.RightEye);
            DrawBodyPart(BodyParts.Mouth);
        }

        
    }
}
