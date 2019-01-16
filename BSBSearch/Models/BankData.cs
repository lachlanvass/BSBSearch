namespace BSBSearch.Models
{
    public struct BankData
    {
        public string bsbnumber { get; set; }
        public string instcode { get; set; }
        public string branchname { get; set; }
        public string streetaddress { get; set; }
        public string suburb { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string peh { get; set; }
    }

    public struct RootObject
    {
        public string status { get; set; }
        public string message { get; set; }
        public string code { get; set; }
        public BankData data { get; set; }
    }
}
