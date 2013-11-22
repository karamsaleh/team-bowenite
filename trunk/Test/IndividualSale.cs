namespace Test
{
    using System;

    public class IndividualSale : Sale
    {
        public new const string Category = "individualSale";

        public IndividualSale(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
        }
    }
}