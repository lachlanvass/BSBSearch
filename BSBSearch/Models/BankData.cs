using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSBSearch.Models
{
    public class BankData
    {
        public string bsbnumber { get; set; }
        public string instcode { get; set; }
        public string branchname { get; set; }
        public string streetaddress { get; set; }
        public string suburb { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string peh { get; set; }

        //public BankData(RootObject root)
        //{
        //    bsbnumber = root.data.bsbnumber;
        //    instcode = root.data.instcode;
        //    branchname = root.data.branchname;
        //    streetaddress = root.data.streetaddress;
        //    suburb = root.data.suburb;
        //    state = root.data.state;
        //    postcode = root.data.postcode;
        //    peh = root.data.peh;
        //}
    }

    public class RootObject
    {
        public string status { get; set; }
        public string message { get; set; }
        public string code { get; set; }
        public BankData data { get; set; }
    }
}
