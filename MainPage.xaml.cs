namespace SampleApp;

public partial class MainPage : ContentPage

{

    Random number = new Random();

    private int From()
    {
        bool success = int.TryParse(FromNumber.Text, out int parsedFrom);
        if (success)
        {
            return parsedFrom;
        }
        return 0;
    }
    private int To()
    {
        bool success = int.TryParse(ToNumber.Text, out int parsedTo);

        if (success)
        {
            return parsedTo;
        }
        return 2147483647;
    }


    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (From() <= To())
        {
            NumberDisplay.Text = $"{number.Next(From(), To())}";
        }
        if (From() > To())
        {
            NumberDisplay.Text = "XXX From value is larger than To value XXX";
        }

        SemanticScreenReader.Announce(NumberDisplay.Text);
    }
}

