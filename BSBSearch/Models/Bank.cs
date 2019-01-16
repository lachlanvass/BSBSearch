using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSBSearch.Models
{
    public class Bank
    {
        public string BSBNumber { get; set; }
        public string Instcode { get; set; }
        public string BranchName { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Peh { get; set; }

        public Bank() { }
        public Bank(BankData data)
        {
            BSBNumber = data.bsbnumber;
            Instcode = data.instcode;
            BranchName = data.branchname;
            StreetAddress = data.streetaddress;
            Suburb = data.suburb;
            State = data.state;
            Postcode = data.postcode;
            Peh = data.peh;
        }
    }
}
