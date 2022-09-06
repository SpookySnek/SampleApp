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

        translatedInput = SampleApp.Core.BinaryTranslator.TranslateToString(enteredInput);

        if (!string.IsNullOrEmpty(translatedInput))
        {
            TranslateToTextButton.Text = translatedInput;
        }
        else
        {
            TranslateToTextButton.Text = "Invalid input!";
        }
    }
}