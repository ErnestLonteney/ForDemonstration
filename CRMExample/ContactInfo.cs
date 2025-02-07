using System.Text.RegularExpressions;

namespace CRMExample
{
    public class ContactInfo
    {
        public int Id  { get; }
        public string Group { get; }
        public string Value { get; set; }

        public ContactInfo(int id, string group, string value )
        {
            Id = id;    
            Group = group;
            Value = value;  
        }

    }
}