using System;
using System.Collections.Generic;
using System.Text;

namespace TestDapper
{
    public class Customer : GrowEntity
    {
        public string Name 
        { 
            get 
            {
                if (name_ == "") // this code should be part of init in c# 9.0
                {
                    name_ = this.PopPrimaryField("Name");
                }
                return name_;
            }
        }

        public string Address
        {
            get { return this.FindSecondaryField("Address"); }
        }

        public string AccountCode
        {
            get { return this.FindPrimaryField("AccountCode"); }
        }

        public string BusinessUnit
        {
            get { return this.FindPrimaryField("BusinessUnit"); }
        }

        public string DisplayInfo
        {
            get
            {
                // "GKN (DNA001) Solihull"
                return $"{Name} ({AccountCode}) {BusinessUnit}";
            }
        }

        string name_;
    }
}
