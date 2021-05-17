using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class guessingGame : Form
    {
        public guessingGame()
        {
            InitializeComponent();

            randomNumber = rnd.Next(1, 11);
        }
        Random rnd = new Random();
        int textBoxNumber;
        int randomNumber;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxNumber = Int32.Parse(textBoxInput.Text);
                if(textBoxNumber == randomNumber)
                {
                    finalText.Text = $"{textBoxNumber} is the number!";
                }
                else if(textBoxNumber < randomNumber)
                {
                    finalText.Text = $"{textBoxNumber} is too low";
                }
                else if(textBoxNumber > randomNumber)
                {
                    finalText.Text = $"{textBoxNumber} is too high";
                }
                else if(textBoxNumber < 10)
                {
                    finalText.Text = $"A number between 1 and 10 please";
                }
            }
            catch
            {
                finalText.Text = "Enter a number value";
            }
        }
    }
}
