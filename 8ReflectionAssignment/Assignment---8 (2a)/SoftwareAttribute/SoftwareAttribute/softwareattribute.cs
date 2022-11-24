using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAttribute
{
    public class softwareattribute
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
        class SampleAttribute : Attribute
        {
            private string ProjectName;
            private string Description;
            private string ClientName;
            private string StartedDate;
            private string EndDate;
        }

        [Sample()]
        class MyClass
        {
            public string ProjectName { get; set; }
            public string Description { get; set; }
            public string ClientName { get; set; }
            public string StartedDate { get; set; }


            public string EndDate { get; set; }
        }
    }
}
