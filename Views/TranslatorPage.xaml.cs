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

/* Unmerged change from project 'SampleApp (net6.0-windows10.0.19041.0)'
Before:
        translatedNumber = Core.PhonewordTranslator.ToNumber(enteredNumber);
After:
        translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);
*/

/* Unmerged change from project 'SampleApp (net6.0-windows10.0.19041.0)'
Before:
        translatedNumber = SampleApp.views.PhonewordTranslator.ToNumber(enteredNumber);
After:
        translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);
*/
        translatedNumber = SampleApp.Core.PhonewordTranslator.ToNumber(enteredNumber);

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
            try
            {
                if (PhoneDialer.Default.IsSupported)
                    PhoneDialer.Default.Open(translatedNumber);
            }
            catch (ArgumentNullException)
            {
                await DisplayAlert("Unable to dial", "Phone number was not valid.", "OK");
            }
            catch (Exception)
            {
                // Other error has occurred.
                await DisplayAlert("Unable to dial", "Phone dialing failed.", "OK");
            }
        }
    }
}