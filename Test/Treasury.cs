namespace Test
{
    /// <summary>
    /// Defines the treasury of the warehouse. Turnover and profit statistics are stored here.
    /// </summary>
    public struct Treasury
    {
        public static decimal Turnover { get; set; }
        public static decimal Profit { get; set; }
    }
}