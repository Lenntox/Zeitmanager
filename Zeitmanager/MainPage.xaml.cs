
using System.Globalization;

namespace Zeitmanager
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            todoList.ItemsSource = ToDoItemList.getToDoList().Take(4);
            meetingList.ItemsSource = MeetingItemList.getMeetings().Take(6);
        }

        private void OnToDoSeeAllTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ToDoListPage());
        }
        private void OnMeetingSeeAllTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MeetingListPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            todoList.ItemsSource = ToDoItemList.getToDoList().Take(4);
            meetingList.ItemsSource = MeetingItemList.getMeetings().Take(6);
        }
    }
}
