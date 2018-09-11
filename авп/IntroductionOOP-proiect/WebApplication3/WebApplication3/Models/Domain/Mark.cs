namespace CodeFirst
{
    public class Mark
    {
        public int Id { get; set; }
        public int CoursId { get; set; }
        public int StudentId { get; set; }
        public int? Value { get; set; }
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}