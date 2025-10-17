using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Jobs
{
    [XmlRoot(ElementName = "JobQueryRs")]
    public class JobQueryResponse
    {
        [XmlElement(ElementName = "JobRet")]
        public List<JobRet>? JobRet { get; set; }
    }
}