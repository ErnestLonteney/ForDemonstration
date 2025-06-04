namespace IntefacesExample;

interface IContactInfo
{
    string Phone { get; set; }
    string Email { get; set; }
    string Address { get; set; }

    void PrintContactInfo();
    void SayHello();
}
