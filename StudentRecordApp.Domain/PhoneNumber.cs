namespace StudentRecordApp.Domain
{
    public class PhoneNumber : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int AreaCode { get; set; }
        public int Prefix { get; set; }
        public int Suffix { get; set; }

        public override string ToString()
        {
            return $"{AreaCode}-{Prefix}-{Suffix}";
        }
    }
}