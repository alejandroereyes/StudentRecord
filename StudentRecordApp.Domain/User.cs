namespace StudentRecordApp.Domain
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}