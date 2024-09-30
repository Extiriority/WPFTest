using WPFTest.Models;

namespace WPFTest.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(IReservationBook reservationBook)
        {
            CurrentViewModel = new ReservationListingViewModel(reservationBook);
        }
    }
}