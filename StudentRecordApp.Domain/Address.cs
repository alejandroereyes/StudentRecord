namespace StudentRecordApp.Domain
{
    public class Address : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Street { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}