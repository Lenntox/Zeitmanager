namespace Zeitmanager;

public partial class MeetingListPage : ContentPage
{
    public MeetingListPage()
    {
        InitializeComponent();
        MeetingList.ItemsSource = MeetingItemList.getMeetings();
    }

    private void AddMeeting(object sender, EventArgs e)
    {
        MeetingItemList.addMeeting();
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.Parent.Parent.BindingContext is MeetingItem item)
        {
            MeetingItemList.removeMeeting(item);
        }
    }

    private void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        if (sender is DatePicker datePicker && datePicker.BindingContext is MeetingItem myItem)
        {
            myItem.Date = DateOnly.FromDateTime(e.NewDate);
        }
    }
}