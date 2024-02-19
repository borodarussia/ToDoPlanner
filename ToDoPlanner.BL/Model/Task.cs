using System;

namespace ToDoPlanner.BL.Model
{
    public class Task
    {
        #region свойства
        public int UserId { get; }
        public string Title { get; private set; }
        public string Note { get; private set; }
        public byte Priority { get; set; }
        public DateTime Created { get; }
        public DateTime Updated { get; private set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Duration { get; }
        #endregion

        public Task(string title, string note, DateTime start, DateTime end, byte priority = 7)
        {
            Title = title;
            Note = note;
            Priority = priority;
            Start = start;
            End = end;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}
