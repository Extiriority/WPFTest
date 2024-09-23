namespace WPFTest.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private type field;

        public type property
        {
            get { return field; }
            set
            {
                field = value;
                OnPropertyChanged(nameof(property));
            }
        }
    }
}