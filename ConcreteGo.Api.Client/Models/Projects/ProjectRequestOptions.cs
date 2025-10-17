using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Projects
{
    [XmlRoot(ElementName = "ProjectQueryRq")]
    public class ProjectRequestOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<string> Names { get; set; } = new List<string>();
        public List<int> CustomerIDs { get; set; } = new List<int>();
        public List<string> CustomerCodes { get; set; } = new List<string>();
        public List<string> CustomerNames { get; set; } = new List<string>();
        public bool? ListOnly { get; set; }
        public DateTime? FromUpdateDate { get; set; }
        public DateTime? ToUpdateDate { get; set; }
        //SUNDRYCHARGES, CUSTOMER, PRODUCT
        public List<string> IncludeRetElements { get; set; } = new List<string>();
    }
}
