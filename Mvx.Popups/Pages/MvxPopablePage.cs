using System;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Popups.Interfaces;
using Xamarin.Popups.Widgets;

namespace Xamarin.Popups.Pages
{
    public class MvxPoppablePage : MvxContentPage, IPoppable
    {
        private Grid grid;

        public MvxPoppablePage()
        {
            BackgroundColor = Color.White;
            Padding = new Thickness(0);

            grid = new Grid();
            grid.BackgroundColor = Color.White;
            grid.Padding = new Thickness(0);

            Content = grid;
        }

        public View PageLayout
        {
            get { return (grid.Children.Count > 0) ? grid.Children[0] : null; }
            set
            {
                grid.Children.Add(value);
            }
        }

        protected override void OnViewModelSet()
        {
            var vm = ViewModel as IPoppableViewModel;
            vm.SetViewBinding(this);
        }

        public async Task<bool> ShowAlert(string title, string message, string okText = "Ok", string cancelText = null)
        {
            bool result = true;
            if (cancelText == null)
            {
                await DisplayAlert(title, message, okText);
            }
            else
            {
                result = false;
                result = await DisplayAlert(title, message, okText, cancelText);
            }
            return result;
        }
        public async Task ShowCustomPopUp(ContentView widget)
        {
            this.grid.Children.Add(widget);
        }

        public async Task<T> ShowFormCustomPopUp<T>(IWidget<T> widget)
        {
            var view = widget as ContentView;
            this.grid.Children.Add(view);
            return await widget.GetAnswer();
        }
        public async Task<T> ShowFormCustomPopUp<T>(IWidget<T> widget, bool animate = false)
        {
            var view = widget as ContentView;
            this.grid.Children.Add(view);
            if (animate)
            {
                if (!typeof(T).IsAssignableFrom(typeof(IPopupAnimable))) throw new Exception("Widget have no animation, must implement IPopupAnimable");
                var animateWidget = widget as IPopupAnimable;
                animateWidget.Animate();
            }
            return await widget.GetAnswer();
        }

        public void ShowLoading(string loadingImage = null, string loadingText = null)
        {
            var loading = new LoadingWidget(loadingImage, loadingText);
            this.grid.Children.Add(loading);
            loading.Animate();
        }

        public void HideLoading()
        {
            hidePopUps();
        }

        public void HidePopUps()
        {
            hidePopUps();
        }

        private void hidePopUps()
        {
            if (grid.Children.Count > 1)
            {
                for (int index = grid.Children.Count - 1; index > 0; index--)
                {
                    grid.Children.RemoveAt(index);
                }
            }
        }
    }
}