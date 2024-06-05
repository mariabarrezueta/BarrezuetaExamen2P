using Microsoft.Maui.Controls;
using System;
using System.Linq;

namespace RebeBA_ApuntesApp.Views
{
    public partial class RBA_CustomPage : ContentPage
    {
        public RBA_CustomPage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            string input = inputEntry.Text;

            if (string.IsNullOrEmpty(input))
            {
                resultLabel.Text = "Please enter a valid string.";
                return;
            }

            int totalCharacters = input.Length;
            int numberCount = input.Count(char.IsDigit);
            int letterCount = input.Count(char.IsLetter);
            int vowelCount = input.Count(c => "AEIOUaeiou".IndexOf(c) >= 0);
            int uppercaseCount = input.Count(char.IsUpper);
            int lowercaseCount = input.Count(char.IsLower);

            resultLabel.Text = $"Total Characters: {totalCharacters}\n" +
                               $"Numbers: {numberCount}\n" +
                               $"Letters: {letterCount}\n" +
                               $"Vowels: {vowelCount}\n" +
                               $"Uppercase Letters: {uppercaseCount}\n" +
                               $"Lowercase Letters: {lowercaseCount}";
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            inputEntry.Text = string.Empty;
            resultLabel.Text = "Results will appear here";
        }
    }
}



