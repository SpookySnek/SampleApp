namespace SampleApp;

public partial class MainPage : ContentPage
{
	Random number = new Random();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

			NumberDisplay.Text = $"{number.Next()}";

		SemanticScreenReader.Announce(NumberDisplay.Text);
	}
}

