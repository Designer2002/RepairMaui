namespace RepairMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            await Animations.BackColorAndScaleBlink(o, Color.FromArgb("7FFFFFFF"), Colors.LightGray, 1.0f, 1.2f);
            await Navigation.PushAsync(new Machines());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            await Animations.BackColorAndScaleBlink(p, Color.FromArgb("7FFFFFFF"), Colors.LightGray, 1.0f, 1.2f);
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
        {
            await Animations.BackColorAndScaleBlink(r, Color.FromArgb("7FFFFFFF"), Colors.LightGray, 1.0f, 1.2f);
        }
    }
}