using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.TaxCodes
{
    [XmlRoot(ElementName = "TaxCodeQueryRs")]
    public class TaxCodeResponse
    {
        [XmlElement(ElementName = "TaxCodeRet")]
        public List<TaxCodeRet>? TaxCodeRet { get; set; }
    }
}