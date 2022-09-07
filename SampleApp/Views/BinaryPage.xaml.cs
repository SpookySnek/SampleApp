using System.Text.RegularExpressions;

namespace SampleApp;

public partial class BinaryPage : ContentPage
{
    public BinaryPage()
    {
        InitializeComponent();
    }

    private string translatedInput;

    private void OnTranslateToText(object sender, EventArgs e)
    {
        string enteredInput = BinaryText.Text;

        if (enteredInput.Any(char.IsWhiteSpace) || Regex.IsMatch(enteredInput, "[2-9]") || !enteredInput.Any(char.IsLetterOrDigit)
            || enteredInput.Any(char.IsLetter))
        {
            Output.Text = "Invalid input! Make sure you don't have any whitespaces";
        }
        else
        {
            translatedInput = SampleApp.Core.BinaryTranslator.TranslateToString(enteredInput);

            if (!string.IsNullOrEmpty(translatedInput))
            {
                Output.Text = translatedInput;
            }
            else
            {
                Output.Text = "Invalid input!";
            }
        }
    }

    private void OnTranslateToBinary(object sender, EventArgs e)
    {
        string enteredInput = Text.Text;

        translatedInput = SampleApp.Core.BinaryTranslator.TranslateToBinary(enteredInput);

        if (!string.IsNullOrEmpty(translatedInput))
        {
            Output.Text = translatedInput;
        }
        else
        {
            Output.Text = "Invalid input!";
        }
    }
}