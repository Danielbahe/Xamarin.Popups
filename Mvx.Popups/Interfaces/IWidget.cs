using System.Threading.Tasks;

namespace Xamarin.Popups.Interfaces
{
    public interface IWidget<T>
    {
        Task<T> GetAnswer();
        T Answer { get; set; }
        bool Answered { get; set; }
    }
}