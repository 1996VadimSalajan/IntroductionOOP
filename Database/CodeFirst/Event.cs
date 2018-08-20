using System.Collections.Generic;

namespace CodeFirst
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int Createby { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}