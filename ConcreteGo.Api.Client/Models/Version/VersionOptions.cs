using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Version
{
    [XmlRoot(ElementName = "VersionQueryRq")]
    public class VersionOptions
    {
        // Version query typically doesn't need any filter options, 
        // but keeping the class for consistency with the pattern
    }
}