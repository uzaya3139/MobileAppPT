namespace progresstest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnReadMoreClicked(object sender, EventArgs e)
        {
            DescriptionLabel.IsVisible = !DescriptionLabel.IsVisible;
        }

    }
}