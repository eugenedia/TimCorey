using DemoLibrary;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int maxNumber = 0;
        private int currentNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            nextImageButton.IsEnabled = false;

        }

        private async Task LoadImage(int imageNumber = 0)
        {
            var comic = await ComicProcessor.LoadComic(imageNumber);

            if (imageNumber == 0)
            {
                maxNumber = comic.Num;
            }

            currentNumber = comic.Num;

            var uriSource = new Uri(comic.Img, UriKind.Absolute);

            comicImage.Source = new BitmapImage(uriSource);
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadImage();
        }

        private async void previousImageButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber > 1)
            {
                currentNumber -= 1;
                nextImageButton.IsEnabled = true;
                await LoadImage(currentNumber);

                if (currentNumber == 1)
                {
                    previousImageButton.IsEnabled = false;
                }
            }
            else return;
        }

        private async void nextImageButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentNumber < maxNumber)
            {
                currentNumber += 1;
                previousImageButton.IsEnabled = true;
                await LoadImage(currentNumber);

                if (currentNumber == maxNumber)
                {
                    nextImageButton.IsEnabled = false;
                }
            }

        }

        private void sunInformationButton_Click(object sender, RoutedEventArgs e)
        {
            SunInfo sunInfo = new SunInfo();

            sunInfo.Show();
        }
    }
}
