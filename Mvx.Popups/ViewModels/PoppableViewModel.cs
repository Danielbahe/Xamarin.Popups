using Xamarin.Popups.Interfaces;

namespace Xamarin.Popups.ViewModels
{
    public abstract class PoppableViewModel : IPoppableViewModel
    {
        public IPoppable PoppableService { get; set; }
        public void SetViewBinding(object view)
        {
            if (PoppableService == null) PoppableService = view as IPoppable;
        }
    }
}