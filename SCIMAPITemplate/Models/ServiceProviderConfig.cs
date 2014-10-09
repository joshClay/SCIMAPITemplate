using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCIMAPITemplate.Models
{
    public class ServiceProviderConfig
    {
        private List<string> _schemas = new List<string>();
        public List<string> schemas { get { return _schemas; } set { _schemas = value; } }
        private List<string> _userManagementCapabilities = new List<string>();
        public List<string> userManagementCapabilities { get { return _userManagementCapabilities; } set { _userManagementCapabilities = value; } }
        public string documentationUrl { get; set; }
        private Patch _patch = new Patch();
        public Patch patch { get { return _patch; } set { _patch = value; } }
        private Bulk _bulk = new Bulk();
        public Bulk bulk { get { return _bulk; } set { _bulk = value; } }
        private Filter _filter = new Filter();
        public Filter filter { get { return _filter; } set { _filter = value; } }
        private ChangePassword _changePassword = new ChangePassword();
        public ChangePassword changePassword { get { return _changePassword; } set { _changePassword = value; } }
        private Sort _sort = new Sort();
        public Sort sort { get { return _sort; } set { _sort = value; } }
        private Etag _etag = new Etag();
        public Etag etag { get { return _etag; } set { _etag = value; } }
        private List<AuthenticationScheme> _authenticationSchemes = new List<AuthenticationScheme>();
        public List<AuthenticationScheme> authenticationSchemes { get { return _authenticationSchemes; } set { _authenticationSchemes = value; } }
        private ServiceProviderConfigMeta _meta = new ServiceProviderConfigMeta();
        public ServiceProviderConfigMeta meta { get { return _meta; } set { _meta = value; } }
    }

    public class Patch
    {
        public bool supported { get; set; }
    }

    public class Bulk
    {
        public bool supported { get; set; }
        public int maxOperations { get; set; }
        public int maxPayloadSize { get; set; }
    }

    public class Filter
    {
        public bool supported { get; set; }
        public int maxResults { get; set; }
    }

    public class ChangePassword
    {
        public bool supported { get; set; }
    }

    public class Sort
    {
        public bool supported { get; set; }
    }

    public class Etag
    {
        public bool supported { get; set; }
    }

    public class AuthenticationScheme
    {
        public string name { get; set; }
        public string description { get; set; }
        public string specUrl { get; set; }
        public string documentationUrl { get; set; }
        public string type { get; set; }
        public bool primary { get; set; }
    }

    public class ServiceProviderConfigMeta
    {
        public string location { get; set; }
        public string resourceType { get; set; }
        public string created { get; set; }
        public string lastModified { get; set; }
        public string version { get; set; }
    }
}