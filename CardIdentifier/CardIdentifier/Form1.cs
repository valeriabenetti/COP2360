using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class CardIdentifier : Form
    {
        public CardIdentifier()
        {
            InitializeComponent();
        }

        private void card2Diamonds_Click(object sender, EventArgs e)
        {
            cardName.Text = "Two of Diamonds";
        }

        private void cardKingSpades_Click(object sender, EventArgs e)
        {
            cardName.Text = "King of Diamonds";
        }

        private void cardJokerRed_Click(object sender, EventArgs e)
        {
            cardName.Text = "Red Joker";
        }

        private void card7Spades_Click(object sender, EventArgs e)
        {
            cardName.Text = "Seven of Spades";
        }

        private void cardAceDiamonds_Click(object sender, EventArgs e)
        {
            cardName.Text = "Ace of Diamonds";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
