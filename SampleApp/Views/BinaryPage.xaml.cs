namespace SampleApp;

public partial class BinaryPage : ContentPage
{
	public BinaryPage()
	{
		InitializeComponent();
	}

    private string translatedInput;

    private void OnTranslate(object sender, EventArgs e)
    {
        string enteredInput = BinaryText.Text;

        translatedInput = SampleApp.Core.BinaryTranslator.TranslateToString(enteredInput);

        if (!string.IsNullOrEmpty(translatedInput))
        {
            TranslateButton.Text = translatedInput;
        }
        else
        {
            TranslateButton.Text = "Invalid input!";
        }
    }
}