namespace StudentRecordApp.Domain
{
    public class Course : EntityBase
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
    }
}