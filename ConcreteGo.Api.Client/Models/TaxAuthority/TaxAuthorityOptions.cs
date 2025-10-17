using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.TaxAuthority
{
    [XmlRoot(ElementName = "TaxAuthorityQueryRq")]
    public class TaxAuthorityOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> Codes { get; set; } = new List<string>();
    }
}
