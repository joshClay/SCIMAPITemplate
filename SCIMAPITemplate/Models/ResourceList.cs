using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCIMAPITemplate.Models
{
    public class ResourceList
    {
        public int totalResults
        {
            get;
            set;
        }

        public List<string> schemas
        {
            get;
            set;
        }
    }
}