namespace CardIdentifier
{
    partial class CardIdentifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.cardAceDiamonds = new System.Windows.Forms.PictureBox();
            this.card7Spades = new System.Windows.Forms.PictureBox();
            this.cardJokerRed = new System.Windows.Forms.PictureBox();
            this.cardKingSpades = new System.Windows.Forms.PictureBox();
            this.card2Diamonds = new System.Windows.Forms.PictureBox();
            this.cardName = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardAceDiamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7Spades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardJokerRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKingSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2Diamonds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.Location = new System.Drawing.Point(135, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click any card to see it\'s name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardAceDiamonds
            // 
            this.cardAceDiamonds.Image = global::CardIdentifier.Properties.Resources.Ace_Diamonds;
            this.cardAceDiamonds.Location = new System.Drawing.Point(517, 94);
            this.cardAceDiamonds.Name = "cardAceDiamonds";
            this.cardAceDiamonds.Size = new System.Drawing.Size(100, 140);
            this.cardAceDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardAceDiamonds.TabIndex = 5;
            this.cardAceDiamonds.TabStop = false;
            this.cardAceDiamonds.Click += new System.EventHandler(this.cardAceDiamonds_Click);
            // 
            // card7Spades
            // 
            this.card7Spades.Image = global::CardIdentifier.Properties.Resources._7_Spades;
            this.card7Spades.Location = new System.Drawing.Point(393, 94);
            this.card7Spades.Name = "card7Spades";
            this.card7Spades.Size = new System.Drawing.Size(100, 140);
            this.card7Spades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card7Spades.TabIndex = 4;
            this.card7Spades.TabStop = false;
            this.card7Spades.Click += new System.EventHandler(this.card7Spades_Click);
            // 
            // cardJokerRed
            // 
            this.cardJokerRed.Image = global::CardIdentifier.Properties.Resources.Joker_Red;
            this.cardJokerRed.Location = new System.Drawing.Point(259, 94);
            this.cardJokerRed.Name = "cardJokerRed";
            this.cardJokerRed.Size = new System.Drawing.Size(100, 140);
            this.cardJokerRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardJokerRed.TabIndex = 3;
            this.cardJokerRed.TabStop = false;
            this.cardJokerRed.Click += new System.EventHandler(this.cardJokerRed_Click);
            // 
            // cardKingSpades
            // 
            this.cardKingSpades.Image = global::CardIdentifier.Properties.Resources.King_Clubs;
            this.cardKingSpades.Location = new System.Drawing.Point(141, 94);
            this.cardKingSpades.Name = "cardKingSpades";
            this.cardKingSpades.Size = new System.Drawing.Size(100, 140);
            this.cardKingSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardKingSpades.TabIndex = 2;
            this.cardKingSpades.TabStop = false;
            this.cardKingSpades.Click += new System.EventHandler(this.cardKingSpades_Click);
            // 
            // card2Diamonds
            // 
            this.card2Diamonds.Image = global::CardIdentifier.Properties.Resources._2_Diamonds;
            this.card2Diamonds.Location = new System.Drawing.Point(23, 94);
            this.card2Diamonds.Name = "card2Diamonds";
            this.card2Diamonds.Size = new System.Drawing.Size(100, 140);
            this.card2Diamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card2Diamonds.TabIndex = 1;
            this.card2Diamonds.TabStop = false;
            this.card2Diamonds.Click += new System.EventHandler(this.card2Diamonds_Click);
            // 
            // cardName
            // 
            this.cardName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cardName.Location = new System.Drawing.Point(175, 256);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(285, 42);
            this.cardName.TabIndex = 6;
            this.cardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(259, 316);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 44);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CardIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 382);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.cardAceDiamonds);
            this.Controls.Add(this.card7Spades);
            this.Controls.Add(this.cardJokerRed);
            this.Controls.Add(this.cardKingSpades);
            this.Controls.Add(this.card2Diamonds);
            this.Controls.Add(this.label1);
            this.Name = "CardIdentifier";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardAceDiamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card7Spades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardJokerRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKingSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2Diamonds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox card2Diamonds;
        private System.Windows.Forms.PictureBox cardKingSpades;
        private System.Windows.Forms.PictureBox cardJokerRed;
        private System.Windows.Forms.PictureBox card7Spades;
        private System.Windows.Forms.PictureBox cardAceDiamonds;
        private System.Windows.Forms.Label cardName;
        private System.Windows.Forms.Button Exit;
    }
}

