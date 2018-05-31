namespace Xamarin.Popups.Interfaces
{
    public interface IPoppableViewModel
    {
        void SetViewBinding(object view);
        IPoppable PoppableService { get; set; }
    }
}