using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int clicks = 0;
        private List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Win()
        {
            if (buttons[0].Text + buttons[1].Text + buttons[2].Text == "XXX" || buttons[0].Text + buttons[1].Text + buttons[2].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[0].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (buttons[0].Text + buttons[4].Text + buttons[8].Text == "XXX" || buttons[0].Text + buttons[4].Text + buttons[8].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[0].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (buttons[0].Text + buttons[3].Text + buttons[6].Text == "XXX" || buttons[0].Text + buttons[3].Text + buttons[6].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[0].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (buttons[1].Text + buttons[4].Text + buttons[7].Text == "XXX" || buttons[1].Text + buttons[4].Text + buttons[7].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[1].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (buttons[2].Text + buttons[5].Text + buttons[8].Text == "XXX" || buttons[2].Text + buttons[5].Text + buttons[8].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[2].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (buttons[2].Text + buttons[4].Text + buttons[6].Text == "XXX" || buttons[2].Text + buttons[4].Text + buttons[6].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[2].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (buttons[3].Text + buttons[4].Text + buttons[5].Text == "XXX" || buttons[3].Text + buttons[4].Text + buttons[5].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[4].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
            else if (buttons[6].Text + buttons[7].Text + buttons[8].Text == "XXX" || buttons[6].Text + buttons[7].Text + buttons[8].Text == "OOO")
            {
                MessageBox.Show($"Player {buttons[7].Text} won!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();

            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Size = new Size(600, 600);
            this.Text = "TicTacToe";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TransparencyKey = Color.Black;
            int x = 0;
            int y = 0;
            for (int i = 0; i < 9; i++)
            {
                Button button = new Button();
                this.buttons.Add(button);
                button.Size = new Size(this.Size.Width / 3, this.Size.Height / 3);
                button.Location = new Point(x, y);
                button.BackColor = Color.White;
                button.Click += new EventHandler(Button_Click);
                this.Controls.Add(button);
                if (x + this.Size.Width / 3 >= this.Size.Width)
                {
                    x = 0;
                    y += this.Size.Height / 3;
                }
                else
                {
                    x += this.Size.Width / 3;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.White)
            {
                clicks++;
                if (clicks % 2 == 1)
                {
                    (sender as Button).ForeColor = Color.White;
                    (sender as Button).BackColor = Color.Red;
                    (sender as Button).Font = new Font("Arial", 30);
                    (sender as Button).Text = "X";
                }
                else
                {
                    (sender as Button).ForeColor = Color.White;
                    (sender as Button).BackColor = Color.Blue;
                    (sender as Button).Font = new Font("Arial", 30);
                    (sender as Button).Text = "O";
                }
            }
            this.Check_Win();
        }
    }
}
