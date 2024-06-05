using Microsoft.Maui.Controls;
using System;
using System.Linq;

namespace RebeBA_ApuntesApp.Views
{
    public partial class RebeBA_NotePage : ContentPage
    {
        public RebeBA_NotePage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            string input = noteEditor.Text;

            if (string.IsNullOrEmpty(input))
            {
                lettersLabel.Text = "Letras: 0";
                numbersLabel.Text = "N�meros: 0";
                uppercaseLabel.Text = "May�sculas: 0";
                lowercaseLabel.Text = "Min�sculas: 0";
                vowelsLabel.Text = "Vocales: 0";
                totalLabel.Text = "Total: 0";
                return;
            }

            int totalCharacters = input.Length;
            int numberCount = input.Count(char.IsDigit);
            int letterCount = input.Count(char.IsLetter);
            int vowelCount = input.Count(c => "AEIOUaeiou".IndexOf(c) >= 0);
            int uppercaseCount = input.Count(char.IsUpper);
            int lowercaseCount = input.Count(char.IsLower);

            lettersLabel.Text = $"Letras: {letterCount}";
            numbersLabel.Text = $"N�meros: {numberCount}";
            uppercaseLabel.Text = $"May�sculas: {uppercaseCount}";
            lowercaseLabel.Text = $"Min�sculas: {lowercaseCount}";
            vowelsLabel.Text = $"Vocales: {vowelCount}";
            totalLabel.Text = $"Total: {totalCharacters}";
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            // Implement your save logic here
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            noteEditor.Text = string.Empty;
            lettersLabel.Text = "Letras: 0";
            numbersLabel.Text = "N�meros: 0";
            uppercaseLabel.Text = "May�sculas: 0";
            lowercaseLabel.Text = "Min�sculas: 0";
            vowelsLabel.Text = "Vocales: 0";
            totalLabel.Text = "Total: 0";
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Implement your delete logic here
        }
    }
}
