namespace Test
{
    using System;

    public class InvoiceOperations : Operations
    {
        public InvoiceOperations(DateTime date) : base(date)
        {
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}