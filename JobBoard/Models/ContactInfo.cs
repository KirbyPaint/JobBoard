using System.Collections.Generic;

namespace JobBoard.Models
{
  public class ContactInfo
  {
    public string Name {get; set;}
    public string Email {get; set;}
    public string PhoneNumber {get; set;}

    private static List<ContactInfo> _instances = new List<ContactInfo> {};
    public ContactInfo(string name, string email, string phoneNumber)
    {
      Name = name;
      Email = email;
      PhoneNumber = phoneNumber;
      _instances.Add(this);
    }
    public static List<ContactInfo> GetAll()
    {
      return _instances;
    }
  }
}