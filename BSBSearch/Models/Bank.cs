using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSBSearch.Models
{
    public struct Bank
    {
        public string BSBNumber { get; set; }
        [Display(Name ="Bank Code")]
        public string Instcode { get; set; }
        [Display(Name ="Branch Name")]
        public string BranchName { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Peh { get; set; }
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
