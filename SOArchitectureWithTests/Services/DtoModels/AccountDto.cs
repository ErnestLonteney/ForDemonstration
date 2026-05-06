namespace Services.DtoModels
{
    public class AccountDto : ContactEntityDto
    {     
        public string Name { get; set; } = string.Empty;
        public string? ShortName { get; set; }


        public List<ContactDto> Contacts { get; set; } = [];
    }
}