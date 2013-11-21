namespace Test
{
    using System;

    public class InvoiceOperations : Operations
    {
        public InvoiceOperations(DateTime dateAndTime, int id) : base(dateAndTime, id)
        {
        }

        public override string Category { get { return "invoice operations"; } }
        
        public override void Validate()
        {
           // throw new NotImplementedException();
        }
    }
}