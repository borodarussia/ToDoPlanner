using System;

namespace ToDoPlanner.BL.Model
{
    public class Task
    {
        #region свойства
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public byte Priority { get; set; }
        public DateTime Created { get; }
        public DateTime Updated { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Duration { get; set; }
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
            Duration = end.Subtract(start);
        }
    }
}
