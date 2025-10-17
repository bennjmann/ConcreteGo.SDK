using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.TaxLocations
{
    [XmlRoot(ElementName = "TaxLocationQueryRs")]
    public class TaxLocationResponse
    {
        [XmlElement(ElementName = "TaxLocationRet")]
        public List<TaxLocationRet>? TaxLocationRet { get; set; }
    }
}