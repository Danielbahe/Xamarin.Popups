using System.Threading.Tasks;
using Xamarin.Popups.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Popups.Widgets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingWidget : ContentView, IPopupAnimable
    {
        public bool Loading { get; set; }
        public LoadingWidget()
        {
            InitializeComponent();
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