namespace SampleApp;

public partial class TranslatorPage : ContentPage
{
    string translatedNumber;

    private void OnTranslate(object sender, EventArgs e)
    {
        string enteredNumber = PhoneNumberText.Text;
        translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);

        if (!string.IsNullOrEmpty(translatedNumber))
        {
            // TODO:
        }
        else
        {
            // TODO:
        }
    }
}