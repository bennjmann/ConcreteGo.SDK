using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.UOMs
{
    [XmlRoot(ElementName = "UOMQueryRs")]
    public class UOMResponse
    {
        [XmlElement(ElementName = "UOMRet")]
        public List<UOMRet>? UOMRet { get; set; }
    }
}