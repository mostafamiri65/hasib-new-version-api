namespace HasibDmsNew.Domain.Entities.Commons.MoneyUnits
{
    /// <summary>
    /// واحد پول
    /// </summary>
    public class MoneyUnit
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Abbreviation { get; set; }
        public bool IsDefault { get; set; }
        public bool IsBase { get; set; }
    }
}
