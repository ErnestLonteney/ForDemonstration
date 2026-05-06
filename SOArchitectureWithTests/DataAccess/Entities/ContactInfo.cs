namespace DataAccess.Entities
{
    public class ContactInfo
    {
        public Guid Id { get; set; }

        public string? Phone1 { get; set; }

        public string? Phone2 { get; set; }

        public string? Email { get; set; }

        public ICollection<ContactEntity> ContactEntities { get; set; } = new List<ContactEntity>();
    }
}
