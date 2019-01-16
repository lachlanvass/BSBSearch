using System.ComponentModel.DataAnnotations;

namespace BSBSearch.Models
{
    public struct Bank
    {
        // Add Regex for BSB
        // Handle valid regex but no results returned.
        [RegularExpression(@"^[0-9]{6}+", ErrorMessage = "Enter a valid 6 digit BSB Number")]
        public char[]  BSBNumber { get; set; }
        [Display(Name ="Bank Code")]
        public char[] Instcode { get; set; }
        [Display(Name ="Branch Name")]
        public string BranchName { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public char[] State { get; set; }
        public char[] Postcode { get; set; }
        public char[] Peh { get; set; }
        public Bank(BankData data)
        {
            BSBNumber = data.bsbnumber.ToCharArray();
            Instcode = data.instcode.ToCharArray();
            BranchName = data.branchname;
            StreetAddress = data.streetaddress;
            Suburb = data.suburb;
            State = data.state.ToCharArray();
            Postcode = data.postcode.ToCharArray();
            Peh = data.peh.ToCharArray();
        }
    }
}
