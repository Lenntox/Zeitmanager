
namespace Zeitmanager
{

    public class MeetingItem : ViewModelBase
    {
        private string _title;
        public string Title {
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
            get => _title;
        }

        private DateOnly _date;
        public DateOnly Date {
            set
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged(nameof(Date));
                }
            }
            get => _date; }
    }
}
