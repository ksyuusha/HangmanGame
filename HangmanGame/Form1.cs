using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class Form1 : Form
    {
        private string wordToGuess;
        private string maskedWord;
        private int attemptsLeft;
        private HashSet<char> guessedLetters = new HashSet<char>();
        private List<string> wordList = new List<string> { "КОМПЬЮТЕР", "ПРОГРАММА", "ЯЗЫК", "ПО", "РАЗРАБОТЧИК", "УЧЕБА", "РЕБЕНОК", "ПРАВИЛА", "МАШИНА", "ПРОГРАММИСТ" };

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            // Выбираем случайное слово из списка
            Random random = new Random();
            wordToGuess = wordList[random.Next(wordList.Count)];
            attemptsLeft = 6;
            guessedLetters.Clear();
            maskedWord = new string('_', wordToGuess.Length);

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            // Обновляем отображение слова и оставшихся попыток
            lblWord.Text = maskedWord;
            lblAttempts.Text = $"Осталось попыток: {attemptsLeft}";
            lstGuessedLetters.Items.Clear();
            foreach (var letter in guessedLetters)
            {
                lstGuessedLetters.Items.Add(letter);
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtLetter.Text.Length == 1)
            {
                char guessedLetter = char.ToUpper(txtLetter.Text[0]);
                txtLetter.Clear();

                if (!guessedLetters.Contains(guessedLetter))
                {
                    guessedLetters.Add(guessedLetter);

                    if (wordToGuess.Contains(guessedLetter.ToString()))
                    {
                        // Открываем буквы в слове
                        char[] maskedArray = maskedWord.ToCharArray();
                        for (int i = 0; i < wordToGuess.Length; i++)
                        {
                            if (wordToGuess[i] == guessedLetter)
                            {
                                maskedArray[i] = guessedLetter;
                            }
                        }
                        maskedWord = new string(maskedArray);

                        // Проверка на победу
                        if (!maskedWord.Contains('_'))
                        {
                            MessageBox.Show("Поздравляем! Вы угадали слово!");
                            StartNewGame();
                            return;
                        }
                    }
                    else
                    {
                        attemptsLeft--;

                        // Проверка на проигрыш
                        if (attemptsLeft <= 0)
                        {
                            MessageBox.Show($"Вы проиграли! Загаданное слово было: {wordToGuess}");
                            StartNewGame();
                            return;
                        }
                    }
                }
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Введите одну букву.");
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
