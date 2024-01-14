using System.Collections.ObjectModel;
using Zeitmanager;

public class ToDoItemList
{

    private static ObservableCollection<ToDoItem> toDoItems;

    private static bool initialized = false;

    public ToDoItemList() {
    }

    private static void initialize()
    {
        initialized = true;
        toDoItems = new ObservableCollection<ToDoItem>(){
                new ToDoItem { Title = "todo1", isChecked = true },
                new ToDoItem { Title = "todo2", isChecked = false },
                new ToDoItem { Title = "todo3" , isChecked = false},
                new ToDoItem { Title = "todo4" , isChecked = false},
                new ToDoItem { Title = "todo5" , isChecked = false},
                new ToDoItem { Title = "todo6" , isChecked = false},
                new ToDoItem { Title = "todo7" , isChecked = false},
                new ToDoItem { Title = "todo8" , isChecked = false},
            };
    }

    public static ObservableCollection<ToDoItem> getToDoList()
    {
        if (!initialized)
        {
            initialize();
        }
        return toDoItems;
    }


    public static void addToDoItem()
    {
        toDoItems.Add(new ToDoItem());
    }

    public static void removeToDoItem(ToDoItem item)
    {
        toDoItems.Remove(item);
    }
}
