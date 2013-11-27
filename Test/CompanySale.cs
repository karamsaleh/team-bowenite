namespace Test
{
    using System;

    [Serializable]
    public class CompanySale : Sale
    {
        public new const string Category = "companySale";

        public CompanySale(DateTime dateAndTime, int id, Invoice invoice)
            : base(dateAndTime, id)
        {
            this.Invoice = invoice;
        }

        public Invoice Invoice { get; private set; }
    }
}