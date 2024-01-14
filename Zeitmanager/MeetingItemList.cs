using System;
using System.Collections.ObjectModel;
using Zeitmanager;

public class MeetingItemList
{
    private static ObservableCollection<MeetingItem> meetings;

    private static bool initialized = false;

    public MeetingItemList()
    {
    }

    private static void initialize()
    {
        initialized = true;
        DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        meetings = new ObservableCollection<MeetingItem>(){
                new MeetingItem { Title = "meeting1", Date = now },
                new MeetingItem { Title = "meeting2", Date = now },
                new MeetingItem { Title = "meeting3", Date = now },
                new MeetingItem { Title = "meeting4", Date = now },
                new MeetingItem { Title = "meeting5", Date = now },
                new MeetingItem { Title = "meeting6", Date = now},
                new MeetingItem { Title = "meeting7", Date = now},
                new MeetingItem { Title = "meeting8", Date = now},
            };
    }

    public static ObservableCollection<MeetingItem> getMeetings()
    {
        if (!initialized)
        {
            initialize();
        }
        return meetings;
    }


    public static void addMeeting()
    {
        meetings.Add(new MeetingItem());
    }

    public static void removeMeeting(MeetingItem meeting)
    {
        meetings.Remove(meeting);
    }
}
