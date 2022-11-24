using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeFullNameLibrary
{
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string TheFullName(string FirstName, string LastName)
        {
            return "FullName is " + FirstName + LastName;
        }
    }
}
