namespace Zeitmanager
{
    public partial class FaQPage : ContentPage
    {
	    public FaQPage()
	    {
            InitializeComponent();
        }
        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string email = EmailEntry.Text;
            string message = MessageEditor.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
            {
                DisplayAlert("Error", "All fields are required.", "OK");
                return;
            }

            DisplayAlert("Thanks", "Thank you for your message!", "OK");
        }
    }
}