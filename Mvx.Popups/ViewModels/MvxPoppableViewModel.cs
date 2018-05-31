using MvvmCross.Core.ViewModels;
using Xamarin.Popups.Interfaces;

namespace Xamarin.Popups.ViewModels
{
    public abstract class MvxPoppableViewModel : MvxViewModel, IPoppableViewModel
    {
        public IPoppable PoppableService { get; set; }

        public void SetViewBinding(object view)
        {
            if (PoppableService == null) PoppableService = view as IPoppable;
        }
    }

    public abstract class MvxPoppableViewModel<TParameter> : MvxViewModel<TParameter>, IPoppableViewModel
    {
        public IPoppable PoppableService { get; set; }

        public void SetViewBinding(object view)
        {
            if (PoppableService == null) PoppableService = view as IPoppable;
        }
    }

    public abstract class MvxPoppableViewModel<TParameter, TResult> : MvxViewModel<TParameter, TResult>,
        IPoppableViewModel
    {
        public IPoppable PoppableService { get; set; }

        public void SetViewBinding(object view)
        {
            if (PoppableService == null) PoppableService = view as IPoppable;
        }
    }
}