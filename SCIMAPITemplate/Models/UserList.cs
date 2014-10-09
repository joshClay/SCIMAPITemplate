using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCIMAPITemplate.Models
{
    public class UserList : ResourceList
    {
        public List<User> Resources
        {
            get;
            set;
        }
    }
}