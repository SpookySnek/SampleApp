namespace SampleApp;

public partial class MainPage : ContentPage


{


    void OnTextChanged(object sender, EventArgs e)
    {
        var text = ((Entry)sender).Text;
        Console.WriteLine(text);
    }

    Random number = new Random();

	private int To()
    {
        int parsedTo;
        bool success = int.TryParse(ToNumber.Text, out parsedTo);
        if (success)
        {
            return parsedTo;
        }
        return 0;
    }

    private int From()
    {
        int parsedFrom;
        bool success = int.TryParse(FromNumber.Text, out parsedFrom);
        if (success)
        {
            return parsedFrom;
        }
        return 0;
    }

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

			NumberDisplay.Text = $"{number.Next(From(), To())}";

		SemanticScreenReader.Announce(NumberDisplay.Text);
	}
}

