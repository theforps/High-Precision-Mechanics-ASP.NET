namespace High_precisionMechanics.Models
{
    public class Agreement
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public bool CustomerServiceManager { get; set; }
        public bool HeadOfQualityDepartment { get; set; }
        public bool HeadOfLogistics { get; set; }
        public bool HeadOfTheEconomicDepartment { get; set; }
        public bool HeaOfProduction { get; set; }
    }
}
