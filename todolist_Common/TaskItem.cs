using System;

public class TaskItem
{
    public string User { get; set; }
    public string Task { get; set; }
    public DateTime DateAndTime { get; set; }

    public TaskItem(string user, string task, DateTime dateAndTime)
    {
        User = user;
        Task = task;
        DateAndTime = dateAndTime;
    }

    public override string ToString()
    {
        return $"{Task} (Added: {DateAndTime:g})";
    }
}