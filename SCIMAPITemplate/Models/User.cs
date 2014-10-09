using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCIMAPITemplate.Models
{
    public class User
    {
        public List<string> schemas { get; set; }
        public string id { get; set; }
        public UserMeta meta { get; set; }
        public Name name { get; set; }
        public string userName { get; set; }
        public List<PhoneNumber> phoneNumbers { get; set; }
        public List<Email> emails { get; set; }
        public bool active { get; set; }
        public List<Group> groups { get; set; }
    }

    public class CustomAttributes
    {
        public string foo { get; set; }
    }

    public class UserMeta
    {
        public string created { get; set; }
        public string lastModified { get; set; }
        public string location { get; set; }
        public string version { get; set; }
    }

    public class Name
    {
        public string formatted { get; set; }
        public string familyName { get; set; }
        public string givenName { get; set; }
    }

    public class PhoneNumber
    {
        public string value { get; set; }
        public string type { get; set; }
    }

    public class Email
    {
        public string value { get; set; }
        public string type { get; set; }
        public bool primary { get; set; }
    }
}