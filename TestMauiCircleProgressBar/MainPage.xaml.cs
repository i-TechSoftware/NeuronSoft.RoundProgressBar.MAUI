namespace TestMauiCircleProgressBar
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            for (double i = 1; i < 101; i++)
            {
                progressBar.Progress = i;
                await Task.Delay(100);
            }
        }
    }
}