namespace DataAccess.Entities
{
    public abstract class ContactEntity
    {
        public Guid Id { get; set; }

        public abstract string FullName { get; }

        public ContactInfo? ContactInfo { get; set; }
    }
}
