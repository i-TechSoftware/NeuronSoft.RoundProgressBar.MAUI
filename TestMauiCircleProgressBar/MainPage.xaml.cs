using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TestMauiCircleProgressBar.MVVM;

namespace TestMauiCircleProgressBar
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        /*private async void OnCounterClicked(object sender, EventArgs e)
        {
            for (double i = 1; i < 101; i++)
            {
                progressBar.Progress = i;
                await Task.Delay(100);
            }
        }*/
    }

    public class MainViewModel: BaseViewModel
    {

        private int _Progress;
        private Color _BackgroundColor;

        public Color BackgroundColor
        {
            get => _BackgroundColor;
            set => SetProperty(ref _BackgroundColor, value);
        }

        public int Progress
        {
            get => _Progress;
            set => SetProperty(ref _Progress, value);
        }

        public ICommand ClickButtonCommand { get; }
        

        public MainViewModel()
        {
            ClickButtonCommand = new DelegateCommand(OnClickButtonCommand);
            
        }

        private async void OnClickButtonCommand()
        {
            for (int i = 1; i < 101; i++)
            {
                Progress = i;
                await Task.Delay(100);
            }
        }
    }
}