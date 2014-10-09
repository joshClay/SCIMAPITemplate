using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCIMAPITemplate.Models
{
    public class Group
    {
        public List<string> schemas { get; set; }
        public string value { get; set; }
        public string display { get; set; }
        public List<Member> members { get; set; }
    }

    public class Member
    {
        public string value { get; set; }
        public string displayName { get; set; }
        public string type { get; set; }
    }
}