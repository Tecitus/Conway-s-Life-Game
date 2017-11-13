using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConwayGame;
namespace Conway
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            int X = 16, Y = 16;
            game = new Game(X, Y);
              textBox1.Lines = game.Output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Regen();
            game.Draw(game.grid);
            textBox1.Lines = game.Output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.RandomCell();
            game.Draw(game.grid);
            textBox1.Lines = game.Output;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            game.NewGrid(Convert.ToInt32(textBox2.Text), game.grid.GetY());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            game.NewGrid(game.grid.GetX(), Convert.ToInt32(textBox3.Text));
        }
    }
}
