using System.Windows.Input;

namespace Zeitmanager;

public partial class ToDoListPage : ContentPage
{
	public ToDoListPage()
	{
		InitializeComponent();
		todoList.ItemsSource = ToDoItemList.getToDoList();
	}

    private void AddToDo(object sender, EventArgs e)
    {
        ToDoItemList.addToDoItem();
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.Parent.Parent.BindingContext is ToDoItem item)
        {
            ToDoItemList.removeToDoItem(item);
        }
    }
}