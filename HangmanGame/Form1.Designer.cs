namespace HangmanGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.Button btnNewGame;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWord = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblWord
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(30, 30);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(150, 29);
            this.lblWord.Text = "Слово: ______";

            // lblAttempts
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(30, 80);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(120, 13);
            this.lblAttempts.Text = "Осталось попыток: 6";

            // txtLetter
            this.txtLetter.Location = new System.Drawing.Point(30, 120);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(100, 20);

            // btnGuess
            this.btnGuess.Location = new System.Drawing.Point(150, 120);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.Text = "Угадать";
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);

            // lstGuessedLetters
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.Location = new System.Drawing.Point(30, 160);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(120, 95);

            // btnNewGame
            this.btnNewGame.Location = new System.Drawing.Point(150, 160);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.btnNewGame);
            this.Name = "Form1";
            this.Text = "Виселица";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
