namespace StudentRecordApp.Domain
{
    public class Credit : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }
}