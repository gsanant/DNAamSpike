using System;
using System.Collections.Generic;
using System.Text;

namespace TestDapper
{
    public class GrowEntity
    {
        public string Id { get; set; } // replace set by init after using C# 9.0
        public string Primary { get; set; }
        public string Secondary { get; set; }

        public string FindPrimaryField(string tag)
        {
            throw new NotImplementedException();
        }

        public string PopPrimaryField(string tag)
        {
            throw new NotImplementedException();
        }

        public string AddPrimaryField(string tag, string values)
        {
            throw new NotImplementedException();
        }

        public string FindSecondaryField(string tag)
        {
            throw new NotImplementedException();
        }
    }
}
