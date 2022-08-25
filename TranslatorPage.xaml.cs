namespace SampleApp;

public partial class TranslatorPage : ContentPage
{
    public TranslatorPage()
    {
        InitializeComponent();
    }

    private string translatedNumber;

    private void OnTranslate(object sender, EventArgs e)
    {
        string enteredNumber = PhoneNumberText.Text;
        translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);

        if (!string.IsNullOrEmpty(translatedNumber))
        {
            CallButton.IsEnabled = true;
            CallButton.Text = "Call " + translatedNumber;
        }
        else
        {
            CallButton.IsEnabled = false;
            CallButton.Text = "Call";
        }
    }

    private async void OnCall(object sender, System.EventArgs e)
    {
        if (await this.DisplayAlert(
            "Dial a Number",
            "Would you like to call " + translatedNumber + "?",
            "Yes",
            "No"))
        {
            // TODO: dial the phone
        }
    }
}