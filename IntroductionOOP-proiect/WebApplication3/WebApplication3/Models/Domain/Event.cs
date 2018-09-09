using System.Collections.Generic;

namespace CodeFirst
{
    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<EventsStudent> EventsStudents { get; set; }
    }
}