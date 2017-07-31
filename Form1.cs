using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        struct MultiplePhrase
        {
            public int multiple;
            public string phrase;
        }

        const int phrases = 2;

        const int NumberToTest = 100;

        MultiplePhrase[] WordList = new MultiplePhrase[phrases];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WordList[0].multiple = 3;
            WordList[0].phrase = "Fizz";
            WordList[1].multiple = 5;
            WordList[1].phrase = "Buzz";
            /*WordList[2].multiple = 7;
            WordList[2].phrase = "Fuzz";
            WordList[3].multiple = 11;
            WordList[3].phrase = "Bizz";
            WordList[4].multiple = 13;
            WordList[4].phrase = "Biff";*/

            bool test = false;

            for (int i = 1; i <= NumberToTest; i++)
            {
                test = false;
                for (int j = 0; j < phrases; j++)
                {
                    test |= i % WordList[j].multiple == 0;
                    if (i % WordList[j].multiple == 0)
                    {
                        textBox1.Text += WordList[j].phrase;
                    }
                }
                if (!test)
                {
                    textBox1.Text += i.ToString();
                }
                textBox1.Text += Environment.NewLine;
            }
        }
    }
}
