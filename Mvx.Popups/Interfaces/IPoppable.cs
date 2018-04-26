using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Popups.Interfaces
{
    public interface IPoppable
    {
        Task<bool> ShowAlert(string title, string message, string okText = "Ok", string cancelText = null);
        void ShowLoading(string loadingImage = null, string loadingText = null);
        void HideLoading();
        void HidePopUps();
        Task ShowCustomPopUp(ContentView widget);
        Task<T> ShowFormCustomPopUp<T>(IWidget<T> widget, bool animate = false);
    }
}