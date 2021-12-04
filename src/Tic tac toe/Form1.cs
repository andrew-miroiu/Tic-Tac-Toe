using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        private string winningSymbol = "";

        private string Symbol
        {
            get
            {
                if(counter % 2 == 0)
                {
                    return "X";
                }
                else
                {
                    return "O";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                button1.Text = Symbol;
                button1.Font = getCustomFont();
                counter++;
                checkForWinner();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = Symbol;
                button2.Font = getCustomFont();
                counter++;
                checkForWinner();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "")
            {
                button3.Font = getCustomFont();
                button3.Text = Symbol;
                counter++;
                checkForWinner();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text == "")
            {
                button4.Font = getCustomFont();
                button4.Text = Symbol;
                counter++;
                checkForWinner();
            } 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(button5.Text == "")
            {
                button5.Font = getCustomFont();
                button5.Text = Symbol;
                counter++;
                checkForWinner();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Font = getCustomFont();
                button6.Text = Symbol;
                counter++;
                checkForWinner();
            }        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Font = getCustomFont();
                button7.Text = Symbol;
                counter++;
                checkForWinner();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Font = getCustomFont();
                button8.Text = Symbol;
                counter++;
                checkForWinner();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Font = getCustomFont();
                button9.Text = Symbol;
                counter++;
                checkForWinner();
            }
        }

        private void checkForWinner()
        {
            if(counter < 5)
            {
                return;
            }
            

            if(button1.Text == button2.Text && button2.Text == button3.Text)
            {
                winningSymbol = button1.Text;
                showWinner();
                resetGame();
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                winningSymbol = button4.Text;
                showWinner();
                resetGame();
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                winningSymbol = button7.Text;
                showWinner();
                resetGame();
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                winningSymbol = button1.Text;
                showWinner();
                resetGame();
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                winningSymbol = button3.Text;
                showWinner();
                resetGame();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                winningSymbol = button1.Text;
                showWinner();
                resetGame();
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                winningSymbol = button2.Text;
                showWinner();
                resetGame();
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                winningSymbol = button3.Text;
                showWinner();
                resetGame();
            }
            else if(counter >= 9)
            {
                showTie();
                resetGame();
            }
        }

        private void showWinner()
        {
            if(winningSymbol.Length > 0)
            {
                MessageBox.Show(winningSymbol + " won the game", "GAME OVER");
            } 
        }

        private void showTie()
        {
            MessageBox.Show("TIE!", "GAME OVER");
        }

        private void resetGame()
        {
            counter = 0;
            winningSymbol = "";

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Font getCustomFont()
        {
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 30);
            return font;
        }
    }
}
