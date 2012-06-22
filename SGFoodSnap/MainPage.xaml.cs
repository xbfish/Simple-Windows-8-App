using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.AccessCache;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.Data.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SGFoodSnap
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public StorageFile file;

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void TakePhoto(object sender, RoutedEventArgs e)
        {
            // Using Windows.Media.Capture.CameraCaptureUI API to capture a photo
            CameraCaptureUI dialog = new CameraCaptureUI();

            // Open up camera dialog
            file = await dialog.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (file != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                using (IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read))
                {
                    bitmapImage.SetSource(fileStream);
                }
                CapturedPhoto.Source = bitmapImage;
            }
            else
            {
                MessageDialog msg = new MessageDialog("No photo captured.", "Error");
                await msg.ShowAsync();
            }
        }

        public async Task<byte[]> GetPhotoBytesAsync(StorageFile file)
        {
            IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read);
            var reader = new Windows.Storage.Streams.DataReader(fileStream.GetInputStreamAt(0));
            await reader.LoadAsync((uint)fileStream.Size);

            byte[] pixels = new byte[fileStream.Size];
            reader.ReadBytes(pixels);
            return pixels;
        }

        private async void Testing(object sender, RoutedEventArgs e)
        {
            JsonValue jsonvalue = JsonValue.Parse("[116, 3.14159, true, \"abc\"]");
            int arraySize = jsonvalue.GetArray().Count;
            //MessageDialog msg = new MessageDialog(arraySize.ToString(), "Error");
            //await msg.ShowAsync();

            List<Food> list = new List<Food>();
            list.Add(new Food("Michael", "http://rabbitwebfactory.com/assets/rabbit_logo.png"));
            list.Add(new Food("Chris", "http://rabbitwebfactory.com/assets/rabbit_logo.png"));
            list.Add(new Food("Cassie", "http://rabbitwebfactory.com/assets/rabbit_logo.png"));
            list.Add(new Food("Guido", "http://rabbitwebfactory.com/assets/rabbit_logo.png"));
            Gallery.ItemsSource = list;
        }

        private async void UploadImage(object sender, RoutedEventArgs e)
        {
            // Upload image to server
            byte[] myPicArray = await GetPhotoBytesAsync(file);
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://192.168.1.198");

            MultipartFormDataContent form = new MultipartFormDataContent();
            HttpContent content = new ByteArrayContent(myPicArray);
            form.Add(content, "media", "filename.jpg");
            content = new StringContent(MessageBox.Text);
            form.Add(content, "username");
            HttpResponseMessage response = await httpClient.PostAsync("sgfood/upload.php", form);

            MessageDialog msg = new MessageDialog("Image uploaded", "Status");
            await msg.ShowAsync();

            MessageBox.Text = "";
            var uri = new Uri(this.BaseUri, "Assets/placeholder.png");
            BitmapImage result = new BitmapImage();
            result.UriSource = uri;
            CapturedPhoto.Source = result;
        }
    }
}
