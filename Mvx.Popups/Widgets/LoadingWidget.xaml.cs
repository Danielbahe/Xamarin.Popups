using System.Threading.Tasks;
using Xamarin.Popups.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Popups.Translations;
using System.IO;

namespace Xamarin.Popups.Widgets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingWidget : ContentView, IPopupAnimable
    {
        public bool Loading { get; set; }
        public LoadingWidget(string loadingImage = null, string loadingText = null)
        {
            InitializeComponent();

            SetValues(loadingImage, loadingText);
        }

        private void SetValues(string loadingImage, string loadingText)
        {
            if(string.IsNullOrEmpty(loadingImage)) image.Source = ImageSource.FromStream(() => new MemoryStream(PopupResources.loading_icon_small));
            //image.Source = loadingText;
            if (loadingText == null) loadingText = PopupResources.Loading;
            loadingLabel.Text = loadingText;
        }

        public async Task Animate()
        {
            while (true)
            {
                await ViewExtensions.RotateTo(image, 360, 2000);
                image.Rotation = 0;
            }
        }
    }
}