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
                numbersLabel.Text = "Números: 0";
                uppercaseLabel.Text = "Mayúsculas: 0";
                lowercaseLabel.Text = "Minúsculas: 0";
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
            numbersLabel.Text = $"Números: {numberCount}";
            uppercaseLabel.Text = $"Mayúsculas: {uppercaseCount}";
            lowercaseLabel.Text = $"Minúsculas: {lowercaseCount}";
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
            numbersLabel.Text = "Números: 0";
            uppercaseLabel.Text = "Mayúsculas: 0";
            lowercaseLabel.Text = "Minúsculas: 0";
            vowelsLabel.Text = "Vocales: 0";
            totalLabel.Text = "Total: 0";
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            // Implement your delete logic here
        }
    }
}
