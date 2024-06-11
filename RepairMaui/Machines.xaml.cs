namespace RepairMaui;

public partial class Machines : ContentPage
{
	public Machines()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Animations.BackColorAndScaleBlink(n, Color.FromArgb("7FFFFFFF"), Colors.LightGray, 1.0f, 1.2f);
    }

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        await Animations.BackColorAndScaleBlink(c, Color.FromArgb("7FFFFFFF"), Colors.LightGray, 1.0f, 1.2f);
    }
}