using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using Xamarin.Popups.Interfaces;
using Xamarin.Forms;

namespace Xamarin.Popups
{
    public class MvxPoppableViewModel : MvxViewModel, IPoppableViewModel
    {
        private IPoppable _view;
        public void SetViewBinding(object view)
        {
            if(_view == null) _view = view as IPoppable;
        }

        public async Task<bool> ShowAlert(string title, string message, string okText = "Ok", string cancelText = null)
        {
            return await _view.ShowAlert(title, message, okText, cancelText);
        }
        public void ShowLoading()
        {
            _view.ShowLoading();
        }
        public void HideLoading()
        {
            _view.HideLoading();
        }
        public async Task<T> ShowFormCustomPopUp<T>(IWidget<T> view, bool animate = false)
        {
            var result = await _view.ShowFormCustomPopUp<T>(view, animate);
            _view.HidePopUps();
            return result;
        }
        public async Task ShowCustomPopUp(ContentView view)
        {
            await _view.ShowCustomPopUp(view);
        }

        public void HidePopUps()
        {
            _view.HidePopUps();
        }
    }
}